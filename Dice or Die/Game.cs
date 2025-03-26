using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_or_Die
{
    public partial class Game : Form
    {
        public int rolls_left = 3;
        public Dictionary<string, KeyValuePair<int, bool>> dice = new Dictionary<string, KeyValuePair<int, bool>>(); // { button_name(string): { value{int}: locked{bool} } }
        private List<Button> current_buttons = new List<Button>();
        //private List<Button> locked_dice = new List<Button>();
        private int dice_count = 5;

        public Game()
        {
            InitializeComponent();
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

            foreach (var die in dice)
            {
                
            }


        }

        private void dice_OnClick(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                Dictionary<int, bool> dButton;
                dice.TryGetValue(b.Name, out dButton);
                if (dButton == null)
                {
                    //dButton = new Dictionary<int, bool>();
                    //dice.Add(b.Name, dButton);
                    return;
                }

                if (dButton[1])
                {
                    dButton[1] = false;
                    b.BackColor = Color.LightGray;
                }
                else
                {
                    dButton[1] = true;
                    b.BackColor = Color.Yellow;

                }
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


            //string outp = "";
            //foreach (var roll in rolls)
            //{
            //    outp += roll.ToString() + " ";
            //}
            //label1.Text = outp;
        }
    }
}
