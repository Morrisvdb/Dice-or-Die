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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            continueFromShopButton = new Button();
            amountrolls_label = new Label();
            rolldice_button = new Button();
            gamePanel = new Panel();
            healthBar = new ProgressBar();
            attackLabel = new Label();
            incomingDamageLabel = new Label();
            switchSectionTick = new CheckBox();
            payoutLabel = new Label();
            useDiceButton = new Button();
            rollBox = new ListBox();
            diceLabel = new Label();
            currentPlayerLabel = new Label();
            moneyLabel = new Label();
            healthLabel = new Label();
            shopPanel = new Panel();
            healthBarShop = new ProgressBar();
            upgradeRollButton = new Button();
            rollsUpgradeBox = new ListBox();
            incomingDamageLabelShop = new Label();
            attackLabelShop = new Label();
            healthLabelShop = new Label();
            currentPlayerLabelShop = new Label();
            buyButton = new Button();
            moneyLabelShop = new Label();
            upgradesBox = new ListBox();
            returnToMenuButton = new Button();
            rollTimer = new System.Windows.Forms.Timer(components);
            rollSoundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            gamePanel.SuspendLayout();
            shopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rollSoundPlayer).BeginInit();
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
            amountrolls_label.Location = new Point(362, 297);
            amountrolls_label.Name = "amountrolls_label";
            amountrolls_label.Size = new Size(17, 20);
            amountrolls_label.TabIndex = 7;
            amountrolls_label.Text = "3";
            // 
            // rolldice_button
            // 
            rolldice_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rolldice_button.Location = new Point(198, 288);
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
            gamePanel.Controls.Add(rollSoundPlayer);
            gamePanel.Controls.Add(healthBar);
            gamePanel.Controls.Add(attackLabel);
            gamePanel.Controls.Add(incomingDamageLabel);
            gamePanel.Controls.Add(switchSectionTick);
            gamePanel.Controls.Add(payoutLabel);
            gamePanel.Controls.Add(useDiceButton);
            gamePanel.Controls.Add(rollBox);
            gamePanel.Controls.Add(diceLabel);
            gamePanel.Controls.Add(currentPlayerLabel);
            gamePanel.Controls.Add(moneyLabel);
            gamePanel.Controls.Add(healthLabel);
            gamePanel.Controls.Add(rolldice_button);
            gamePanel.Controls.Add(amountrolls_label);
            gamePanel.Location = new Point(12, 27);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(510, 352);
            gamePanel.TabIndex = 9;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(142, 35);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(125, 20);
            healthBar.TabIndex = 19;
            // 
            // attackLabel
            // 
            attackLabel.AutoSize = true;
            attackLabel.Location = new Point(348, 35);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new Size(58, 20);
            attackLabel.TabIndex = 18;
            attackLabel.Text = "Attack: ";
            // 
            // incomingDamageLabel
            // 
            incomingDamageLabel.AutoSize = true;
            incomingDamageLabel.Location = new Point(76, 78);
            incomingDamageLabel.Name = "incomingDamageLabel";
            incomingDamageLabel.Size = new Size(132, 20);
            incomingDamageLabel.TabIndex = 17;
            incomingDamageLabel.Text = "Incoming Damage";
            // 
            // switchSectionTick
            // 
            switchSectionTick.AutoSize = true;
            switchSectionTick.Location = new Point(76, 310);
            switchSectionTick.Name = "switchSectionTick";
            switchSectionTick.Size = new Size(18, 17);
            switchSectionTick.TabIndex = 16;
            switchSectionTick.UseVisualStyleBackColor = true;
            switchSectionTick.CheckedChanged += switchSectionTick_CheckedChanged;
            // 
            // payoutLabel
            // 
            payoutLabel.AutoSize = true;
            payoutLabel.Location = new Point(198, 234);
            payoutLabel.Name = "payoutLabel";
            payoutLabel.Size = new Size(67, 20);
            payoutLabel.TabIndex = 15;
            payoutLabel.Text = "Payout: x";
            payoutLabel.Visible = false;
            // 
            // useDiceButton
            // 
            useDiceButton.Location = new Point(3, 303);
            useDiceButton.Name = "useDiceButton";
            useDiceButton.Size = new Size(60, 29);
            useDiceButton.TabIndex = 14;
            useDiceButton.Text = "Cast";
            useDiceButton.UseVisualStyleBackColor = true;
            useDiceButton.Click += useDiceButton_Click;
            // 
            // rollBox
            // 
            rollBox.DisplayMember = "title";
            rollBox.FormattingEnabled = true;
            rollBox.Location = new Point(3, 175);
            rollBox.Name = "rollBox";
            rollBox.Size = new Size(104, 124);
            rollBox.TabIndex = 13;
            // 
            // diceLabel
            // 
            diceLabel.AutoSize = true;
            diceLabel.Location = new Point(159, 162);
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
            moneyLabel.Location = new Point(76, 55);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(57, 20);
            moneyLabel.TabIndex = 10;
            moneyLabel.Text = "Money:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(76, 35);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(60, 20);
            healthLabel.TabIndex = 9;
            healthLabel.Text = "Health: ";
            // 
            // shopPanel
            // 
            shopPanel.Controls.Add(healthBarShop);
            shopPanel.Controls.Add(upgradeRollButton);
            shopPanel.Controls.Add(rollsUpgradeBox);
            shopPanel.Controls.Add(incomingDamageLabelShop);
            shopPanel.Controls.Add(attackLabelShop);
            shopPanel.Controls.Add(healthLabelShop);
            shopPanel.Controls.Add(currentPlayerLabelShop);
            shopPanel.Controls.Add(buyButton);
            shopPanel.Controls.Add(moneyLabelShop);
            shopPanel.Controls.Add(upgradesBox);
            shopPanel.Controls.Add(continueFromShopButton);
            shopPanel.Location = new Point(528, 27);
            shopPanel.Name = "shopPanel";
            shopPanel.Size = new Size(498, 281);
            shopPanel.TabIndex = 10;
            shopPanel.Visible = false;
            // 
            // healthBarShop
            // 
            healthBarShop.Location = new Point(81, 35);
            healthBarShop.Name = "healthBarShop";
            healthBarShop.Size = new Size(125, 20);
            healthBarShop.TabIndex = 20;
            // 
            // upgradeRollButton
            // 
            upgradeRollButton.Location = new Point(379, 188);
            upgradeRollButton.Name = "upgradeRollButton";
            upgradeRollButton.Size = new Size(94, 29);
            upgradeRollButton.TabIndex = 19;
            upgradeRollButton.Text = "Buy";
            upgradeRollButton.UseVisualStyleBackColor = true;
            upgradeRollButton.Click += upgradeRollButton_Click;
            // 
            // rollsUpgradeBox
            // 
            rollsUpgradeBox.DisplayMember = "title";
            rollsUpgradeBox.FormattingEnabled = true;
            rollsUpgradeBox.Location = new Point(359, 78);
            rollsUpgradeBox.Name = "rollsUpgradeBox";
            rollsUpgradeBox.Size = new Size(136, 104);
            rollsUpgradeBox.TabIndex = 18;
            // 
            // incomingDamageLabelShop
            // 
            incomingDamageLabelShop.AutoSize = true;
            incomingDamageLabelShop.Location = new Point(15, 55);
            incomingDamageLabelShop.Name = "incomingDamageLabelShop";
            incomingDamageLabelShop.Size = new Size(139, 20);
            incomingDamageLabelShop.TabIndex = 17;
            incomingDamageLabelShop.Text = "Incoming Damage: ";
            // 
            // attackLabelShop
            // 
            attackLabelShop.AutoSize = true;
            attackLabelShop.Location = new Point(328, 35);
            attackLabelShop.Name = "attackLabelShop";
            attackLabelShop.Size = new Size(58, 20);
            attackLabelShop.TabIndex = 14;
            attackLabelShop.Text = "Attack: ";
            // 
            // healthLabelShop
            // 
            healthLabelShop.AutoSize = true;
            healthLabelShop.Location = new Point(15, 35);
            healthLabelShop.Name = "healthLabelShop";
            healthLabelShop.Size = new Size(60, 20);
            healthLabelShop.TabIndex = 13;
            healthLabelShop.Text = "Health: ";
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
            buyButton.Location = new Point(174, 188);
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
            upgradesBox.Location = new Point(35, 78);
            upgradesBox.Name = "upgradesBox";
            upgradesBox.Size = new Size(318, 104);
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
            // rollTimer
            // 
            rollTimer.Interval = 20;
            rollTimer.Tick += rollTimer_Tick;
            // 
            // rollSoundPlayer
            // 
            rollSoundPlayer.Enabled = true;
            rollSoundPlayer.Location = new Point(176, 262);
            rollSoundPlayer.Name = "rollSoundPlayer";
            rollSoundPlayer.OcxState = (AxHost.State)resources.GetObject("rollSoundPlayer.OcxState");
            rollSoundPlayer.Size = new Size(75, 23);
            rollSoundPlayer.TabIndex = 20;
            rollSoundPlayer.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)rollSoundPlayer).EndInit();
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

        private ListBox rollBox;
        private Button useDiceButton;
        private Label healthLabelShop;
        private Label attackLabelShop;
        private Label payoutLabel;
        private CheckBox switchSectionTick;
        private Label incomingDamageLabelShop;
        private Label incomingDamageLabel;
        private Label attackLabel;
        private PictureBox pictureBox1;
        private ListBox rollsUpgradeBox;
        private Button upgradeRollButton;
        private ProgressBar healthBar;
        private ProgressBar healthBarShop;
        private System.Windows.Forms.Timer rollTimer;
        private AxWMPLib.AxWindowsMediaPlayer rollSoundPlayer;
    }
}