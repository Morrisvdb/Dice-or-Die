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
            die1 = new Button();
            die2 = new Button();
            die3 = new Button();
            die4 = new Button();
            die5 = new Button();
            rolldice_button = new Button();
            rollsleft_label = new Label();
            amountrolls_label = new Label();
            SuspendLayout();
            // 
            // die1
            // 
            die1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            die1.Location = new Point(133, 159);
            die1.Name = "die1";
            die1.Size = new Size(75, 75);
            die1.TabIndex = 0;
            die1.Text = "button1";
            die1.UseVisualStyleBackColor = true;
            die1.Visible = false;
            // 
            // die2
            // 
            die2.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            die2.Location = new Point(214, 159);
            die2.Name = "die2";
            die2.Size = new Size(75, 75);
            die2.TabIndex = 1;
            die2.Text = "button2";
            die2.UseVisualStyleBackColor = true;
            die2.Visible = false;
            // 
            // die3
            // 
            die3.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            die3.Location = new Point(295, 159);
            die3.Name = "die3";
            die3.Size = new Size(75, 75);
            die3.TabIndex = 2;
            die3.Text = "button3";
            die3.UseVisualStyleBackColor = true;
            die3.Visible = false;
            // 
            // die4
            // 
            die4.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            die4.Location = new Point(376, 159);
            die4.Name = "die4";
            die4.Size = new Size(75, 75);
            die4.TabIndex = 3;
            die4.Text = "button4";
            die4.UseVisualStyleBackColor = true;
            die4.Visible = false;
            // 
            // die5
            // 
            die5.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            die5.Location = new Point(457, 159);
            die5.Name = "die5";
            die5.Size = new Size(75, 75);
            die5.TabIndex = 4;
            die5.Text = "button5";
            die5.UseVisualStyleBackColor = true;
            die5.Visible = false;
            // 
            // rolldice_button
            // 
            rolldice_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rolldice_button.Location = new Point(295, 253);
            rolldice_button.Name = "rolldice_button";
            rolldice_button.Size = new Size(75, 33);
            rolldice_button.TabIndex = 5;
            rolldice_button.Text = "Roll";
            rolldice_button.UseVisualStyleBackColor = true;
            // 
            // rollsleft_label
            // 
            rollsleft_label.AutoSize = true;
            rollsleft_label.Location = new Point(381, 264);
            rollsleft_label.Name = "rollsleft_label";
            rollsleft_label.Size = new Size(52, 15);
            rollsleft_label.TabIndex = 6;
            rollsleft_label.Text = "rolls left:";
            // 
            // amountrolls_label
            // 
            amountrolls_label.AutoSize = true;
            amountrolls_label.Location = new Point(439, 264);
            amountrolls_label.Name = "amountrolls_label";
            amountrolls_label.Size = new Size(13, 15);
            amountrolls_label.TabIndex = 7;
            amountrolls_label.Text = "3";
            // 
            // game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 293);
            Controls.Add(amountrolls_label);
            Controls.Add(rollsleft_label);
            Controls.Add(rolldice_button);
            Controls.Add(die5);
            Controls.Add(die4);
            Controls.Add(die3);
            Controls.Add(die2);
            Controls.Add(die1);
            Name = "game";
            Text = "game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button die1;
        private Button die2;
        private Button die3;
        private Button die4;
        private Button die5;
        private Button rolldice_button;
        private Label rollsleft_label;
        private Label amountrolls_label;
    }
}