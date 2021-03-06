﻿namespace ColorScanner
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
            this.teleportCoordinatesLabel = new System.Windows.Forms.Label();
            this.obstacleColorLabel = new System.Windows.Forms.Label();
            this.lastClickCoordinateLabel = new System.Windows.Forms.Label();
            this.teleportCoordinatesValue = new System.Windows.Forms.Label();
            this.obstacleColorValue = new System.Windows.Forms.Label();
            this.lastClickCoordinatesValue = new System.Windows.Forms.Label();
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
            // teleportCoordinatesLabel
            // 
            this.teleportCoordinatesLabel.AutoSize = true;
            this.teleportCoordinatesLabel.Location = new System.Drawing.Point(14, 105);
            this.teleportCoordinatesLabel.Name = "teleportCoordinatesLabel";
            this.teleportCoordinatesLabel.Size = new System.Drawing.Size(108, 13);
            this.teleportCoordinatesLabel.TabIndex = 5;
            this.teleportCoordinatesLabel.Text = "Teleport Coordinates:";
            // 
            // obstacleColorLabel
            // 
            this.obstacleColorLabel.AutoSize = true;
            this.obstacleColorLabel.Location = new System.Drawing.Point(14, 128);
            this.obstacleColorLabel.Name = "obstacleColorLabel";
            this.obstacleColorLabel.Size = new System.Drawing.Size(79, 13);
            this.obstacleColorLabel.TabIndex = 6;
            this.obstacleColorLabel.Text = "Obstacle Color:";
            // 
            // lastClickCoordinateLabel
            // 
            this.lastClickCoordinateLabel.AutoSize = true;
            this.lastClickCoordinateLabel.Location = new System.Drawing.Point(14, 150);
            this.lastClickCoordinateLabel.Name = "lastClickCoordinateLabel";
            this.lastClickCoordinateLabel.Size = new System.Drawing.Size(115, 13);
            this.lastClickCoordinateLabel.TabIndex = 7;
            this.lastClickCoordinateLabel.Text = "Last Click Coordinates:";
            // 
            // teleportCoordinatesValue
            // 
            this.teleportCoordinatesValue.AutoSize = true;
            this.teleportCoordinatesValue.Location = new System.Drawing.Point(128, 105);
            this.teleportCoordinatesValue.Name = "teleportCoordinatesValue";
            this.teleportCoordinatesValue.Size = new System.Drawing.Size(0, 13);
            this.teleportCoordinatesValue.TabIndex = 8;
            // 
            // obstacleColorValue
            // 
            this.obstacleColorValue.AutoSize = true;
            this.obstacleColorValue.Location = new System.Drawing.Point(99, 128);
            this.obstacleColorValue.Name = "obstacleColorValue";
            this.obstacleColorValue.Size = new System.Drawing.Size(0, 13);
            this.obstacleColorValue.TabIndex = 9;
            // 
            // lastClickCoordinatesValue
            // 
            this.lastClickCoordinatesValue.AutoSize = true;
            this.lastClickCoordinatesValue.Location = new System.Drawing.Point(135, 150);
            this.lastClickCoordinatesValue.Name = "lastClickCoordinatesValue";
            this.lastClickCoordinatesValue.Size = new System.Drawing.Size(0, 13);
            this.lastClickCoordinatesValue.TabIndex = 10;
            // 
            // ColorScannerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 177);
            this.Controls.Add(this.lastClickCoordinatesValue);
            this.Controls.Add(this.obstacleColorValue);
            this.Controls.Add(this.teleportCoordinatesValue);
            this.Controls.Add(this.lastClickCoordinateLabel);
            this.Controls.Add(this.obstacleColorLabel);
            this.Controls.Add(this.teleportCoordinatesLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.configureObstacleColor);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.configureTeleportButton);
            this.Name = "ColorScannerMainForm";
            this.Text = "Agility Lapper";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button configureTeleportButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button configureObstacleColor;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label teleportCoordinatesLabel;
        private System.Windows.Forms.Label obstacleColorLabel;
        private System.Windows.Forms.Label lastClickCoordinateLabel;
        private System.Windows.Forms.Label teleportCoordinatesValue;
        private System.Windows.Forms.Label obstacleColorValue;
        private System.Windows.Forms.Label lastClickCoordinatesValue;
    }
}

