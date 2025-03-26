namespace Dice_or_Die
{
    partial class Game
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
            rolldice_button = new Button();
            rollsleft_label = new Label();
            amountrolls_label = new Label();
            SuspendLayout();
            // 
            // rolldice_button
            // 
            rolldice_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rolldice_button.Location = new Point(337, 337);
            rolldice_button.Margin = new Padding(3, 4, 3, 4);
            rolldice_button.Name = "rolldice_button";
            rolldice_button.Size = new Size(86, 44);
            rolldice_button.TabIndex = 5;
            rolldice_button.Text = "Roll";
            rolldice_button.UseVisualStyleBackColor = true;
            rolldice_button.Click += rolldice_button_Click;
            // 
            // rollsleft_label
            // 
            rollsleft_label.AutoSize = true;
            rollsleft_label.Location = new Point(435, 352);
            rollsleft_label.Name = "rollsleft_label";
            rollsleft_label.Size = new Size(66, 20);
            rollsleft_label.TabIndex = 6;
            rollsleft_label.Text = "rolls left:";
            // 
            // amountrolls_label
            // 
            amountrolls_label.AutoSize = true;
            amountrolls_label.Location = new Point(502, 352);
            amountrolls_label.Name = "amountrolls_label";
            amountrolls_label.Size = new Size(17, 20);
            amountrolls_label.TabIndex = 7;
            amountrolls_label.Text = "3";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 391);
            Controls.Add(amountrolls_label);
            Controls.Add(rollsleft_label);
            Controls.Add(rolldice_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Game";
            Text = "game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button rolldice_button;
        private Label rollsleft_label;
        private Label amountrolls_label;
    }
}