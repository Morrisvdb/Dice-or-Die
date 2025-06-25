namespace Dice_or_Die
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            playButton = new Button();
            helpButton = new Button();
            quitButton = new Button();
            settingsButton = new Button();
            resetGameButton = new Button();
            musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)musicPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.BackColor = SystemColors.HighlightText;
            playButton.Location = new Point(298, 155);
            playButton.Margin = new Padding(3, 2, 3, 2);
            playButton.Name = "playButton";
            playButton.Size = new Size(82, 22);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.HighlightText;
            helpButton.Location = new Point(298, 234);
            helpButton.Margin = new Padding(3, 2, 3, 2);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(82, 22);
            helpButton.TabIndex = 1;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = SystemColors.HighlightText;
            quitButton.Location = new Point(298, 260);
            quitButton.Margin = new Padding(3, 2, 3, 2);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(82, 22);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = SystemColors.HighlightText;
            settingsButton.Location = new Point(298, 182);
            settingsButton.Margin = new Padding(3, 2, 3, 2);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(82, 22);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // resetGameButton
            // 
            resetGameButton.BackColor = SystemColors.HighlightText;
            resetGameButton.Location = new Point(298, 208);
            resetGameButton.Margin = new Padding(3, 2, 3, 2);
            resetGameButton.Name = "resetGameButton";
            resetGameButton.Size = new Size(82, 22);
            resetGameButton.TabIndex = 4;
            resetGameButton.Text = "Reset";
            resetGameButton.UseVisualStyleBackColor = false;
            resetGameButton.Click += resetGameButton_Click;
            // 
            // musicPlayer
            // 
            musicPlayer.Enabled = true;
            musicPlayer.Location = new Point(63, 397);
            musicPlayer.Margin = new Padding(3, 2, 3, 2);
            musicPlayer.Name = "musicPlayer";
            musicPlayer.OcxState = (AxHost.State)resources.GetObject("musicPlayer.OcxState");
            musicPlayer.Size = new Size(75, 23);
            musicPlayer.TabIndex = 5;
            musicPlayer.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.Image;
            pictureBox1.Location = new Point(163, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.player1_icon;
            pictureBox2.Location = new Point(24, 78);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(496, 262);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 46);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(musicPlayer);
            Controls.Add(resetGameButton);
            Controls.Add(settingsButton);
            Controls.Add(quitButton);
            Controls.Add(helpButton);
            Controls.Add(playButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)musicPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Button helpButton;
        private Button quitButton;
        private Button settingsButton;
        private Button resetGameButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        public AxWMPLib.AxWindowsMediaPlayer musicPlayer;
    }
}
