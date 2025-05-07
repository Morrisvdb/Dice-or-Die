using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dice_or_Die
{
    public partial class Game : Form
    {
        public Dictionary<string, KeyValuePair<int, bool>> dice = new Dictionary<string, KeyValuePair<int, bool>>(); // { button_name(string): { value{int}: locked{bool} } }
        private List<Button> current_buttons = new List<Button>();
        public int current_player = 1;

        private const int dice_x = 100;
        private const int dice_y = 100;

        public Game()
        {
            InitializeComponent();
        }

        public class PlayerData
        {
            public int player_id { get; set; } = 1;
            public int round { get; set; } = 0; // The round of the game
            public bool in_shop { get; set; } = false; // Is the player in the shop
            public bool is_turn { get; set; } = false; // Is it the player's turn. If not, automatically switches players
            public int health { get; set; } = 10; // The health of the player
            public int money { get; set; } = 0; // The amount of money that the player has
            public int dice_count { get; set; } = 5; // The amount of dice the player has
            public int roll_count { get; set; } = 0; // The amount of rolls the player has made this round
            public int max_rolls { get; set; } = 3; // The maximum number of rolls the player can make
            public int outgoing_damage { get; set; } = 0; // The amount of damage that will be delt to the opponent at the end of their turn
            public int max_health { get; set; } = 10; // The maximum health of the player
            public int shield { get; set; } = 0; // The amount of damage that will be blocked
            public int grace { get; set; } = 0; // How many rounds of 100% damage reduction left
            public int damage_multiplier { get; set; } = 1; // The amount of damage that will be multiplied by the player (default 1)
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
        }

        public PlayerData GetPlayerData(int player_number)
        {
            string path = @"C:\Informatica\Dice or Die\player_" + player_number + "_data.json";
            if (!File.Exists(path))
            {
                PlayerData _data = new PlayerData { player_id = player_number };
                string json_out = JsonSerializer.Serialize(_data);
                File.Create(path).Close();
                File.WriteAllText(path, json_out);
                return new PlayerData();
            }
            else
            {
                string json_ = File.ReadAllText(path);
                PlayerData _data = JsonSerializer.Deserialize<PlayerData>(json_);

                return _data;
            }
        }

        public void commit_player_value(PlayerData data)
        {
            string json_ = File.ReadAllText(@"C:\Informatica\Dice or Die\player_" + data.player_id + "_data.json");
            PlayerData _data = JsonSerializer.Deserialize<PlayerData>(json_);
            _data = data;
            string json_out = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"C:\Informatica\Dice or Die\player_" + data.player_id + "_data.json", json_out);
        }

        public void reset_save()
        {
            for (int i = 1; i < 3; i++)
            {
                string path = @"C:\Informatica\Dice or Die\player_" + i + "_data.json";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                PlayerData _data = new PlayerData { player_id = current_player };
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
            public required string type { get; set; }
            public required int value { get; set; }
        }

        private void init_dice(int count = 5)
        {
            dice.Clear();
            for (int i = 0; i < count; i++)
            {
                dice.Add("die" + i.ToString(), new KeyValuePair<int, bool>(0, false));
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

        private void draw_dice(int x, int y, int size = 50, int count = 5)
        {
            // x (int) -> X coordinate of button set
            // y (int) -> Y coordinate of button set
            // rolls (List<int>) -> List of random numbers to display on dice
            // size (int) -> Size of each button
            // count (int) -> Number of buttons to draw
            clear_dice();
            foreach (var die in dice)
            {
                Button b = new Button();
                b.Name = die.Key;
                b.Text = die.Value.Key.ToString();
                b.Size = new Size(size, size);
                b.Location = new Point(x, y);
                b.Click += dice_OnClick;
                if (die.Value.Value)
                {
                    b.BackColor = Color.Yellow;
                }
                else
                {
                    b.BackColor = Color.LightGreen;
                }
                current_buttons.Add(b);
                gamePanel.Controls.Add(b);
                x += size + 10;
            }


        }

        public List<int> to_dicerow()
        {
            List<int> output = new List<int>(dice.Count());
            foreach (var die in dice)
            {
                output.Add(die.Value.Key);
            }
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
                draw_dice(x: x, y: y, count: data_.dice_count);

            }
        }

        private void rolldice_button_Click(object sender, EventArgs e)
        {
            PlayerData data_ = GetPlayerData(current_player);
            if (data_.roll_count >= data_.max_rolls)
            {
                start_shop();
                return;
            }
            data_.roll_count++;
            amountrolls_label.Text = "Rolls Left: " + (data_.max_rolls - data_.roll_count).ToString();
            if (data_.roll_count == data_.max_rolls)
            {
                rolldice_button.Text = "Shop";
            }
            roll_dice(data_.dice_count);

            draw_dice(x: dice_x, y: dice_y, count: data_.dice_count);

            commit_player_value(data_);
        }

        private void start_shop()
        {
            PlayerData _data = GetPlayerData(current_player);
            _data.in_shop = true;
            commit_player_value(_data);

            gamePanel.Visible = false;
            shopPanel.Visible = true;
            moneyLabelShop.Text = "Money: " + _data.money.ToString();
            currentPlayerLabelShop.Text = "Current Player: " + _data.player_id.ToString();
            populate_shop();
        }

        private void populate_shop()
        {
            string path = @"C:\Informatica\Dice or Die\Dice or Die\Data\upgrades.json";
            string json_in = File.ReadAllText(path);
            List<Upgrade> _data = JsonSerializer.Deserialize<List<Upgrade>>(json_in);

            Random rand = new Random();
            List<Upgrade> selected_upgrades = new List<Upgrade>();
            for (int i = 0; i < 3; i++)
            {
                int r = rand.Next(0, _data.Count);
                selected_upgrades.Add(_data[r]);
                _data.RemoveAt(r);
            }
            upgradesBox.Items.Clear();
            foreach (var upgrade in selected_upgrades)
            {
                upgradesBox.Items.Add(new Upgrade { name = upgrade.name, cost = upgrade.cost, description = upgrade.name + " (" + upgrade.cost + ")", type = upgrade.type, value = upgrade.value });
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
            }
            switch (upgrade.type)
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
                    break;

                case "attack":
                    _data.outgoing_damage += upgrade.value;
                    break;

                case "damagex":
                    _data.outgoing_damage += upgrade.value;
                    break;

                case "block":
                    break;

                case "upgrade-roll":

                    break;
            }

            commit_player_value(_data);
            return true;
        }

        private void end_shop()
        {
            PlayerData _data = GetPlayerData(current_player);
            _data.in_shop = false;
            gamePanel.Visible = true;
            shopPanel.Visible = false;
            _data.roll_count = 0;

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
            current_player = current_player == 1 ? 2 : 1;
            PlayerData data_2 = GetPlayerData(current_player);
            data_2.is_turn = true;
            commit_player_value(data_);
            commit_player_value(data_2);

            load_game();
        }

        private void init_game()
        {
            PlayerData data_ = GetPlayerData(current_player);
            gamePanel.Visible = true;
            shopPanel.Visible = false;
            amountrolls_label.Text = "Rolls Left: " + (data_.max_rolls - data_.roll_count).ToString();
            currentPlayerLabel.Text = "Current Player: " + data_.player_id.ToString();
            rolldice_button.Text = "Roll";
            moneyLabel.Text = "Money: " + data_.money.ToString();
            healthLabel.Text = "Health: " + data_.health.ToString();
            int t = data_.player_id;

            clear_dice();
            init_dice(data_.dice_count);

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

        private Upgrade fetch_upgrade(string name)
        {
            string path = @"C:\Informatica\Dice or Die\Dice or Die\Data\upgrades.json";
            string json_in = File.ReadAllText(path);
            List<Upgrade> _data = JsonSerializer.Deserialize<List<Upgrade>>(json_in);
            foreach (var upgrade in _data)
            {
                if (upgrade.name == name)
                {
                    return upgrade;
                }
            }
            if (name == "none")
            {
                return new Upgrade { name = "Help", cost = 20, description = "Help, something went terribly wrong", type = "heal", value = 1 };
            }
            return new Upgrade { name = "Help", cost = 20, description = "Help, something went terribly wrong", type = "heal", value = 1 };
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            int selected_index = upgradesBox.SelectedIndex;
            var selected_value = upgradesBox.SelectedItem;


            if (selected_value == null)
            {
                MessageBox.Show("Please select an upgrade");
                return;
            }

            if (!resolve_upgrade(fetch_upgrade(selected_value.ToString())))
            {
                MessageBox.Show("Not enough money");
            }
            else
            {
                upgradesBox.Items.RemoveAt(selected_index);
            }

        }

        private List<bool> validateroll(List<int> dicerow)
        {
            bool full_house = false;
            bool pair = false;
            bool three_of_a_kind = false;
            bool four_of_a_kind = false;
            bool small_straight = false;
            bool large_straight = false;
            bool yathzee = false;

            if ((dicerow[0] == dicerow[1] && dicerow[2] == dicerow[4] && dicerow[0] != dicerow[4]) || ((dicerow[0] == dicerow[2] && dicerow[3] == dicerow[4] && dicerow[0] != dicerow[4])))
            {
                full_house = true;
                pair = true;
                three_of_a_kind = true;
            }

            if (dicerow[0] == dicerow[4])
            {
                yathzee = true;
                four_of_a_kind = true;
                three_of_a_kind = true;
                pair = true;
            }

            if ((four_of_a_kind == false) && ((dicerow[0] == dicerow[3]) || (dicerow[1] == dicerow[4])))
            {
                four_of_a_kind = true;
                three_of_a_kind = true;
                pair = true;
            }

            if ((three_of_a_kind == false) && ((dicerow[0] == dicerow[2]) || (dicerow[1] == dicerow[3]) || (dicerow[2] == dicerow[4])))
            {
                three_of_a_kind = true;
                pair = true;
            }

            if ((pair == false) && ((dicerow[0] == dicerow[1]) || (dicerow[1] == dicerow[2]) || (dicerow[2] == dicerow[3]) || (dicerow[3] == dicerow[4])))
            {
                pair = true;
            }

            if ((dicerow[1] == dicerow[0] + 1) && (dicerow[2] == dicerow[1] + 1) && (dicerow[3] == dicerow[2] + 1) && (dicerow[4] == dicerow[3] + 1))
            {
                large_straight = true;
                small_straight = true;
            }

            if (small_straight == false)
            {
                if (((dicerow[0] == dicerow[1] - 1) && (dicerow[1] == dicerow[2] - 1) && (dicerow[2] == dicerow[3] - 1)) || ((dicerow[1] == dicerow[2] - 1) && (dicerow[2] == dicerow[3] - 1) && (dicerow[3] == dicerow[4] - 1)))
                {
                    small_straight = true;
                }

                List<int> small_straight_list = [];

                foreach (int i in dicerow) { small_straight_list.Add(i); }

                if (pair == true)
                {
                    if (dicerow[3] == dicerow[4]) { small_straight_list.RemoveAt(3); }
                    if (dicerow[2] == dicerow[3]) { small_straight_list.RemoveAt(2); }
                    if (dicerow[1] == dicerow[2]) { small_straight_list.RemoveAt(1); }
                    if (dicerow[0] == dicerow[1]) { small_straight_list.RemoveAt(0); }

                    if (small_straight_list.Count == 4)
                    {
                        if ((small_straight_list[0] == small_straight_list[1] - 1) && (small_straight_list[1] == small_straight_list[2] - 1) && (small_straight_list[2] == small_straight_list[3] - 1))
                        {
                            small_straight = true;
                        }
                    }
                }
            }
            List<bool> specialrolls = new List<bool>();

            specialrolls.Add(full_house);
            specialrolls.Add(pair);
            specialrolls.Add(three_of_a_kind);
            specialrolls.Add(four_of_a_kind);
            specialrolls.Add(small_straight);
            specialrolls.Add(large_straight);
            specialrolls.Add(yathzee);

            return specialrolls;

        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}