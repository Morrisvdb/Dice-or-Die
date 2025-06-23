namespace Dice_or_Die
{
    partial class Help
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
            Title_label = new Label();
            Menu_button = new Button();
            explanation_label = new Label();
            next_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // Title_label
            // 
            Title_label.AutoSize = true;
            Title_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_label.Location = new Point(182, 35);
            Title_label.Name = "Title_label";
            Title_label.Size = new Size(101, 30);
            Title_label.TabIndex = 0;
            Title_label.Text = "Contents";
            // 
            // Menu_button
            // 
            Menu_button.Location = new Point(4, 4);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(75, 23);
            Menu_button.TabIndex = 1;
            Menu_button.Text = "Menu";
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // explanation_label
            // 
            explanation_label.AutoSize = true;
            explanation_label.Location = new Point(182, 81);
            explanation_label.Name = "explanation_label";
            explanation_label.Size = new Size(127, 75);
            explanation_label.TabIndex = 2;
            explanation_label.Text = "1.  Gameplay Overview\r\n2.  Rules\r\n3.  Upper Section\r\n4.  Lower Section\r\n5.  Shop";
            // 
            // next_button
            // 
            next_button.Location = new Point(431, 308);
            next_button.Name = "next_button";
            next_button.Size = new Size(75, 23);
            next_button.TabIndex = 3;
            next_button.Text = "Next";
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(83, 308);
            back_button.Name = "back_button";
            back_button.Size = new Size(75, 23);
            back_button.TabIndex = 4;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(back_button);
            Controls.Add(next_button);
            Controls.Add(explanation_label);
            Controls.Add(Menu_button);
            Controls.Add(Title_label);
            Name = "Help";
            Text = "Help";
            Load += Help_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_label;
        private Button Menu_button;
        private Label explanation_label;
        private Button next_button;
        private Button back_button;
    }
}