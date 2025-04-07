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
            continueFromShopButton = new Button();
            amountrolls_label = new Label();
            rollsleft_label = new Label();
            rolldice_button = new Button();
            gamePanel = new Panel();
            moneyLabel = new Label();
            healthLabel = new Label();
            shopPanel = new Panel();
            buyButton = new Button();
            moneyLabelShop = new Label();
            upgradesBox = new ListBox();
            gamePanel.SuspendLayout();
            shopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // continueFromShopButton
            // 
            continueFromShopButton.Location = new Point(174, 231);
            continueFromShopButton.Name = "continueFromShopButton";
            continueFromShopButton.Size = new Size(94, 29);
            continueFromShopButton.TabIndex = 0;
            continueFromShopButton.Text = "Continue";
            continueFromShopButton.UseVisualStyleBackColor = true;
            continueFromShopButton.Click += continueFromShopButton_Click;
            // 
            // amountrolls_label
            // 
            amountrolls_label.AutoSize = true;
            amountrolls_label.Location = new Point(362, 225);
            amountrolls_label.Name = "amountrolls_label";
            amountrolls_label.Size = new Size(17, 20);
            amountrolls_label.TabIndex = 7;
            amountrolls_label.Text = "3";
            // 
            // rollsleft_label
            // 
            rollsleft_label.AutoSize = true;
            rollsleft_label.Location = new Point(290, 225);
            rollsleft_label.Name = "rollsleft_label";
            rollsleft_label.Size = new Size(66, 20);
            rollsleft_label.TabIndex = 6;
            rollsleft_label.Text = "rolls left:";
            // 
            // rolldice_button
            // 
            rolldice_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rolldice_button.Location = new Point(198, 216);
            rolldice_button.Margin = new Padding(3, 4, 3, 4);
            rolldice_button.Name = "rolldice_button";
            rolldice_button.Size = new Size(86, 44);
            rolldice_button.TabIndex = 5;
            rolldice_button.Text = "Roll";
            rolldice_button.UseVisualStyleBackColor = true;
            rolldice_button.Click += rolldice_button_Click;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(moneyLabel);
            gamePanel.Controls.Add(healthLabel);
            gamePanel.Controls.Add(rolldice_button);
            gamePanel.Controls.Add(amountrolls_label);
            gamePanel.Controls.Add(rollsleft_label);
            gamePanel.Location = new Point(12, 12);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(510, 281);
            gamePanel.TabIndex = 9;
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new Point(50, 68);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(57, 20);
            moneyLabel.TabIndex = 10;
            moneyLabel.Text = "Money:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(47, 48);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(60, 20);
            healthLabel.TabIndex = 9;
            healthLabel.Text = "Health: ";
            // 
            // shopPanel
            // 
            shopPanel.Controls.Add(buyButton);
            shopPanel.Controls.Add(moneyLabelShop);
            shopPanel.Controls.Add(upgradesBox);
            shopPanel.Controls.Add(continueFromShopButton);
            shopPanel.Location = new Point(528, 12);
            shopPanel.Name = "shopPanel";
            shopPanel.Size = new Size(452, 281);
            shopPanel.TabIndex = 10;
            shopPanel.Visible = false;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(174, 178);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(94, 29);
            buyButton.TabIndex = 12;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // moneyLabelShop
            // 
            moneyLabelShop.AutoSize = true;
            moneyLabelShop.Location = new Point(15, 15);
            moneyLabelShop.Name = "moneyLabelShop";
            moneyLabelShop.Size = new Size(57, 20);
            moneyLabelShop.TabIndex = 11;
            moneyLabelShop.Text = "Money:";
            // 
            // upgradesBox
            // 
            upgradesBox.DisplayMember = "description";
            upgradesBox.FormattingEnabled = true;
            upgradesBox.Location = new Point(35, 68);
            upgradesBox.Name = "upgradesBox";
            upgradesBox.Size = new Size(378, 104);
            upgradesBox.TabIndex = 1;
            upgradesBox.ValueMember = "name";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 391);
            Controls.Add(shopPanel);
            Controls.Add(gamePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Game";
            Text = "game";
            Load += Game_Load;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            shopPanel.ResumeLayout(false);
            shopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button continueFromShopButton;
        private Label amountrolls_label;
        private Label rollsleft_label;
        private Button rolldice_button;
        private Panel gamePanel;
        private Panel shopPanel;
        private Label moneyLabel;
        private Label healthLabel;
        private Label moneyLabelShop;
        private ListBox upgradesBox;
        private Button buyButton;
    }
}