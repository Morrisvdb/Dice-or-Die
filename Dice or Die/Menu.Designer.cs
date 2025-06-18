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
            ((System.ComponentModel.ISupportInitialize)musicPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(351, 166);
            playButton.Name = "playButton";
            playButton.Size = new Size(94, 29);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(351, 271);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(94, 29);
            helpButton.TabIndex = 1;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(351, 306);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(351, 201);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // resetGameButton
            // 
            resetGameButton.Location = new Point(351, 236);
            resetGameButton.Name = "resetGameButton";
            resetGameButton.Size = new Size(94, 29);
            resetGameButton.TabIndex = 4;
            resetGameButton.Text = "Reset";
            resetGameButton.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 148);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(musicPlayer);
            Controls.Add(resetGameButton);
            Controls.Add(settingsButton);
            Controls.Add(quitButton);
            Controls.Add(helpButton);
            Controls.Add(playButton);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)musicPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Button helpButton;
        private Button quitButton;
        private Button settingsButton;
        private Button resetGameButton;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private PictureBox pictureBox1;
    }
}
