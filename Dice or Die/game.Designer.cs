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
            rolldice_button = new Button();
            gamePanel = new Panel();
            diceLabel = new Label();
            currentPlayerLabel = new Label();
            moneyLabel = new Label();
            healthLabel = new Label();
            shopPanel = new Panel();
            currentPlayerLabelShop = new Label();
            buyButton = new Button();
            moneyLabelShop = new Label();
            upgradesBox = new ListBox();
            returnToMenuButton = new Button();
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
            gamePanel.Controls.Add(diceLabel);
            gamePanel.Controls.Add(currentPlayerLabel);
            gamePanel.Controls.Add(moneyLabel);
            gamePanel.Controls.Add(healthLabel);
            gamePanel.Controls.Add(rolldice_button);
            gamePanel.Controls.Add(amountrolls_label);
            gamePanel.Location = new Point(12, 27);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(510, 281);
            gamePanel.TabIndex = 9;
            // 
            // diceLabel
            // 
            diceLabel.AutoSize = true;
            diceLabel.Location = new Point(120, 120);
            diceLabel.Name = "diceLabel";
            diceLabel.Size = new Size(138, 20);
            diceLabel.TabIndex = 12;
            diceLabel.Text = "hidden for dice pos";
            diceLabel.Visible = false;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Font = new Font("Segoe UI", 15F);
            currentPlayerLabel.Location = new Point(159, 3);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(183, 35);
            currentPlayerLabel.TabIndex = 11;
            currentPlayerLabel.Text = "Current Player: ";
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
            shopPanel.Controls.Add(currentPlayerLabelShop);
            shopPanel.Controls.Add(buyButton);
            shopPanel.Controls.Add(moneyLabelShop);
            shopPanel.Controls.Add(upgradesBox);
            shopPanel.Controls.Add(continueFromShopButton);
            shopPanel.Location = new Point(528, 27);
            shopPanel.Name = "shopPanel";
            shopPanel.Size = new Size(452, 281);
            shopPanel.TabIndex = 10;
            shopPanel.Visible = false;
            // 
            // currentPlayerLabelShop
            // 
            currentPlayerLabelShop.AutoSize = true;
            currentPlayerLabelShop.Font = new Font("Segoe UI", 15F);
            currentPlayerLabelShop.Location = new Point(139, 3);
            currentPlayerLabelShop.Name = "currentPlayerLabelShop";
            currentPlayerLabelShop.Size = new Size(183, 35);
            currentPlayerLabelShop.TabIndex = 12;
            currentPlayerLabelShop.Text = "Current Player: ";
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
            // returnToMenuButton
            // 
            returnToMenuButton.Location = new Point(12, 3);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(94, 29);
            returnToMenuButton.TabIndex = 11;
            returnToMenuButton.Text = "Menu";
            returnToMenuButton.UseVisualStyleBackColor = true;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 391);
            Controls.Add(returnToMenuButton);
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
        private Button rolldice_button;
        private Panel gamePanel;
        private Panel shopPanel;
        private Label moneyLabel;
        private Label healthLabel;
        private Label moneyLabelShop;
        private ListBox upgradesBox;
        private Button buyButton;
        private Label currentPlayerLabel;
        private Label currentPlayerLabelShop;
        private Label diceLabel;
        private Button returnToMenuButton;
    }
}