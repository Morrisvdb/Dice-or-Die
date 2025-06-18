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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            Title_label = new Label();
            GoBack = new Button();
            explanation_label = new Label();
            next_button = new Button();
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
            // GoBack
            // 
            GoBack.Location = new Point(4, 4);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(75, 23);
            GoBack.TabIndex = 1;
            GoBack.Text = "Back";
            GoBack.UseVisualStyleBackColor = true;
            // 
            // explanation_label
            // 
            explanation_label.AutoSize = true;
            explanation_label.Location = new Point(182, 81);
            explanation_label.Name = "explanation_label";
            explanation_label.Size = new Size(259, 225);
            explanation_label.TabIndex = 2;
            explanation_label.Text = resources.GetString("explanation_label.Text");
            // 
            // next_button
            // 
            next_button.Location = new Point(422, 292);
            next_button.Name = "next_button";
            next_button.Size = new Size(75, 23);
            next_button.TabIndex = 3;
            next_button.Text = "Next";
            next_button.UseVisualStyleBackColor = true;
            next_button.Click += next_button_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(next_button);
            Controls.Add(explanation_label);
            Controls.Add(GoBack);
            Controls.Add(Title_label);
            Name = "Help";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_label;
        private Button GoBack;
        private Label explanation_label;
        private Button next_button;
    }
}