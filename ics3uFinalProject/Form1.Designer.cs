namespace ics3uFinalProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.testOutputLabel = new System.Windows.Forms.Label();
            this.ventTimer = new System.Windows.Forms.Timer(this.components);
            this.ventButton = new System.Windows.Forms.Button();
            this.audioResetButton = new System.Windows.Forms.Button();
            this.aggressionTimer = new System.Windows.Forms.Timer(this.components);
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // testOutputLabel
            // 
            this.testOutputLabel.Location = new System.Drawing.Point(386, 11);
            this.testOutputLabel.Name = "testOutputLabel";
            this.testOutputLabel.Size = new System.Drawing.Size(465, 567);
            this.testOutputLabel.TabIndex = 0;
            // 
            // ventTimer
            // 
            this.ventTimer.Enabled = true;
            this.ventTimer.Interval = 9000;
            this.ventTimer.Tick += new System.EventHandler(this.ventTimer_Tick);
            // 
            // ventButton
            // 
            this.ventButton.Location = new System.Drawing.Point(16, 410);
            this.ventButton.Margin = new System.Windows.Forms.Padding(4);
            this.ventButton.Name = "ventButton";
            this.ventButton.Size = new System.Drawing.Size(279, 59);
            this.ventButton.TabIndex = 1;
            this.ventButton.Text = "RESET VENTILATION";
            this.ventButton.UseVisualStyleBackColor = true;
            this.ventButton.Click += new System.EventHandler(this.ventButton_Click);
            // 
            // audioResetButton
            // 
            this.audioResetButton.Location = new System.Drawing.Point(16, 492);
            this.audioResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.audioResetButton.Name = "audioResetButton";
            this.audioResetButton.Size = new System.Drawing.Size(279, 59);
            this.audioResetButton.TabIndex = 2;
            this.audioResetButton.Text = "RESET AUDIO";
            this.audioResetButton.UseVisualStyleBackColor = true;
            // 
            // aggressionTimer
            // 
            this.aggressionTimer.Enabled = true;
            this.aggressionTimer.Interval = 15000;
            this.aggressionTimer.Tick += new System.EventHandler(this.aggressionTimer_Tick);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 60000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(13, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(227, 88);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 587);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.audioResetButton);
            this.Controls.Add(this.ventButton);
            this.Controls.Add(this.testOutputLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label testOutputLabel;
        private System.Windows.Forms.Timer ventTimer;
        private System.Windows.Forms.Button ventButton;
        private System.Windows.Forms.Button audioResetButton;
        private System.Windows.Forms.Timer aggressionTimer;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label timeLabel;
    }
}

