namespace ColorScanner
{
    partial class ColorScannerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.configureTeleportButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.configureObstacleColor = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configureTeleportButton
            // 
            this.configureTeleportButton.Location = new System.Drawing.Point(14, 13);
            this.configureTeleportButton.Name = "configureTeleportButton";
            this.configureTeleportButton.Size = new System.Drawing.Size(133, 33);
            this.configureTeleportButton.TabIndex = 0;
            this.configureTeleportButton.Text = "Configure Teleport";
            this.configureTeleportButton.UseVisualStyleBackColor = true;
            this.configureTeleportButton.Click += new System.EventHandler(this.configureTeleportButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(186, 52);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(85, 35);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause (F2)";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // configureObstacleColor
            // 
            this.configureObstacleColor.Location = new System.Drawing.Point(161, 13);
            this.configureObstacleColor.Name = "configureObstacleColor";
            this.configureObstacleColor.Size = new System.Drawing.Size(133, 33);
            this.configureObstacleColor.TabIndex = 3;
            this.configureObstacleColor.Text = "Configure Obstacle Color";
            this.configureObstacleColor.UseVisualStyleBackColor = true;
            this.configureObstacleColor.Click += new System.EventHandler(this.configureObstacleColor_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(39, 52);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 35);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start (F1)";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ColorScannerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 96);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.configureObstacleColor);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.configureTeleportButton);
            this.Name = "ColorScannerMainForm";
            this.Text = "Agility Lapper";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button configureTeleportButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button configureObstacleColor;
        private System.Windows.Forms.Button startButton;
    }
}

