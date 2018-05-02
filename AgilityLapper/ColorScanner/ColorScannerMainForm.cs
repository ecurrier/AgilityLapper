﻿using Gma.UserActivityMonitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ColorScanner
{
    public partial class ColorScannerMainForm : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        private bool playbackActive = false;
        private BackgroundWorker playbackThread = new BackgroundWorker();

        private Color agilityObstacleColor;
        private int agilityObstacleArgb;

        public static int teleportX;
        public static int teleportY;

        public ColorScannerMainForm()
        {
            InitializeComponent();

            var colorFromHex = ColorTranslator.FromHtml("#969618");
            agilityObstacleColor = Color.FromArgb(255, colorFromHex.R, colorFromHex.G, colorFromHex.B);
            agilityObstacleArgb = agilityObstacleColor.ToArgb();

            playbackThread.DoWork += MainLoop;
            playbackThread.WorkerSupportsCancellation = true;

            HookManager.KeyDown += HandleKeyDown;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DisplayInstructions();
            RetrieveTeleportCoords();

            playbackThread.RunWorkerAsync();
        }

        private void DisplayInstructions()
        {
            var instructionsMessage = @"For this program to work correctly, please set up the following:

Set Agility in OSBuddy to ON
Set Agility ""Obstacle color"" to #ffff29
Set Agility ""Warning color"" to #ffff29
Set Agility ""Mark entire clickable area"" to ON
Set Agility ""Fill area"" to ON

Set ""Disable 3d rendering"" to OFF

Open up the spell book tab";

            var instructionsCaption = "Instructions";
            var instructionsButtons = MessageBoxButtons.OK;

            MessageBox.Show(instructionsMessage, instructionsCaption, instructionsButtons);
        }

        private void RetrieveTeleportCoords()
        {
            var form = new InstructionsDialog();
            form.ShowDialog();
        }

        private void MainLoop(object sender, DoWorkEventArgs e)
        {
            playbackActive = true;
            var lastValidPointFound = new Stopwatch();
            lastValidPointFound.Start();

            while (playbackActive)
            {
                var validPoint = RetrieveValidPoint();

                if (lastValidPointFound.ElapsedMilliseconds > 3500)
                {
                    ExecuteTeleport();
                    lastValidPointFound.Restart();
                    continue;
                }

                if (validPoint != null)
                {
                    ExecuteClick(validPoint);
                    lastValidPointFound.Restart();
                }
            }
        }

        private Point? RetrieveValidPoint()
        {
            List<Point> result = new List<Point>();
            using (Bitmap bmp = GetScreenShot())
            {
                for (int x = 0; x < bmp.Width; x += 25)
                {
                    for (int y = 0; y < bmp.Height; y += 25)
                    {
                        var pixel = bmp.GetPixel(x, y);
                        var pixelColor = pixel.ToArgb();

                        if (agilityObstacleArgb.Equals(pixelColor))
                        {
                            return new Point(x, y);
                        }
                    }
                }
            }

            return null;
        }

        private Bitmap GetScreenShot()
        {
            Bitmap result = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            {
                using (Graphics gfx = Graphics.FromImage(result))
                {
                    gfx.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                }
            }

            return result;
        }

        private void ExecuteTeleport()
        {
            Cursor.Position = new Point(teleportX, teleportY);

            Thread.Sleep(new Random().Next(150, 451));

            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);

            Thread.Sleep(new Random().Next(4000, 5000));
        }

        private void ExecuteClick(Point? point)
        {
            Cursor.Position = new Point(point.Value.X, point.Value.Y);

            Thread.Sleep(new Random().Next(100, 125));

            var color = GetColorAtCursor(new Point(Cursor.Position.X, Cursor.Position.Y));
            if (color.ToArgb() != agilityObstacleArgb)
            {
                return;
            }

            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);

            Thread.Sleep(new Random().Next(3500, 4000));
        }

        private Color GetColorAtCursor(Point? point)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, point.Value.X, point.Value.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            PausePlayback();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            ResumePlayback();
        }

        private void PausePlayback()
        {
            playbackActive = false;
            playbackThread.CancelAsync();
        }

        private void ResumePlayback()
        {
            playbackActive = true;
            playbackThread.RunWorkerAsync();
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    PausePlayback();
                    return;
                case Keys.F2:
                    ResumePlayback();
                    return;
            }
        }
    }
}