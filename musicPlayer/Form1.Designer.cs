namespace musicPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.songButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.volumeControl = new System.Windows.Forms.TrackBar();
            this.nextButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // songButton
            // 
            this.songButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.songButton.Location = new System.Drawing.Point(136, 157);
            this.songButton.Name = "songButton";
            this.songButton.Size = new System.Drawing.Size(110, 23);
            this.songButton.TabIndex = 0;
            this.songButton.Text = "Select Song";
            this.songButton.UseVisualStyleBackColor = false;
            this.songButton.Click += new System.EventHandler(this.songButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(155, 207);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play/Pause";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // volumeControl
            // 
            this.volumeControl.Location = new System.Drawing.Point(384, 1);
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeControl.Size = new System.Drawing.Size(45, 229);
            this.volumeControl.TabIndex = 4;
            this.volumeControl.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(272, 207);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(38, 207);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 255);
            this.Controls.Add(this.volumeControl);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.songButton);
            this.Name = "Form1";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button songButton;
        private Button playButton;
        private TrackBar volumeControl;
        private Button nextButton;
        private Button restartButton;
    }
}