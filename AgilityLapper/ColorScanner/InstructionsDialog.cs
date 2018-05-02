using Gma.UserActivityMonitor;
using System;
using System.Windows.Forms;

namespace ColorScanner
{
    public partial class InstructionsDialog : Form
    {
        private bool recordingActive = false;

        public InstructionsDialog()
        {
            InitializeComponent();

            HookManager.MouseDown += HandleMouseDown;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            recordingActive = true;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (!recordingActive)
            {
                return;
            }

            recordingActive = false;

            ColorScannerMainForm.teleportX = e.X;
            ColorScannerMainForm.teleportY = e.Y;

            var confirmationMessage = "Coordinates have been successfully saved.";
            var confirmationCaption = "Success";
            var confirmationButtons = MessageBoxButtons.OK;

            MessageBox.Show(confirmationMessage, confirmationCaption, confirmationButtons);

            Close();
        }
    }
}
