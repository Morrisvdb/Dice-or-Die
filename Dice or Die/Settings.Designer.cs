namespace Dice_or_Die
{
    partial class Settings
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
            music_bar = new TrackBar();
            sound_effects_bar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            music_sound_button = new Button();
            effect_sound_button = new Button();
            menu_button = new Button();
            updateSoundButton = new Button();
            ((System.ComponentModel.ISupportInitialize)music_bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sound_effects_bar).BeginInit();
            SuspendLayout();
            // 
            // music_bar
            // 
            music_bar.Location = new Point(339, 113);
            music_bar.Maximum = 100;
            music_bar.Name = "music_bar";
            music_bar.Size = new Size(223, 45);
            music_bar.TabIndex = 0;
            music_bar.Value = 100;
            music_bar.Scroll += music_bar_Scroll;
            // 
            // sound_effects_bar
            // 
            sound_effects_bar.Location = new Point(339, 164);
            sound_effects_bar.Maximum = 100;
            sound_effects_bar.Name = "sound_effects_bar";
            sound_effects_bar.Size = new Size(223, 45);
            sound_effects_bar.TabIndex = 1;
            sound_effects_bar.Value = 100;
            sound_effects_bar.Scroll += sound_effects_bar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 124);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Music";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 174);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Sound effects";
            // 
            // music_sound_button
            // 
            music_sound_button.Location = new Point(592, 116);
            music_sound_button.Name = "music_sound_button";
            music_sound_button.Size = new Size(75, 23);
            music_sound_button.TabIndex = 4;
            music_sound_button.Text = "Sound: on";
            music_sound_button.UseVisualStyleBackColor = true;
            music_sound_button.Click += music_sound_button_Click;
            // 
            // effect_sound_button
            // 
            effect_sound_button.Location = new Point(592, 170);
            effect_sound_button.Name = "effect_sound_button";
            effect_sound_button.Size = new Size(75, 23);
            effect_sound_button.TabIndex = 5;
            effect_sound_button.Text = "Sound: on";
            effect_sound_button.UseVisualStyleBackColor = true;
            effect_sound_button.Click += effect_sound_button_Click;
            // 
            // menu_button
            // 
            menu_button.Location = new Point(12, 12);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(75, 23);
            menu_button.TabIndex = 6;
            menu_button.Text = "Menu";
            menu_button.UseVisualStyleBackColor = true;
            menu_button.Click += menu_button_Click;
            // 
            // updateSoundButton
            // 
            updateSoundButton.Location = new Point(592, 264);
            updateSoundButton.Name = "updateSoundButton";
            updateSoundButton.Size = new Size(75, 23);
            updateSoundButton.TabIndex = 7;
            updateSoundButton.Text = "Save";
            updateSoundButton.UseVisualStyleBackColor = true;
            updateSoundButton.Click += updateSoundButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 317);
            Controls.Add(updateSoundButton);
            Controls.Add(menu_button);
            Controls.Add(effect_sound_button);
            Controls.Add(music_sound_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sound_effects_bar);
            Controls.Add(music_bar);
            Name = "Settings";
            Text = "Settings";
            FormClosed += Settings_FormClosed;
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)music_bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sound_effects_bar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar music_bar;
        private TrackBar sound_effects_bar;
        private Label label1;
        private Label label2;
        private Button music_sound_button;
        private Button effect_sound_button;
        private Button menu_button;
        private Button updateSoundButton;
    }
}