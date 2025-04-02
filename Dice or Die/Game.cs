using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Dice_or_Die
{
    public partial class Game : Form
    {
        public int rolls_left = 3;
        public Dictionary<string, KeyValuePair<int, bool>> dice = new Dictionary<string, KeyValuePair<int, bool>>(); // { button_name(string): { value{int}: locked{bool} } }
        private List<Button> current_buttons = new List<Button>();
        private int dice_count = 5;
        private int roll_count = 3;
        public int current_player = 1;
        public int current_round = 1;
        public int current_health = 100;
        public int current_money = 0;
        public int pending_damage = 0;
        public int outgoing_damage = 0;
        public int max_health = 10;
        public bool in_shop = false;
        public int shield = 0;
        public int grace = 0;
        public int damage_multiplier = 1;

        public Game()
        {
            InitializeComponent();
            this.FormClosed += save_on_close;
        }

        public class PlayerData
        {
            public int player_id { get; set; }
            public int health { get; set; }
            public int money { get; set; }
            public int dice_count { get; set; }
            public int roll_count { get; set; }
            public int outgoing_damage { get; set; }
            public int max_health { get; set; }
            public int shield { get; set; }
            public int grace { get; set; } // How many rounds of 100% damage reduction left
            public int damage_multiplier { get; set; }
        }
        public class Upgrade
        {
            public required string name { get; set; }
            public required int cost { get; set; }
            public required string description { get; set; }
            public required string type { get; set; }
            public required int value { get; set; }
        }

        private void save_on_close(object FormClosedEventHandeler, EventArgs e)
        {
            save_game();
        }

        private void init_dice(int count = 5)
        {
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
                KeyValuePair<int, bool> die = dice[b.Name];
                dice[b.Name] = new KeyValuePair<int, bool>(die.Key, !die.Value);
                //b.BackColor = die.Value ? Color.LightGray : Color.LightGreen;
                draw_dice(x: 50, y: 50, count: dice_count);

            }
        }

        private void rolldice_button_Click(object sender, EventArgs e)
        {
            if (rolls_left <= 0)
            {
                start_shop();
                return;
            }
            rolls_left--;
            amountrolls_label.Text = rolls_left.ToString();
            if (rolls_left == 0)
            {
                rolldice_button.Text = "Shop";
            }
            roll_dice(dice_count);

            draw_dice(x: 100, y: 100, count: dice_count);
        }

        private void start_shop()
        {
            in_shop = true;
            gamePanel.Visible = false;
            shopPanel.Visible = true;
            moneyLabelShop.Text = "Money: " + current_money.ToString();
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
                upgradesBox.Items.Add(new Upgrade { name = upgrade.name, cost = upgrade.cost, description = upgrade.description, type = upgrade.type, value = upgrade.value });
            }
        }

        private void resolve_upgrade(Upgrade upgrade)
        {
            switch (upgrade.type)
            {
                case "heal":
                    if (current_health + upgrade.value <= max_health)
                    {
                        current_health += upgrade.value;
                    }
                    else
                    {
                        current_health = max_health;
                    }
                    break;
                case "damage":
                    int value;
                    if (int.TryParse(upgrade.value.ToString(), out value))
                    {
                        outgoing_damage += value;
                        break;
                    }
                    if (upgrade.value.ToString().Split().Contains("x"))
                    {
                        int multiplier = int.Parse(upgrade.value.ToString().Split('x')[0]);
                        damage_multiplier *= multiplier;
                        break;
                    }


                    break;
            }
        }

        private void end_shop()
        {
            in_shop = false;
            gamePanel.Visible = true;
            shopPanel.Visible = false;
            switch_players();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            init_dice(dice_count);
            load_game();
        }

        private void switch_players()
        {
            save_game();

            current_player = current_player == 1 ? 2 : 1;

            load_game();
        }

        private void load_game()
        {
            string other_player = current_player == 1 ? "2" : "1";
            string json_ = File.ReadAllText(@"C:\Informatica\Dice or Die\player_" + other_player + "_data.json");
            List<PlayerData> _data = JsonSerializer.Deserialize<List<PlayerData>>(json_);
            pending_damage = _data[0].outgoing_damage;


            string path = @"C:\Informatica\Dice or Die\player_" + current_player + "_data.json";
            string json_in = File.ReadAllText(path);
            List<PlayerData> _data_in = JsonSerializer.Deserialize<List<PlayerData>>(json_in);
            current_health = _data_in[0].health;
            current_money = _data_in[0].money;
            dice_count = _data_in[0].dice_count;
            roll_count = _data_in[0].roll_count;
            shield = _data_in[0].shield;
            grace = _data_in[0].grace;
            damage_multiplier = _data_in[0].damage_multiplier;

            if (_data_in[0].max_health != 0)
            {
                max_health = _data_in[0].max_health;
            }
            else
            {
                max_health = 10;
            }

            rolls_left = roll_count;
            amountrolls_label.Text = rolls_left.ToString();
            healthLabel.Text = "Health: " + current_health.ToString();
            moneyLabel.Text = "Money: " + current_money.ToString();

        }

        private void save_game()
        {
            string path = @"C:\Informatica\Dice or Die\player_" + current_player + "_data.json";
            File.AppendAllText(path, "");
            List<PlayerData> _data = new List<PlayerData>();

            _data.Add(new PlayerData
            {
                player_id = current_player,
                health = current_health,
                money = current_money,
                dice_count = dice_count,
                roll_count = roll_count,
                damage_multiplier = damage_multiplier,
                max_health = max_health,
                shield = shield,
                grace = grace,
                outgoing_damage = outgoing_damage,
            });

            string json_out = JsonSerializer.Serialize(_data);
            File.WriteAllText(path, json_out);

        }

        private void continueFromShopButton_Click(object sender, EventArgs e)
        {
            end_shop();
        }

        private Upgrade fetch_upgrade(string name = "none")
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
            return new Upgrade{ name = "Help", cost = 20, description = "Help, something went terribly wrong", type = "heal", value = 1 };
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            resolve_upgrade(fetch_upgrade(upgradesBox.SelectedValue.ToString()));
        }
    }
}