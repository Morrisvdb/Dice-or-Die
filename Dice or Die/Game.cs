using AxWMPLib;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Dice_or_Die
{
    public partial class Game : Form
    {
        private Menu menu;
        public Dictionary<string, KeyValuePair<int, bool>> dice = new Dictionary<string, KeyValuePair<int, bool>>(); // { button_name(string): { value{int}: locked{bool} } }
        private List<Button> current_buttons = new List<Button>();
        public int current_player = 1;
        private int tick_count = 0;
        private int current_rolling = 0;

        private const int dice_x = 100;
        private const int dice_y = 100;
        private const int dice_number_font_size = 20;
        private const int dice_rolling_font_size = 10;

        public Game(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        public void PlayStreamWithWMP(Stream audioStream, AxWindowsMediaPlayer player, int volume)
        {
            string tempFile = Path.GetTempFileName() + ".wav";
            using (var fileStream = File.Create(tempFile))
            {
                audioStream.Seek(0, SeekOrigin.Begin);
                audioStream.CopyTo(fileStream);
            }

            player.URL = tempFile;
            player.settings.volume = volume;
            player.Ctlcontrols.play();
        }

        private class Roll
        {
            public string name { get; set; } = "none"; // The name of the roll
            public string title { get; set; } = "none"; // The title of the roll
            public int level { get; set; } = 0; // The level of the roll
            public string effect_type { get; set; } = "none"; // The type of the effect
            public int value { get; set; } = 0; // The value of the effect
            public int schaling { get; set; } = 0; // The scaling of the effect
            public string description { get; set; } = "none"; // The description of the roll
        }

        public class PlayerData
        {
            public int player_id { get; set; } = 1;
            public int round { get; set; } = 0; // The round of the game
            public bool in_shop { get; set; } = false; // Is the player in the shop
            public bool is_turn { get; set; } = false; // Is it the player's turn. If not, automatically switches players
            public int health { get; set; } = 10; // The health of the player
            public int money { get; set; } // The amount of money that the player has
            public int dice_count { get; set; } = 5; // The amount of dice the player has
            public int roll_count { get; set; } = 0; // The amount of rolls the player has made this round
            public int max_rolls { get; set; } = 3; // The maximum number of rolls the player can make
            public int outgoing_damage { get; set; } = 0; // The amount of damage that will be delt to the opponent at the end of their turn
            public int max_health { get; set; } = 10; // The maximum health of the player
            public int shield { get; set; } = 0; // The amount of damage that will be blocked
            public int grace { get; set; } = 0; // How many rounds of 100% damage reduction left
            public int dice_count_mod { get; set; } = 0; // The temportary change in dice count (-1 is one less, 1 is one more ect.)
            public int damage_multiplier { get; set; } = 0; // The amount of damage that will be multiplied by the player (default 1)
            public int high_roll_level { get; set; } = 0; // The level of high roll
            public int pair_level { get; set; } = 0; // The level of pair
            public int three_of_a_kind_level { get; set; } = 0; // The level of three of a kind
            public int four_of_a_kind_level { get; set; } = 0; // The level of four of a kind
            public int full_house_level { get; set; } = 0; // The level of full house
            public int small_straight_level { get; set; } = 0; // The level of small straight
            public int large_straight_level { get; set; } = 0; // The level of large straight
            public int yathzee_level { get; set; } = 0; // The level of yathzee
            public int used_high_rolls { get; set; } = 0; // The number of high rolls used
            public int used_pairs { get; set; } = 0; // The number of pairs used
            public int used_three_of_a_kinds { get; set; } = 0; // The number of three of a kinds used
            public int used_four_of_a_kinds { get; set; } = 0; // The number of four of a kinds used
            public int used_full_houses { get; set; } = 0; // The number of full houses used
            public int used_small_straights { get; set; } = 0; // The number of small straights used
            public int used_large_straights { get; set; } = 0; // The number of large straights used
            public int used_yathzees { get; set; } = 0; // The number of yathzees used
            public int aces_used { get; set; } = 0; // The value of the aces   
            public int twos_used { get; set; } = 0; // The value of the twos
            public int threes_used { get; set; } = 0; // The value of the threes
            public int fours_used { get; set; } = 0; // The value of the fours
            public int fives_used { get; set; } = 0; // The value of the fives
            public int sixes_used { get; set; } = 0; // The value of the sixes

        }

        public PlayerData GetPlayerData(int player_number)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dice or Die\player_" + player_number + "_data.json";

            if (File.Exists(path))
            {
                string json_ = File.ReadAllText(path);
                PlayerData? _data = JsonSerializer.Deserialize<PlayerData>(json_);

                if (_data == null)
                {
                    _data = new PlayerData { player_id = player_number };
                    string json_out = JsonSerializer.Serialize(_data);
                    File.WriteAllText(path, json_out);
                }
                return _data;
            }
            else
            {
                PlayerData _data = new PlayerData { player_id = player_number };
                string json_out = JsonSerializer.Serialize(_data);
                Directory.CreateDirectory(Path.GetDirectoryName(path ?? Path.GetTempPath()) ?? Path.GetTempPath());
                File.WriteAllText(path ?? Path.GetTempPath(), json_out);
                return _data;
            }
        }

        public void commit_player_value(PlayerData data)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dice or Die\player_" + data.player_id + "_data.json";

            string json_ = File.ReadAllText(path);
            PlayerData? _data = JsonSerializer.Deserialize<PlayerData>(json_);
            _data = data;
            string json_out = JsonSerializer.Serialize(_data);
            File.WriteAllText(path, json_out);
        }

        public void reset_save()
        {
            for (int i = 1; i < 3; i++)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Dice or Die\player_" + i + "_data.json";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    return;
                }
                PlayerData _data = new PlayerData { player_id = i };
                string json_out = JsonSerializer.Serialize(_data);
                File.Create(path).Close();
                File.WriteAllText(path, json_out);
            }
        }

        public class Upgrade
        {
            public required string name { get; set; }
            public required int cost { get; set; }
            public required string description { get; set; }
            public required string upgrade_type { get; set; }
            public required int value { get; set; }
        }

        private void init_dice(int count = 5)
        {
            dice.Clear();
            for (int i = 0; i < count; i++)
            {
                dice.Add("die" + i.ToString(), new KeyValuePair<int, bool>(-1, false));
            }
        }

        private void roll_dice(int count = 5)
        {
            foreach (var die in dice)
            {
                if (die.Value.Value)
                {
                    continue;
                }

                Random random = new Random();
                dice[die.Key] = new KeyValuePair<int, bool>(random.Next(1, 7), false);
            }
        }

        private void draw_dice(int x, int y, int size = 50, int count = 5, bool noroll = false)
        {
            // x (int) -> X coordinate of button set
            // y (int) -> Y coordinate of button set
            // rolls (List<int>) -> List of random numbers to display on dice
            // size (int) -> Size of each button
            // count (int) -> Number of buttons to draw

            if (!noroll)
            {
                animate_dice();
            }

            clear_dice();
            foreach (var die in dice)
            {
                Button b = new Button();
                b.Name = die.Key;
                //b.Text = die.Value.Key.ToString();
                b.Size = new Size(size, size);
                b.Location = new Point(x, y);
                b.Click += dice_OnClick;
                if (die.Value.Value)
                {
                    b.BackColor = Color.Yellow;
                    b.Text = die.Value.Key.ToString();
                    b.Font = new Font("Serif", dice_number_font_size, FontStyle.Bold);
                }
                else
                {
                    b.BackColor = Color.LightGreen;
                    if (noroll)
                    {
                        b.Text = die.Value.Key.ToString();
                        b.Font = new Font("Serif", dice_number_font_size, FontStyle.Bold);
                    }
                    else
                    {
                        b.Text = "Rolling...";
                        b.Font = new Font("Serif", dice_rolling_font_size);
                    }
                }
                current_buttons.Add(b);
                gamePanel.Controls.Add(b);
                x += size + 10;
            }
        }

        private void animate_dice(int interval = 25, int loopCount = 25)
        {
            PlayStreamWithWMP(new MemoryStream(Resource1.roll_dice_sound), rollSoundPlayer, volume: menu.sound_volume);
            rollTimer.Interval = 25;
            rollTimer.Enabled = true;
            rolldice_button.Enabled = false;
        }

        private void rollTimer_Tick(object sender, EventArgs e)
        {
            int roll_count = menu.roll_time;
            tick_count++;
            if (tick_count >= roll_count)
            {
                //rollTimer.Enabled = false;
                current_rolling++;
                tick_count = 0;
            }
            if (current_rolling >= dice.Count)
            {
                foreach (var die in current_buttons)
                {
                    die.Text = dice[die.Name].Key.ToString();
                    die.Font = new Font("Serif", dice_number_font_size, FontStyle.Bold);
                }

                current_rolling = 0;
                rollTimer.Enabled = false;
                rolldice_button.Enabled = true;
                if (!switchSectionTick.Checked)
                {
                    fill_rollbox_bottom();
                }
                else
                {
                    fill_rollbox_top();
                }
                return;
            }

            if (dice[current_buttons[current_rolling].Name].Value)
            {
                // If the die is locked, do not change the value
                return;
            }

            if (tick_count == roll_count - 1)
            {
                Button b = current_buttons[current_rolling];
                b.Text = dice[b.Name].Key.ToString();
                b.Font = new Font("Serif", dice_number_font_size, FontStyle.Bold);
            }
            else
            {
                Button b = current_buttons[current_rolling];
                Random random = new Random();
                int value = random.Next(1, 7);
                b.Text = value.ToString();
                b.Font = new Font("Serif", dice_number_font_size, FontStyle.Bold);
            }
        }

        public List<int> to_dicerow()
        {
            List<int> output = new List<int>(dice.Count());
            foreach (var die in dice)
            {
                if (die.Value.Key == -1)
                {
                    continue;
                }
                output.Add(die.Value.Key);
            }
            output.Sort();
            return output;
        }

        private void clear_dice()
        {
            foreach (var button in current_buttons)
            {
                button.Dispose();
            }
            current_buttons.Clear();
        }

        private void dice_OnClick(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                PlayerData data_ = GetPlayerData(current_player);
                KeyValuePair<int, bool> die = dice[b.Name];
                dice[b.Name] = new KeyValuePair<int, bool>(die.Key, !die.Value);
                //b.BackColor = die.Value ? Color.LightGray : Color.LightGreen;
                int x = diceLabel.Location.X;
                int y = diceLabel.Location.Y;
                draw_dice(x: x, y: y, count: data_.dice_count, noroll: true);

            }
        }

        private void rolldice_button_Click(object sender, EventArgs e)
        {
            PlayerData data_ = GetPlayerData(current_player);

            if (data_.roll_count == data_.max_rolls)
            {
                int coins = 0;
                foreach (var die in dice)
                {
                    coins += die.Value.Key;
                }

                payoutLabel.Visible = true;
                payoutLabel.Text = "Payout: $" + coins.ToString();
                rolldice_button.Text = "Shop";
            }

            if (data_.roll_count > data_.max_rolls)
            {
                start_shop();
                return;
            }

            if (data_.roll_count < data_.max_rolls)
            {
                rolldice_button.Enabled = false;
                roll_dice(data_.dice_count);

                draw_dice(x: diceLabel.Location.X, y: diceLabel.Location.Y, count: data_.dice_count);
            }

            data_.roll_count++;
            amountrolls_label.Text = "Rolls Left: " + (data_.max_rolls - data_.roll_count).ToString();

            if (data_.roll_count == data_.max_rolls)
            {
                //payoutLabel.Visible = true;
                //payoutLabel.Text = "Payout: " + coins.ToString() + "$";
                rolldice_button.Text = "Skip";
            }

            commit_player_value(data_);
        }

        private void start_shop()
        {
            PlayerData _data = GetPlayerData(current_player);

            currentPlayerPicture.Image = null;

            int coins = 0;
            var dici = dice;
            foreach (var die in dici)
            {
                if (die.Value.Key == -1)
                {
                    continue;
                }
                coins += die.Value.Key;
            }
            _data.money += coins;


            PlayerData _data2 = GetPlayerData(current_player == 1 ? 2 : 1);
            _data.in_shop = true;
            _data.dice_count_mod = 0;
            commit_player_value(_data);

            gamePanel.Visible = false;
            shopPanel.Visible = true;
            moneyLabelShop.Text = "Money: $" + _data.money.ToString();
            setHealthBar(_data);
            attackLabelShop.Text = "Attack: " + _data.outgoing_damage.ToString();
            incomingDamageLabelShop.Text = "Incoming Damage: " + _data2.outgoing_damage.ToString();
            currentPlayerLabelShop.Text = "Current Player: " + _data.player_id.ToString();
            populate_shop();
        }

        private void populate_shop()
        {
            PlayerData player_data = GetPlayerData(current_player);
            //string rolls_json_in = System.Text.Encoding.Default.GetString(Resource1.rolls);
            //List<Roll>? _rolls = JsonSerializer.Deserialize<List<Roll>>(rolls_json_in);
            string json_in_ = System.Text.Encoding.Default.GetString(Resource1.upgrades);
            json_in_ = json_in_.Trim('\uFEFF');
            List<Upgrade>? _data = JsonSerializer.Deserialize<List<Upgrade>>(json_in_);

            if (_data == null)
            {
                MessageBox.Show("Failed to load shop data.");
                return;
            }

            Random rand = new Random();
            List<Upgrade> selected_upgrades = new List<Upgrade>();
            for (int i = 0; i < 3; i++)
            {
                if (_data.Count == 0)
                {
                    break;
                }
                int r = rand.Next(0, _data.Count);
                selected_upgrades.Add(_data[r]);
                _data.RemoveAt(r);
            }
            upgradesBox.Items.Clear();
            foreach (var upgrade in selected_upgrades)
            {
                upgrade.description += " (" + upgrade.cost + ")";
                upgradesBox.Items.Add(upgrade);
            }

            //List<Roll> upgradeableHands = [_rolls[8], _rolls[9], _rolls[10], _rolls[11], _rolls[12], _rolls[13], _rolls[14]];
            //foreach (var roll in upgradeableHands)
            //{
            //    roll.description += "(100)";
            //    rollsUpgradeBox.Items.Add(roll);
            //}

        }

        private Roll fetch_roll(string name)
        {
            string json_in = System.Text.Encoding.Default.GetString(Resource1.rolls);
            List<Roll>? _data = JsonSerializer.Deserialize<List<Roll>>(json_in);
            if (_data == null)
            {
                return new Roll { name = "error", title = "Failed to fetch rolls" };
            }
            foreach (var roll in _data)
            {
                if (roll.name == name)
                {
                    return roll;
                }
            }
            if (name == "none")
            {
                return new Roll { name = "error", title = "Failed to fetch rolls" };
            }
            return new Roll { name = "error", title = "Failed to fetch rolls" };

        }

        private void fill_rollbox_bottom()
        {
            rollBox.Items.Clear();
            List<int> dicerow = to_dicerow();
            List<string> rolls = validateroll(dicerow);

            foreach (var roll in rolls)
            {
                Roll roll_obj = fetch_roll(roll);
                rollBox.Items.Add(roll_obj);
            }
            if (rollBox.Items.Count > 0)
            {
                useDiceButton.Enabled = true;
            }
            else
            {
                useDiceButton.Enabled = false;
            }
        }

        private void fill_rollbox_top()
        {
            rollBox.Items.Clear();
            List<int> dicerow = to_dicerow();
            List<int> rolls = Countnumbers(dicerow);
            PlayerData data = GetPlayerData(current_player);

            if (rolls[0] > 0 && data.aces_used == 0)
            {
                Roll roll_obj = fetch_roll("aces");
                roll_obj.title += " (" + rolls[0].ToString() + ")";
                roll_obj.value = rolls[0];
                rollBox.Items.Add(roll_obj);
            }

            if (rolls[1] > 0 && data.twos_used == 0)
            {
                Roll roll_obj = fetch_roll("twos");
                roll_obj.title += " (" + rolls[1].ToString() + ")";
                rollBox.Items.Add(roll_obj);
            }
            if (rolls[2] > 0 && data.threes_used == 0)
            {
                Roll roll_obj = fetch_roll("threes");
                roll_obj.title += " (" + rolls[2].ToString() + ")";
                rollBox.Items.Add(roll_obj);
            }

            if (rolls[3] > 0 && data.fours_used == 0)
            {
                Roll roll_obj = fetch_roll("fours");
                roll_obj.title += " (" + rolls[3].ToString() + ")";
                rollBox.Items.Add(roll_obj);
            }

            if (rolls[4] > 0 && data.fives_used == 0)
            {
                Roll roll_obj = fetch_roll("fives");
                roll_obj.title += " (" + rolls[4].ToString() + ")";
                rollBox.Items.Add(roll_obj);
            }

            if (rolls[5] > 0 && data.sixes_used == 0)
            {
                Roll roll_obj = fetch_roll("sixes");
                roll_obj.title += " (" + rolls[5].ToString() + ")";
                rollBox.Items.Add(roll_obj);
            }

            if (rollBox.Items.Count > 0)
            {
                useDiceButton.Enabled = true;
            }
            else
            {
                useDiceButton.Enabled = false;
            }

        }

        private bool resolve_upgrade(Upgrade upgrade)
        {
            PlayerData _data = GetPlayerData(current_player);
            if (upgrade.cost > _data.money)
            {
                return false;
            }
            else
            {
                _data.money -= upgrade.cost;
                moneyLabelShop.Text = "Money: " + _data.money.ToString();
                commit_player_value(_data);
            }
            switch (upgrade.upgrade_type)
            {
                case "heal":
                    if (_data.health + upgrade.value <= _data.max_health)
                    {
                        _data.health += upgrade.value;
                    }
                    else
                    {
                        _data.health = _data.max_health;
                    }
                    //healthLabelShop.Text = "Health: " + _data.health.ToString();
                    setHealthBar(_data);
                    break;

                case "attack":
                    _data.outgoing_damage += upgrade.value;
                    attackLabelShop.Text = "Attack: " + _data.outgoing_damage.ToString();
                    commit_player_value(_data);
                    break;

                case "damagex":
                    _data.outgoing_damage *= upgrade.value;
                    attackLabelShop.Text = "Attack: " + _data.outgoing_damage.ToString();
                    commit_player_value(_data);
                    break;

                case "block":
                    break;

                case "upgrade-roll":

                    break;

                case "growth":
                    _data.max_health += upgrade.value;
                    _data.health += upgrade.value;
                    commit_player_value(_data);
                    break;
            }

            commit_player_value(_data);
            //healthLabelShop.Text = "Health: " + _data.health.ToString();
            setHealthBar(_data);
            moneyLabelShop.Text = "Money: " + _data.money.ToString();
            return true;

        }

        private void end_shop()
        {
            PlayerData _data = GetPlayerData(current_player);
            _data.in_shop = false;
            gamePanel.Visible = true;
            shopPanel.Visible = false;
            _data.roll_count = 0;
            useDiceButton.Enabled = true;
            payoutLabel.Visible = false;


            commit_player_value(_data);
            switch_players();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            PlayerData data_ = GetPlayerData(current_player);
            init_dice(data_.dice_count);
            load_game();
        }

        private void switch_players()
        {
            PlayerData data_ = GetPlayerData(current_player);
            data_.is_turn = false;
            commit_player_value(data_);
            current_player = current_player == 1 ? 2 : 1;

            currentPlayerPicture.Image = current_player == 1 ? Resource1.player1_icon : Resource1.player2_icon;
            PlayerData data_2 = GetPlayerData(current_player);
            data_2.is_turn = true;
            commit_player_value(data_2);

            if (data_2.outgoing_damage - data_.shield > 0)
            {
                PlayStreamWithWMP(new MemoryStream(Resource1.damage_sound), rollSoundPlayer, volume: menu.sound_volume);
            }
            if (data_2.outgoing_damage > 0 && data_2.outgoing_damage - data_.shield > 0)
            {
                PlayStreamWithWMP(new MemoryStream(Resource1.shield_block_sound), rollSoundPlayer, volume: menu.sound_volume);
            }

            data_.health -= (data_2.outgoing_damage - data_.shield);
            data_2.outgoing_damage = 0;

            if (data_.health <= 0)
            {
                // Do a victory screen here
                PlayStreamWithWMP(new MemoryStream(Resource1.victory_sound), victorySoundPlayer, volume: menu.sound_volume);
                MessageBox.Show("Player " + data_2.player_id + " wins!");
            }

            commit_player_value(data_);
            commit_player_value(data_2);

            load_game();
        }

        private void init_game()
        {
            PlayerData data_ = GetPlayerData(current_player);
            PlayerData data_2 = GetPlayerData(current_player == 1 ? 2 : 1);
            gamePanel.Visible = true;
            shopPanel.Visible = false;
            amountrolls_label.Text = "Rolls Left: " + (data_.max_rolls - data_.roll_count).ToString();
            currentPlayerLabel.Text = "Current Player: " + data_.player_id.ToString();
            rolldice_button.Text = "Roll";
            moneyLabel.Text = "Money: " + data_.money.ToString();
            //healthLabel.Text = "Health: " + data_.health.ToString();
            setHealthBar(data_);
            incomingDamageLabel.Text = "Incoming Damage: " + data_2.outgoing_damage.ToString();
            attackLabel.Text = "Attack: " + data_.outgoing_damage.ToString();
            int t = data_.player_id;

            clear_dice();
            init_dice(data_.dice_count + data_.dice_count_mod);
            fill_rollbox_bottom();

        }

        private void load_game()
        {
            PlayerData _data = GetPlayerData(current_player);
            if (!_data.is_turn)
            {
                PlayerData _data2 = GetPlayerData(current_player == 1 ? 2 : 1);
                if (_data2.is_turn)
                {
                    _data = _data2;
                    current_player = _data2.player_id;
                    commit_player_value(_data2);

                }
                else
                {
                    _data.is_turn = true;
                }
            }
            current_player = _data.player_id;

            currentPlayerPicture.Image = current_player == 1 ? Resource1.player1_icon : Resource1.player2_icon;

            commit_player_value(_data);
            if (_data.in_shop)
            {
                start_shop();
            }
            else
            {
                init_game();
            }
        }

        private void continueFromShopButton_Click(object sender, EventArgs e)
        {
            end_shop();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (upgradesBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an upgrade");
                return;
            }

            int selected_index = upgradesBox.SelectedIndex;
            Upgrade? selected_value = upgradesBox.SelectedItems[0] as Upgrade;

            if (selected_value == null)
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            if (!resolve_upgrade(selected_value))
            {
                MessageBox.Show("Not enough money");
            }
            else
            {
                upgradesBox.Items.RemoveAt(selected_index);
                PlayStreamWithWMP(new MemoryStream(Resource1.buysound), rollSoundPlayer, volume: menu.sound_volume);
            }
        }

        private List<string> add_if_not_exists(List<string> list, string item)
        {
            if (item == null)
            {
                return list;
            }

            if (!list.Contains(item))
            {
                list.Add(item);
                return list;
            }


            return list;
        }

        private List<int> Countnumbers(List<int> dicerow)
        {
            int amount_ones = 0;
            int amount_twos = 0;
            int amount_threes = 0;
            int amount_fours = 0;
            int amount_fives = 0;
            int amount_sixes = 0;

            foreach (int j in dicerow)
            {
                switch (j)
                {
                    case 1:
                        amount_ones++;
                        break;

                    case 2:
                        amount_twos++;
                        break;

                    case 3:
                        amount_threes++;
                        break;

                    case 4:
                        amount_fours++;
                        break;

                    case 5:
                        amount_fives++;
                        break;

                    case 6:
                        amount_sixes++;
                        break;

                    default:
                        MessageBox.Show("Unexpected value");
                        break;
                }
            }
            List<int> allnumber_count = new List<int>();
            allnumber_count.Add(amount_ones);
            allnumber_count.Add(amount_twos);
            allnumber_count.Add(amount_threes);
            allnumber_count.Add(amount_fours);
            allnumber_count.Add(amount_fives);
            allnumber_count.Add(amount_sixes);
            return allnumber_count;

        }


        private List<string> validateroll(List<int> dicerow)
        {
            if (dicerow.Count == 0)
            {
                return new List<string>();
            }
            while (dicerow.Count < 5)
            {
                dicerow.Add(0);
            }
            List<string> rolls = new List<string>();
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool full_house = false;
            bool pair = false;
            bool three_of_a_kind = false;
            bool four_of_a_kind = false;
            bool small_straight = false;
            bool large_straight = false;
            bool yathzee = false;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


            if (dicerow[0] == dicerow[1] && dicerow[0] > 0 && dicerow[1] > 0 || dicerow[1] == dicerow[2] && dicerow[1] > 0 && dicerow[2] > 0 || dicerow[2] == dicerow[3] && dicerow[2] > 0 && dicerow[3] > 0 || dicerow[3] == dicerow[4] && dicerow[3] > 0 && dicerow[4] > 0)
            {
                rolls = add_if_not_exists(rolls, "pair");
                pair = true;
            }

            if (dicerow[0] == dicerow[1] && dicerow[1] == dicerow[2] && dicerow[0] > 0 && dicerow[1] > 0 && dicerow[2] > 0 || dicerow[1] == dicerow[2] && dicerow[2] == dicerow[3] && dicerow[1] > 0 && dicerow[2] > 0 && dicerow[3] > 0 || dicerow[2] == dicerow[3] && dicerow[3] == dicerow[4] && dicerow[2] > 0 && dicerow[3] > 0 && dicerow[4] > 0)
            {
                rolls = add_if_not_exists(rolls, "three_of_a_kind");
                rolls = add_if_not_exists(rolls, "pair");
                three_of_a_kind = true;
                pair = true;
            }

            if (dicerow[0] == dicerow[3] && dicerow[0] > 0 && dicerow[3] > 0 || dicerow[1] == dicerow[4] && dicerow[1] > 0 && dicerow[4] > 0)
            {
                rolls = add_if_not_exists(rolls, "four_of_a_kind");
                rolls = add_if_not_exists(rolls, "three_of_a_kind");
                rolls = add_if_not_exists(rolls, "pair");
                four_of_a_kind = true;
                three_of_a_kind = true;
                pair = true;
            }

            if (dicerow[0] == dicerow[4] && dicerow[0] > 0 && dicerow[4] > 0)
            {
                rolls = add_if_not_exists(rolls, "yathzee");
                rolls = add_if_not_exists(rolls, "four_of_a_kind");
                rolls = add_if_not_exists(rolls, "three_of_a_kind");
                rolls = add_if_not_exists(rolls, "pair");
                yathzee = true;
                four_of_a_kind = true;
                three_of_a_kind = true;
                pair = true;
            }

            var groups = dicerow.GroupBy(x => x).Where(g => g.Key > 0).Select(g => g.Count()).OrderByDescending(c => c).ToList();
            if (groups.Count >= 2 && groups[0] == 3 && groups[1] == 2)
            {
                rolls = add_if_not_exists(rolls, "full_house");
                full_house = true;
            }

            if (dicerow[0] == dicerow[1] - 1 && dicerow[1] == dicerow[2] - 1 && dicerow[2] == dicerow[3] - 1 && dicerow[3] == dicerow[4] - 1)
            {
                rolls = add_if_not_exists(rolls, "large_straight");
                large_straight = true;
            }
            if (pair)
            {
                List<int> pair_list = new List<int>();
                foreach (int i in dicerow) { pair_list.Add(i); }
                if (pair_list[3] == pair_list[4]) { pair_list.RemoveAt(3); }
                if (pair_list[2] == pair_list[3]) { pair_list.RemoveAt(2); }
                if (pair_list[1] == pair_list[2]) { pair_list.RemoveAt(1); }
                if (pair_list[0] == pair_list[1]) { pair_list.RemoveAt(0); }
                if (pair_list.Count == 4)
                {
                    if ((pair_list[0] == pair_list[1] - 1) && (pair_list[1] == pair_list[2] - 1) && (pair_list[2] == pair_list[3] - 1))
                    {
                        rolls = add_if_not_exists(rolls, "small_straight");
                        small_straight = true;
                    }
                }

            }

            if (dicerow[0] == dicerow[1] - 1 && dicerow[1] == dicerow[2] - 1 && dicerow[2] == dicerow[3] - 1 || dicerow[1] == dicerow[2] - 1 && dicerow[2] == dicerow[3] - 1 && dicerow[3] == dicerow[4] - 1)
            {
                rolls = add_if_not_exists(rolls, "small_straight");
                small_straight = true;
            }

            return rolls;

        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            AxWindowsMediaPlayer player = (AxWindowsMediaPlayer)menu.Controls.Find("musicPlayer", true).FirstOrDefault();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            menu.FadeOutMusic(1000, player);
            menu.PlayTrackWithFadeIn(Resource1.menu_music, player, 1000, volume: menu.music_volume);
#pragma warning restore CS8604 // Possible null reference argument.
            menu.Show();
            //menu.Controls.Find("")
            this.Hide();
        }

        private void useDiceButton_Click(object sender, EventArgs e)
        {
            Roll? roll = rollBox.SelectedItem as Roll;
            if (roll == null)
            {
                MessageBox.Show("Please select a roll");
                return;
            }

            PlayerData data_ = GetPlayerData(current_player);
            PlayerData data_2 = GetPlayerData(current_player == 1 ? 2 : 1);
            data_.roll_count = 0;
            int value = roll.value + roll.level * roll.schaling;
            int coins = 0;
            switch (roll.effect_type)
            {
                case "heal":
                    if (data_.health + value <= data_.max_health)
                    {
                        data_.health += value;
                    }
                    else
                    {
                        data_.health = data_.max_health;
                    }
                    break;
                case "damage":
                    data_.outgoing_damage += value;
                    attackLabel.Text = "Attack: " + data_.outgoing_damage.ToString();
                    break;
                case "coins":
                    data_.money += value;
                    break;
                case "reduce_dice":
                    data_2.dice_count_mod -= value;
                    break;
                case "coins-top":
                    switch (roll.name)
                    {
                        case "aces":
                            if (data_.aces_used > 0)
                            {
                                return;
                            }
                            data_.aces_used += value;
                            coins += value * 2;
                            break;
                        case "twos":
                            if (data_.twos_used > 0)
                            {
                                return;
                            }
                            data_.twos_used += value;
                            coins += value * 2;
                            break;
                        case "threes":
                            if (data_.threes_used > 0)
                            {
                                return;
                            }
                            data_.threes_used += value;
                            coins += value * 2;
                            break;
                        case "fours":
                            if (data_.fours_used > 0)
                            {
                                return;
                            }
                            data_.fours_used += value;
                            coins += value * 2;
                            break;
                        case "fives":
                            if (data_.fives_used > 0)
                            {
                                return;
                            }
                            data_.fives_used += value;
                            coins += value * 2;
                            break;
                        case "sixes":
                            if (data_.sixes_used > 0)
                            {
                                return;
                            }
                            data_.sixes_used += value;
                            coins += value * 2;
                            break;
                    }

                    if (data_.aces_used > 0 && data_.twos_used > 0 && data_.threes_used > 0 && data_.fours_used > 0 && data_.fives_used > 0 && data_.sixes_used > 0)
                    {
                        int upper_total = data_.aces_used + data_.twos_used + data_.threes_used + data_.fours_used + data_.fives_used + data_.sixes_used;

                        if (upper_total >= 63)
                        {
                            coins = 100;
                        }
                        else
                        {
                            if (upper_total > 42)
                            {
                                coins = 15;
                            }
                            else
                            {
                                if (upper_total > 21)
                                {
                                    coins = 10;
                                }
                                else
                                {
                                    coins = 5;
                                }
                            }
                        }


                    }
                    break;
            }
            foreach (var die in dice)
            {
                coins += die.Value.Key;
            }
            data_.roll_count = data_.max_rolls;
            payoutLabel.Visible = true;
            payoutLabel.Text = "Payout: " + coins.ToString() + "$";
            amountrolls_label.Text = "Rolls Left: " + (data_.max_rolls - data_.roll_count).ToString();
            rolldice_button.Text = "Shop";
            rolldice_button.Enabled = true;
            start_shop();
            commit_player_value(data_);
            commit_player_value(data_2);
            rollBox.Items.Clear();

        }

        private void switchSectionTick_CheckedChanged(object sender, EventArgs e)
        {
            if (switchSectionTick.Checked)
            {
                // Top
                fill_rollbox_top();
            }
            else
            {
                // Bottom | Default
                fill_rollbox_bottom();
            }
        }

        private void upgradeRollButton_Click(object sender, EventArgs e)
        {
            if (rollsUpgradeBox.SelectedItem == null)
            {
                return;
            }
            PlayerData playerData = GetPlayerData(current_player);
            Roll selected_roll = (Roll)rollsUpgradeBox.SelectedItem;

            if (playerData.money < 50)
            {
                MessageBox.Show("Not enough money");
                return;
            }
            else
            {
                switch (selected_roll.name)
                {
                    case "high_roll":
                        playerData.high_roll_level++;
                        break;
                    case "pair":
                        playerData.pair_level++;
                        break;
                    case "three_of_a_kind":
                        playerData.three_of_a_kind_level++;
                        break;
                    case "four_of_a_kind":
                        playerData.four_of_a_kind_level++;
                        break;
                    case "full_house":
                        playerData.full_house_level++;
                        break;
                    case "small_straight":
                        playerData.small_straight_level++;
                        break;
                    case "large_straight":
                        playerData.large_straight_level++;
                        break;
                    case "yathzee":
                        playerData.yathzee_level++;
                        break;
                }
                playerData.money -= 50;
                moneyLabelShop.Text = "Money: " + playerData.money.ToString();
                commit_player_value(playerData);
            }
        }

        private void setHealthBar(PlayerData playerData)
        {
            ProgressBar bar;
            if (playerData.in_shop)
            {
                bar = healthBarShop;
            }
            else
            {
                bar = healthBar;
            }

            bar.Maximum = playerData.max_health;
            bar.Value = playerData.health;

            float h_frac = (float)playerData.health / (float)playerData.max_health;
            if (h_frac <= 0.25)
            {
                bar.SetState(2); // Error state
            }
            else if (h_frac <= 0.5)
            {
                bar.SetState(1); // Warning state
            }
            else
            {
                bar.SetState(0); // Normal state
            }

            bar.Refresh();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }

        private void rollBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Roll? selectedRoll = rollBox.SelectedItem as Roll;
            if (selectedRoll != null)
            {
                selectedRoll = fetch_roll(selectedRoll.name);
                int value = selectedRoll.value + selectedRoll.level * selectedRoll.schaling;
                spellDetailLabel.Text = selectedRoll.description.Replace("{var}", value.ToString());
            }

        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}