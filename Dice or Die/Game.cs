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
        public List<int> rolls;
        private List<Button> current_buttons = new List<Button>(6);

        public Game()
        {
            InitializeComponent();
        }

        private List<int> roll_dice(int count = 5)
        {
            List<int> rolls = new List<int>(count);
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                rolls.Add(random.Next(1, 7));
            }

            return rolls;
        }

        private void draw_dice(int x, int y, List<int> rolls, int size = 50, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Button b = new Button();
                b.Name = "dice_" + i.ToString();
                b.Text = rolls[i].ToString();
                b.Width = size;
                b.Height = size;
                b.Location = new Point(x + (i * (size * 2)), y);
                this.Controls.Add(b);
                current_buttons.Add(b);
            }
            return;
        }

        private void rolldice_button_Click(object sender, EventArgs e)
        {
            //Button b = new Button();

            List<int> rolls = roll_dice();

            draw_dice(50, 50, rolls);
        }
    }
}
