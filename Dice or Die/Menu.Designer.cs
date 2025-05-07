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
            playButton = new Button();
            helpButton = new Button();
            quitButton = new Button();
            settingsButton = new Button();
            resetGameButton = new Button();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Location = new Point(353, 90);
            playButton.Name = "playButton";
            playButton.Size = new Size(94, 29);
            playButton.TabIndex = 0;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(353, 195);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(94, 29);
            helpButton.TabIndex = 1;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // quitButton
            // 
            quitButton.Location = new Point(353, 230);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(94, 29);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(353, 125);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 3;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // resetGameButton
            // 
            resetGameButton.Location = new Point(353, 160);
            resetGameButton.Name = "resetGameButton";
            resetGameButton.Size = new Size(94, 29);
            resetGameButton.TabIndex = 4;
            resetGameButton.Text = "Reset";
            resetGameButton.UseVisualStyleBackColor = true;
            resetGameButton.Click += resetGameButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetGameButton);
            Controls.Add(settingsButton);
            Controls.Add(quitButton);
            Controls.Add(helpButton);
            Controls.Add(playButton);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Button helpButton;
        private Button quitButton;
        private Button settingsButton;
        private Button resetGameButton;
    }
}
