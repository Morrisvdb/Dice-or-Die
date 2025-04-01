using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
        public int current_player = 1;
        public int current_round = 1;
        public int current_health = 100;
        public int current_money = 0;
        public int pending_damage = 0;

        public Game()
        {
            InitializeComponent();
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
                this.Controls.Add(b);
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
                return;
            }
            rolls_left--;
            amountrolls_label.Text = rolls_left.ToString();
            if (rolls_left == 0)
            {
                rolldice_button.Enabled = false;
            }
            roll_dice(dice_count);

            draw_dice(x: 50, y: 50, count: dice_count);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            init_dice(dice_count);
        }

        private void switch_players()
        {
            List<PlayerData> _data = new List<PlayerData>();


            _data.Add(new PlayerData
            {
                player_id = current_player,
                health = current_health,
                money = current_money,
                dice_count = dice_count,
                pending_damage = pending_damage
            });

            string json_out = JsonSerializer.Serialize(_data);
            File.WriteAllText(@"./data/player_" + current_player + "_data.json", json_out);

            current_player = current_player == 1 ? 2 : 1;

            string json_in = File.ReadAllText(@"./data/player_" + current_player + "_data.json");
            List<PlayerData> _data_in = JsonSerializer.Deserialize<List<PlayerData>>(json_in);

            current_health = _data_in[0].health;
            current_money = _data_in[0].money;
            dice_count = _data_in[0].dice_count;
            pending_damage = _data_in[0].pending_damage;
        }

        public class PlayerData
        {
            public int player_id { get; set; }
            public int health { get; set; }
            public int money { get; set; }
            public int dice_count { get; set; }
            public int pending_damage { get; set; }
        }
    }
}