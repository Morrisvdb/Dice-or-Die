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
            ((System.ComponentModel.ISupportInitialize)musicPlayer).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.BackColor = SystemColors.HighlightText;
            playButton.Location = new Point(341, 207);
            playButton.Name = "playButton";
            playButton.Size = new Size(94, 29);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.HighlightText;
            helpButton.Location = new Point(341, 312);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(94, 29);
            helpButton.TabIndex = 1;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = SystemColors.HighlightText;
            quitButton.Location = new Point(341, 347);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = SystemColors.HighlightText;
            settingsButton.Location = new Point(341, 243);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // resetGameButton
            // 
            resetGameButton.BackColor = SystemColors.HighlightText;
            resetGameButton.Location = new Point(341, 277);
            resetGameButton.Name = "resetGameButton";
            resetGameButton.Size = new Size(94, 29);
            resetGameButton.TabIndex = 4;
            resetGameButton.Text = "Reset";
            resetGameButton.UseVisualStyleBackColor = false;
            resetGameButton.Click += resetGameButton_Click;
            // 
            // musicPlayer
            // 
            musicPlayer.Enabled = true;
            musicPlayer.Location = new Point(63, 397);
            musicPlayer.Name = "musicPlayer";
            musicPlayer.OcxState = (AxHost.State)resources.GetObject("musicPlayer.OcxState");
            musicPlayer.Size = new Size(75, 23);
            musicPlayer.TabIndex = 5;
            musicPlayer.Visible = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            BackgroundImage = Resource1.backgroundimage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 532);
            Controls.Add(musicPlayer);
            Controls.Add(resetGameButton);
            Controls.Add(settingsButton);
            Controls.Add(quitButton);
            Controls.Add(helpButton);
            Controls.Add(playButton);
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)musicPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button helpButton;
        private Button quitButton;
        private Button settingsButton;
        private Button resetGameButton;
        public AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private Button playButton;
    }
}
