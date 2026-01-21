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
            this.room1Button = new System.Windows.Forms.Button();
            this.room2Button = new System.Windows.Forms.Button();
            this.room3Button = new System.Windows.Forms.Button();
            this.room4Button = new System.Windows.Forms.Button();
            this.room5Button = new System.Windows.Forms.Button();
            this.room6Button = new System.Windows.Forms.Button();
            this.room7Button = new System.Windows.Forms.Button();
            this.room8Button = new System.Windows.Forms.Button();
            this.room9Button = new System.Windows.Forms.Button();
            this.room10Button = new System.Windows.Forms.Button();
            this.room11Button = new System.Windows.Forms.Button();
            this.room12Button = new System.Windows.Forms.Button();
            this.room13Button = new System.Windows.Forms.Button();
            this.room14Button = new System.Windows.Forms.Button();
            this.room15Button = new System.Windows.Forms.Button();
            this.mapToggleButton = new System.Windows.Forms.Button();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.audioButton = new System.Windows.Forms.Button();
            this.panelToggleButton = new System.Windows.Forms.Button();
            this.panelNameLabel = new System.Windows.Forms.Label();
            this.mapPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).BeginInit();
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
            this.testOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.testOutputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.testOutputLabel.Location = new System.Drawing.Point(385, 136);
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
            this.ventButton.BackColor = System.Drawing.Color.Transparent;
            this.ventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.ventButton.FlatAppearance.BorderSize = 3;
            this.ventButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.ventButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventButton.ForeColor = System.Drawing.Color.Olive;
            this.ventButton.Location = new System.Drawing.Point(16, 410);
            this.ventButton.Margin = new System.Windows.Forms.Padding(4);
            this.ventButton.Name = "ventButton";
            this.ventButton.Size = new System.Drawing.Size(184, 59);
            this.ventButton.TabIndex = 1;
            this.ventButton.Text = "RESET VENTILATION";
            this.ventButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventButton.UseVisualStyleBackColor = false;
            this.ventButton.Click += new System.EventHandler(this.ventButton_Click);
            // 
            // audioResetButton
            // 
            this.audioResetButton.BackColor = System.Drawing.Color.Transparent;
            this.audioResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audioResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.audioResetButton.FlatAppearance.BorderSize = 3;
            this.audioResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.audioResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.audioResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioResetButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioResetButton.ForeColor = System.Drawing.Color.Olive;
            this.audioResetButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.audioResetButton.Location = new System.Drawing.Point(16, 492);
            this.audioResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.audioResetButton.Name = "audioResetButton";
            this.audioResetButton.Size = new System.Drawing.Size(184, 59);
            this.audioResetButton.TabIndex = 2;
            this.audioResetButton.Text = "RESET \r\nAUDIO";
            this.audioResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.audioResetButton.UseVisualStyleBackColor = false;
            this.audioResetButton.Click += new System.EventHandler(this.audioResetButton_Click);
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
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("MS Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Olive;
            this.timeLabel.Location = new System.Drawing.Point(6, 718);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(227, 89);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            // 
            // room1Button
            // 
            this.room1Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room1Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room1Button.Location = new System.Drawing.Point(1033, 718);
            this.room1Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room1Button.Name = "room1Button";
            this.room1Button.Size = new System.Drawing.Size(64, 43);
            this.room1Button.TabIndex = 4;
            this.room1Button.Text = "CAM 01";
            this.room1Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room1Button.UseVisualStyleBackColor = true;
            this.room1Button.Click += new System.EventHandler(this.room1Button_Click);
            // 
            // room2Button
            // 
            this.room2Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room2Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room2Button.Location = new System.Drawing.Point(1291, 650);
            this.room2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room2Button.Name = "room2Button";
            this.room2Button.Size = new System.Drawing.Size(64, 43);
            this.room2Button.TabIndex = 5;
            this.room2Button.Text = "CAM 02";
            this.room2Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room2Button.UseVisualStyleBackColor = true;
            this.room2Button.Click += new System.EventHandler(this.room2Button_Click);
            // 
            // room3Button
            // 
            this.room3Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room3Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room3Button.Location = new System.Drawing.Point(1400, 629);
            this.room3Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room3Button.Name = "room3Button";
            this.room3Button.Size = new System.Drawing.Size(64, 43);
            this.room3Button.TabIndex = 6;
            this.room3Button.Text = "CAM 03";
            this.room3Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room3Button.UseVisualStyleBackColor = true;
            this.room3Button.Click += new System.EventHandler(this.room3Button_Click);
            // 
            // room4Button
            // 
            this.room4Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room4Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room4Button.Location = new System.Drawing.Point(1400, 535);
            this.room4Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room4Button.Name = "room4Button";
            this.room4Button.Size = new System.Drawing.Size(64, 43);
            this.room4Button.TabIndex = 7;
            this.room4Button.Text = "CAM 04";
            this.room4Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room4Button.UseVisualStyleBackColor = true;
            this.room4Button.Click += new System.EventHandler(this.room4Button_Click);
            // 
            // room5Button
            // 
            this.room5Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room5Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room5Button.Location = new System.Drawing.Point(1193, 559);
            this.room5Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room5Button.Name = "room5Button";
            this.room5Button.Size = new System.Drawing.Size(64, 43);
            this.room5Button.TabIndex = 8;
            this.room5Button.Text = "CAM 05";
            this.room5Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room5Button.UseVisualStyleBackColor = true;
            this.room5Button.Click += new System.EventHandler(this.room5Button_Click);
            // 
            // room6Button
            // 
            this.room6Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room6Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room6Button.Location = new System.Drawing.Point(1007, 572);
            this.room6Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room6Button.Name = "room6Button";
            this.room6Button.Size = new System.Drawing.Size(64, 43);
            this.room6Button.TabIndex = 9;
            this.room6Button.Text = "CAM 06";
            this.room6Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room6Button.UseVisualStyleBackColor = true;
            this.room6Button.Click += new System.EventHandler(this.room6Button_Click);
            // 
            // room7Button
            // 
            this.room7Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room7Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room7Button.Location = new System.Drawing.Point(1007, 476);
            this.room7Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room7Button.Name = "room7Button";
            this.room7Button.Size = new System.Drawing.Size(64, 43);
            this.room7Button.TabIndex = 10;
            this.room7Button.Text = "CAM 07";
            this.room7Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room7Button.UseVisualStyleBackColor = true;
            this.room7Button.Click += new System.EventHandler(this.room7Button_Click);
            // 
            // room8Button
            // 
            this.room8Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room8Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room8Button.Location = new System.Drawing.Point(1121, 476);
            this.room8Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room8Button.Name = "room8Button";
            this.room8Button.Size = new System.Drawing.Size(64, 43);
            this.room8Button.TabIndex = 11;
            this.room8Button.Text = "CAM 08";
            this.room8Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room8Button.UseVisualStyleBackColor = true;
            this.room8Button.Click += new System.EventHandler(this.room8Button_Click);
            // 
            // room9Button
            // 
            this.room9Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room9Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room9Button.Location = new System.Drawing.Point(1232, 405);
            this.room9Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room9Button.Name = "room9Button";
            this.room9Button.Size = new System.Drawing.Size(64, 43);
            this.room9Button.TabIndex = 12;
            this.room9Button.Text = "CAM 09";
            this.room9Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room9Button.UseVisualStyleBackColor = true;
            this.room9Button.Click += new System.EventHandler(this.room9Button_Click);
            // 
            // room10Button
            // 
            this.room10Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room10Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room10Button.Location = new System.Drawing.Point(1372, 442);
            this.room10Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room10Button.Name = "room10Button";
            this.room10Button.Size = new System.Drawing.Size(64, 43);
            this.room10Button.TabIndex = 13;
            this.room10Button.Text = "CAM 10";
            this.room10Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room10Button.UseVisualStyleBackColor = true;
            this.room10Button.Click += new System.EventHandler(this.room10Button_Click);
            // 
            // room11Button
            // 
            this.room11Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room11Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room11Button.Location = new System.Drawing.Point(1007, 382);
            this.room11Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room11Button.Name = "room11Button";
            this.room11Button.Size = new System.Drawing.Size(64, 43);
            this.room11Button.TabIndex = 14;
            this.room11Button.Text = "CAM 11";
            this.room11Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room11Button.UseVisualStyleBackColor = true;
            this.room11Button.Click += new System.EventHandler(this.room11Button_Click);
            // 
            // room12Button
            // 
            this.room12Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room12Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room12Button.Location = new System.Drawing.Point(968, 524);
            this.room12Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room12Button.Name = "room12Button";
            this.room12Button.Size = new System.Drawing.Size(64, 43);
            this.room12Button.TabIndex = 15;
            this.room12Button.Text = "CAM 12";
            this.room12Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room12Button.UseVisualStyleBackColor = true;
            this.room12Button.Click += new System.EventHandler(this.room12Button_Click);
            // 
            // room13Button
            // 
            this.room13Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room13Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room13Button.Location = new System.Drawing.Point(1164, 596);
            this.room13Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room13Button.Name = "room13Button";
            this.room13Button.Size = new System.Drawing.Size(64, 43);
            this.room13Button.TabIndex = 16;
            this.room13Button.Text = "CAM 13";
            this.room13Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room13Button.UseVisualStyleBackColor = true;
            this.room13Button.Click += new System.EventHandler(this.room13Button_Click);
            // 
            // room14Button
            // 
            this.room14Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room14Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room14Button.Location = new System.Drawing.Point(1417, 487);
            this.room14Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room14Button.Name = "room14Button";
            this.room14Button.Size = new System.Drawing.Size(64, 43);
            this.room14Button.TabIndex = 17;
            this.room14Button.Text = "CAM 14";
            this.room14Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room14Button.UseVisualStyleBackColor = true;
            this.room14Button.Click += new System.EventHandler(this.room14Button_Click);
            // 
            // room15Button
            // 
            this.room15Button.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room15Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room15Button.Location = new System.Drawing.Point(1291, 698);
            this.room15Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room15Button.Name = "room15Button";
            this.room15Button.Size = new System.Drawing.Size(64, 43);
            this.room15Button.TabIndex = 18;
            this.room15Button.Text = "CAM 15";
            this.room15Button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.room15Button.UseVisualStyleBackColor = true;
            this.room15Button.Click += new System.EventHandler(this.room15Button_Click);
            // 
            // mapToggleButton
            // 
            this.mapToggleButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapToggleButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mapToggleButton.Location = new System.Drawing.Point(877, 679);
            this.mapToggleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mapToggleButton.Name = "mapToggleButton";
            this.mapToggleButton.Size = new System.Drawing.Size(99, 43);
            this.mapToggleButton.TabIndex = 19;
            this.mapToggleButton.Text = "MAP TOGGLE";
            this.mapToggleButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mapToggleButton.UseVisualStyleBackColor = true;
            this.mapToggleButton.Click += new System.EventHandler(this.mapToggelButton_Click);
            // 
            // intervalTimer
            // 
            this.intervalTimer.Enabled = true;
            this.intervalTimer.Interval = 30;
            this.intervalTimer.Tick += new System.EventHandler(this.intervalTimer_Tick);
            // 
            // audioButton
            // 
            this.audioButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.audioButton.Location = new System.Drawing.Point(877, 618);
            this.audioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(99, 43);
            this.audioButton.TabIndex = 20;
            this.audioButton.Text = "PLAY AUDIO";
            this.audioButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.Click += new System.EventHandler(this.audioButton_Click);
            // 
            // panelToggleButton
            // 
            this.panelToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.panelToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.panelToggleButton.FlatAppearance.BorderSize = 3;
            this.panelToggleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.panelToggleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.panelToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panelToggleButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelToggleButton.ForeColor = System.Drawing.Color.Olive;
            this.panelToggleButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.panelToggleButton.Location = new System.Drawing.Point(1417, 23);
            this.panelToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelToggleButton.Name = "panelToggleButton";
            this.panelToggleButton.Size = new System.Drawing.Size(64, 402);
            this.panelToggleButton.TabIndex = 22;
            this.panelToggleButton.Text = "PANEL TOGGLE";
            this.panelToggleButton.UseVisualStyleBackColor = false;
            this.panelToggleButton.Click += new System.EventHandler(this.panelToggleButton_Click);
            // 
            // panelNameLabel
            // 
            this.panelNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.panelNameLabel.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNameLabel.ForeColor = System.Drawing.Color.Olive;
            this.panelNameLabel.Location = new System.Drawing.Point(23, 772);
            this.panelNameLabel.Name = "panelNameLabel";
            this.panelNameLabel.Size = new System.Drawing.Size(737, 89);
            this.panelNameLabel.TabIndex = 23;
            this.panelNameLabel.Text = "Panel Name";
            // 
            // mapPicture
            // 
            this.mapPicture.BackColor = System.Drawing.Color.Transparent;
            this.mapPicture.BackgroundImage = global::ics3uFinalProject.Properties.Resources.gameMap3;
            this.mapPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapPicture.Location = new System.Drawing.Point(877, 363);
            this.mapPicture.Margin = new System.Windows.Forms.Padding(4);
            this.mapPicture.Name = "mapPicture";
            this.mapPicture.Size = new System.Drawing.Size(621, 453);
            this.mapPicture.TabIndex = 21;
            this.mapPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 810);
            this.Controls.Add(this.panelNameLabel);
            this.Controls.Add(this.panelToggleButton);
            this.Controls.Add(this.audioButton);
            this.Controls.Add(this.mapToggleButton);
            this.Controls.Add(this.room15Button);
            this.Controls.Add(this.room14Button);
            this.Controls.Add(this.room13Button);
            this.Controls.Add(this.room12Button);
            this.Controls.Add(this.room11Button);
            this.Controls.Add(this.room10Button);
            this.Controls.Add(this.room9Button);
            this.Controls.Add(this.room8Button);
            this.Controls.Add(this.room7Button);
            this.Controls.Add(this.room6Button);
            this.Controls.Add(this.room5Button);
            this.Controls.Add(this.room4Button);
            this.Controls.Add(this.room3Button);
            this.Controls.Add(this.room2Button);
            this.Controls.Add(this.room1Button);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.audioResetButton);
            this.Controls.Add(this.ventButton);
            this.Controls.Add(this.testOutputLabel);
            this.Controls.Add(this.mapPicture);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "10 Nights at Teddy\'s";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.mapPicture)).EndInit();
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
        private System.Windows.Forms.Button room1Button;
        private System.Windows.Forms.Button room2Button;
        private System.Windows.Forms.Button room3Button;
        private System.Windows.Forms.Button room4Button;
        private System.Windows.Forms.Button room5Button;
        private System.Windows.Forms.Button room6Button;
        private System.Windows.Forms.Button room7Button;
        private System.Windows.Forms.Button room8Button;
        private System.Windows.Forms.Button room9Button;
        private System.Windows.Forms.Button room10Button;
        private System.Windows.Forms.Button room11Button;
        private System.Windows.Forms.Button room12Button;
        private System.Windows.Forms.Button room13Button;
        private System.Windows.Forms.Button room14Button;
        private System.Windows.Forms.Button room15Button;
        private System.Windows.Forms.Button mapToggleButton;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.Button audioButton;
        private System.Windows.Forms.PictureBox mapPicture;
        private System.Windows.Forms.Button panelToggleButton;
        private System.Windows.Forms.Label panelNameLabel;
    }
}

