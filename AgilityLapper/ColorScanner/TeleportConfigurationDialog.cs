using Gma.UserActivityMonitor;
using System;
using System.Windows.Forms;

namespace ColorScanner
{
    public partial class TeleportConfigurationDialog : Form
    {
        private bool recordingActive = false;

        public TeleportConfigurationDialog()
        {
            InitializeComponent();

            HookManager.KeyUp += HandleKeyUp;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            recordingActive = true;
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            if (!recordingActive)
            {
                return;
            }

            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            recordingActive = false;

            ColorScannerMainForm.teleportX = Cursor.Position.X;
            ColorScannerMainForm.teleportY = Cursor.Position.Y;
            ColorScannerMainForm.teleportCoordsActive = true;

            var confirmationMessage = "Coordinates have been successfully saved.";
            var confirmationCaption = "Success";
            var confirmationButtons = MessageBoxButtons.OK;

            MessageBox.Show(confirmationMessage, confirmationCaption, confirmationButtons);

            Close();
        }
    }
}
