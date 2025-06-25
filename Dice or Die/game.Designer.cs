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
            spellDetailLabel = new Label();
            victorySoundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            currentPlayerPicture = new PictureBox();
            rollSoundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
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
            incomingDamageLabelShop = new Label();
            attackLabelShop = new Label();
            healthLabelShop = new Label();
            currentPlayerLabelShop = new Label();
            buyButton = new Button();
            moneyLabelShop = new Label();
            upgradesBox = new ListBox();
            returnToMenuButton = new Button();
            rollTimer = new System.Windows.Forms.Timer(components);
            rollsUpgradeBox = new ListBox();
            gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)victorySoundPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentPlayerPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rollSoundPlayer).BeginInit();
            shopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // continueFromShopButton
            // 
            continueFromShopButton.Location = new Point(152, 173);
            continueFromShopButton.Margin = new Padding(3, 2, 3, 2);
            continueFromShopButton.Name = "continueFromShopButton";
            continueFromShopButton.Size = new Size(82, 22);
            continueFromShopButton.TabIndex = 0;
            continueFromShopButton.Text = "Continue";
            continueFromShopButton.UseVisualStyleBackColor = true;
            continueFromShopButton.Click += continueFromShopButton_Click;
            // 
            // amountrolls_label
            // 
            amountrolls_label.AutoSize = true;
            amountrolls_label.Location = new Point(375, 223);
            amountrolls_label.Name = "amountrolls_label";
            amountrolls_label.Size = new Size(13, 15);
            amountrolls_label.TabIndex = 7;
            amountrolls_label.Text = "3";
            // 
            // rolldice_button
            // 
            rolldice_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rolldice_button.Location = new Point(232, 216);
            rolldice_button.Name = "rolldice_button";
            rolldice_button.Size = new Size(75, 33);
            rolldice_button.TabIndex = 5;
            rolldice_button.Text = "Roll";
            rolldice_button.UseVisualStyleBackColor = true;
            rolldice_button.Click += rolldice_button_Click;
            // 
            // gamePanel
            // 
            gamePanel.Controls.Add(spellDetailLabel);
            gamePanel.Controls.Add(victorySoundPlayer);
            gamePanel.Controls.Add(currentPlayerPicture);
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
            gamePanel.Location = new Point(10, 20);
            gamePanel.Margin = new Padding(3, 2, 3, 2);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(620, 264);
            gamePanel.TabIndex = 9;
            // 
            // spellDetailLabel
            // 
            spellDetailLabel.Location = new Point(5, 15);
            spellDetailLabel.Name = "spellDetailLabel";
            spellDetailLabel.Size = new Size(104, 100);
            spellDetailLabel.TabIndex = 24;
            spellDetailLabel.Text = "Select a roll to see its details.";
            spellDetailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // victorySoundPlayer
            // 
            victorySoundPlayer.Enabled = true;
            victorySoundPlayer.Location = new Point(243, 262);
            victorySoundPlayer.Margin = new Padding(3, 2, 3, 2);
            victorySoundPlayer.Name = "victorySoundPlayer";
            victorySoundPlayer.OcxState = (AxHost.State)resources.GetObject("victorySoundPlayer.OcxState");
            victorySoundPlayer.Size = new Size(75, 23);
            victorySoundPlayer.TabIndex = 22;
            victorySoundPlayer.Visible = false;
            // 
            // currentPlayerPicture
            // 
            currentPlayerPicture.Location = new Point(442, 11);
            currentPlayerPicture.Margin = new Padding(3, 2, 3, 2);
            currentPlayerPicture.Name = "currentPlayerPicture";
            currentPlayerPicture.Size = new Size(175, 150);
            currentPlayerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            currentPlayerPicture.TabIndex = 21;
            currentPlayerPicture.TabStop = false;
            // 
            // rollSoundPlayer
            // 
            rollSoundPlayer.Enabled = true;
            rollSoundPlayer.Location = new Point(243, 262);
            rollSoundPlayer.Margin = new Padding(3, 2, 3, 2);
            rollSoundPlayer.Name = "rollSoundPlayer";
            rollSoundPlayer.OcxState = (AxHost.State)resources.GetObject("rollSoundPlayer.OcxState");
            rollSoundPlayer.Size = new Size(75, 23);
            rollSoundPlayer.TabIndex = 20;
            rollSoundPlayer.Visible = false;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(183, 26);
            healthBar.Margin = new Padding(3, 2, 3, 2);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(109, 15);
            healthBar.TabIndex = 19;
            // 
            // attackLabel
            // 
            attackLabel.AutoSize = true;
            attackLabel.Location = new Point(340, 26);
            attackLabel.Name = "attackLabel";
            attackLabel.Size = new Size(47, 15);
            attackLabel.TabIndex = 18;
            attackLabel.Text = "Attack: ";
            // 
            // incomingDamageLabel
            // 
            incomingDamageLabel.AutoSize = true;
            incomingDamageLabel.Location = new Point(125, 58);
            incomingDamageLabel.Name = "incomingDamageLabel";
            incomingDamageLabel.Size = new Size(105, 15);
            incomingDamageLabel.TabIndex = 17;
            incomingDamageLabel.Text = "Incoming Damage";
            // 
            // switchSectionTick
            // 
            switchSectionTick.AutoSize = true;
            switchSectionTick.Location = new Point(88, 219);
            switchSectionTick.Margin = new Padding(3, 2, 3, 2);
            switchSectionTick.Name = "switchSectionTick";
            switchSectionTick.Size = new Size(15, 14);
            switchSectionTick.TabIndex = 16;
            switchSectionTick.UseVisualStyleBackColor = true;
            switchSectionTick.CheckedChanged += switchSectionTick_CheckedChanged;
            // 
            // payoutLabel
            // 
            payoutLabel.AutoSize = true;
            payoutLabel.Location = new Point(232, 176);
            payoutLabel.Name = "payoutLabel";
            payoutLabel.Size = new Size(56, 15);
            payoutLabel.TabIndex = 15;
            payoutLabel.Text = "Payout: x";
            payoutLabel.Visible = false;
            // 
            // useDiceButton
            // 
            useDiceButton.Location = new Point(3, 214);
            useDiceButton.Margin = new Padding(3, 2, 3, 2);
            useDiceButton.Name = "useDiceButton";
            useDiceButton.Size = new Size(80, 22);
            useDiceButton.TabIndex = 14;
            useDiceButton.Text = "Cast";
            useDiceButton.UseVisualStyleBackColor = true;
            useDiceButton.Click += useDiceButton_Click;
            // 
            // rollBox
            // 
            rollBox.DisplayMember = "title";
            rollBox.FormattingEnabled = true;
            rollBox.ItemHeight = 15;
            rollBox.Location = new Point(3, 118);
            rollBox.Margin = new Padding(3, 2, 3, 2);
            rollBox.Name = "rollBox";
            rollBox.Size = new Size(107, 94);
            rollBox.TabIndex = 13;
            rollBox.SelectedIndexChanged += rollBox_SelectedIndexChanged;
            // 
            // diceLabel
            // 
            diceLabel.AutoSize = true;
            diceLabel.Location = new Point(158, 122);
            diceLabel.Name = "diceLabel";
            diceLabel.Size = new Size(109, 15);
            diceLabel.TabIndex = 12;
            diceLabel.Text = "hidden for dice pos";
            diceLabel.Visible = false;
            // 
            // currentPlayerLabel
            // 
            currentPlayerLabel.AutoSize = true;
            currentPlayerLabel.Font = new Font("Segoe UI", 15F);
            currentPlayerLabel.Location = new Point(198, 2);
            currentPlayerLabel.Name = "currentPlayerLabel";
            currentPlayerLabel.Size = new Size(144, 28);
            currentPlayerLabel.TabIndex = 11;
            currentPlayerLabel.Text = "Current Player: ";
            // 
            // moneyLabel
            // 
            moneyLabel.AutoSize = true;
            moneyLabel.Location = new Point(125, 41);
            moneyLabel.Name = "moneyLabel";
            moneyLabel.Size = new Size(47, 15);
            moneyLabel.TabIndex = 10;
            moneyLabel.Text = "Money:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(125, 26);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(48, 15);
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
            shopPanel.Location = new Point(686, 20);
            shopPanel.Margin = new Padding(3, 2, 3, 2);
            shopPanel.Name = "shopPanel";
            shopPanel.Size = new Size(620, 265);
            shopPanel.TabIndex = 10;
            shopPanel.Visible = false;
            // 
            // healthBarShop
            // 
            healthBarShop.Location = new Point(71, 26);
            healthBarShop.Margin = new Padding(3, 2, 3, 2);
            healthBarShop.Name = "healthBarShop";
            healthBarShop.Size = new Size(109, 15);
            healthBarShop.TabIndex = 20;
            // 
            // upgradeRollButton
            // 
            upgradeRollButton.Location = new Point(332, 141);
            upgradeRollButton.Margin = new Padding(3, 2, 3, 2);
            upgradeRollButton.Name = "upgradeRollButton";
            upgradeRollButton.Size = new Size(82, 22);
            upgradeRollButton.TabIndex = 19;
            upgradeRollButton.Text = "Buy";
            upgradeRollButton.UseVisualStyleBackColor = true;
            upgradeRollButton.Visible = false;
            upgradeRollButton.Click += upgradeRollButton_Click;
            // 
            // incomingDamageLabelShop
            // 
            incomingDamageLabelShop.AutoSize = true;
            incomingDamageLabelShop.Location = new Point(13, 41);
            incomingDamageLabelShop.Name = "incomingDamageLabelShop";
            incomingDamageLabelShop.Size = new Size(111, 15);
            incomingDamageLabelShop.TabIndex = 17;
            incomingDamageLabelShop.Text = "Incoming Damage: ";
            // 
            // attackLabelShop
            // 
            attackLabelShop.AutoSize = true;
            attackLabelShop.Location = new Point(287, 26);
            attackLabelShop.Name = "attackLabelShop";
            attackLabelShop.Size = new Size(47, 15);
            attackLabelShop.TabIndex = 14;
            attackLabelShop.Text = "Attack: ";
            // 
            // healthLabelShop
            // 
            healthLabelShop.AutoSize = true;
            healthLabelShop.Location = new Point(13, 26);
            healthLabelShop.Name = "healthLabelShop";
            healthLabelShop.Size = new Size(48, 15);
            healthLabelShop.TabIndex = 13;
            healthLabelShop.Text = "Health: ";
            // 
            // currentPlayerLabelShop
            // 
            currentPlayerLabelShop.AutoSize = true;
            currentPlayerLabelShop.Font = new Font("Segoe UI", 15F);
            currentPlayerLabelShop.Location = new Point(122, 2);
            currentPlayerLabelShop.Name = "currentPlayerLabelShop";
            currentPlayerLabelShop.Size = new Size(144, 28);
            currentPlayerLabelShop.TabIndex = 12;
            currentPlayerLabelShop.Text = "Current Player: ";
            // 
            // buyButton
            // 
            buyButton.Location = new Point(152, 141);
            buyButton.Margin = new Padding(3, 2, 3, 2);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(82, 22);
            buyButton.TabIndex = 12;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // moneyLabelShop
            // 
            moneyLabelShop.AutoSize = true;
            moneyLabelShop.Location = new Point(13, 11);
            moneyLabelShop.Name = "moneyLabelShop";
            moneyLabelShop.Size = new Size(47, 15);
            moneyLabelShop.TabIndex = 11;
            moneyLabelShop.Text = "Money:";
            // 
            // upgradesBox
            // 
            upgradesBox.DisplayMember = "description";
            upgradesBox.FormattingEnabled = true;
            upgradesBox.ItemHeight = 15;
            upgradesBox.Location = new Point(31, 58);
            upgradesBox.Margin = new Padding(3, 2, 3, 2);
            upgradesBox.Name = "upgradesBox";
            upgradesBox.Size = new Size(279, 79);
            upgradesBox.TabIndex = 1;
            upgradesBox.ValueMember = "name";
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.Location = new Point(10, 2);
            returnToMenuButton.Margin = new Padding(3, 2, 3, 2);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(82, 22);
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
            // rollsUpgradeBox
            // 
            rollsUpgradeBox.DisplayMember = "title";
            rollsUpgradeBox.FormattingEnabled = true;
            rollsUpgradeBox.ItemHeight = 15;
            rollsUpgradeBox.Location = new Point(314, 58);
            rollsUpgradeBox.Margin = new Padding(3, 2, 3, 2);
            rollsUpgradeBox.Name = "rollsUpgradeBox";
            rollsUpgradeBox.Size = new Size(120, 79);
            rollsUpgradeBox.TabIndex = 18;
            rollsUpgradeBox.Visible = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1551, 293);
            Controls.Add(shopPanel);
            Controls.Add(returnToMenuButton);
            Controls.Add(gamePanel);
            MaximizeBox = false;
            Name = "Game";
            Text = "game";
            FormClosed += Game_FormClosed;
            Load += Game_Load;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)victorySoundPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentPlayerPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)rollSoundPlayer).EndInit();
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
        private Button upgradeRollButton;
        private ProgressBar healthBar;
        private ProgressBar healthBarShop;
        private System.Windows.Forms.Timer rollTimer;
        private AxWMPLib.AxWindowsMediaPlayer rollSoundPlayer;
        private PictureBox currentPlayerPicture;
        private AxWMPLib.AxWindowsMediaPlayer victorySoundPlayer;
        private Label spellDetailLabel;
        private ListBox rollsUpgradeBox;
    }
}