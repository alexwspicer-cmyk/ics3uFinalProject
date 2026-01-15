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
            this.testOutputLabel.Location = new System.Drawing.Point(121, 12);
            this.testOutputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testOutputLabel.Name = "testOutputLabel";
            this.testOutputLabel.Size = new System.Drawing.Size(349, 318);
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
            this.ventButton.Location = new System.Drawing.Point(12, 333);
            this.ventButton.Name = "ventButton";
            this.ventButton.Size = new System.Drawing.Size(209, 48);
            this.ventButton.TabIndex = 1;
            this.ventButton.Text = "RESET VENTILATION";
            this.ventButton.UseVisualStyleBackColor = true;
            this.ventButton.Click += new System.EventHandler(this.ventButton_Click);
            // 
            // audioResetButton
            // 
            this.audioResetButton.Location = new System.Drawing.Point(12, 400);
            this.audioResetButton.Name = "audioResetButton";
            this.audioResetButton.Size = new System.Drawing.Size(209, 48);
            this.audioResetButton.TabIndex = 2;
            this.audioResetButton.Text = "RESET AUDIO";
            this.audioResetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 477);
            this.Controls.Add(this.audioResetButton);
            this.Controls.Add(this.ventButton);
            this.Controls.Add(this.testOutputLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

