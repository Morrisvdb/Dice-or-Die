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
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        public bool lock_dice1 = false;
        public bool lock_dice2 = false;
        public bool lock_dice3 = false;
        public bool lock_dice4 = false;
        public bool lock_dice5 = false;

        private void die1_Click(object sender, EventArgs e)
        {
            if (lock_dice1 == false)
            {
                lock_dice1 = true;
                die1.BackColor = Color.Yellow;
            }
            else
            {
                lock_dice1 = false;
                die1.BackColor = Color.White;
            }
        }

        private void die2_Click(object sender, EventArgs e)
        {
            if (lock_dice2 == false)
            {
                lock_dice2 = true;
                die2.BackColor = Color.Yellow;
            }
            else
            {
                lock_dice2 = false;
                die2.BackColor = Color.White;
            }
        }

        private void die3_Click(object sender, EventArgs e)
        {
            if (lock_dice3 == false)
            {
                lock_dice3 = true;
                die3.BackColor = Color.Yellow;
            }
            else
            {
                lock_dice3 = false;
                die3.BackColor = Color.White;
            }
        }

        private void die4_Click(object sender, EventArgs e)
        {
            if (lock_dice4 == false)
            {
                lock_dice4 = true;
                die4.BackColor = Color.Yellow;
            }
            else
            {
                lock_dice4 = false;
                die4.BackColor = Color.White;
            }
        }

        private void die5_Click(object sender, EventArgs e)
        {
            if (lock_dice5 == false)
            {
                lock_dice5 = true;
                die5.BackColor = Color.Yellow;
            }
            else
            {
                lock_dice5 = false;
                die5.BackColor = Color.White;
            }
        }

        public int amountrolls = 3;
        private void rolldice_button_Click(object sender, EventArgs e)
        {
            die1.Visible = true;
            die2.Visible = true;
            die3.Visible = true;
            die4.Visible = true;
            die5.Visible = true;
            if (amountrolls != 0)
            {
                amountrolls -= 1;
                amountrolls_label.Text = amountrolls.ToString();
            }
            else
            {
                amountrolls = 2;
                amountrolls_label.Text = amountrolls.ToString();
                lock_dice1 = false;
                die1.BackColor = Color.White;
                lock_dice2 = false;
                die2.BackColor = Color.White;
                lock_dice3 = false;
                die3.BackColor = Color.White;
                lock_dice4 = false;
                die4.BackColor = Color.White;
                lock_dice5 = false;
                die5.BackColor = Color.White;
            }
            Random rng = new Random();
            if (lock_dice1 == false)
            {
                int number1 = rng.Next(1, 7);
                die1.Text = number1.ToString();
            }
            if (lock_dice2 == false)
            {
                int number2 = rng.Next(1, 7);
                die2.Text = number2.ToString();
            }
            if (lock_dice3 == false)
            {
                int number3 = rng.Next(1, 7);
                die3.Text = number3.ToString();
            }
            if (lock_dice4 == false)
            {
                int number4 = rng.Next(1, 7);
                die4.Text = number4.ToString();
            }
            if (lock_dice5 == false)
            {
                int number5 = rng.Next(1, 7);
                die5.Text = number5.ToString();
            }
            if (amountrolls == 0)
            {
                List<int> dicerow = new List<int>();
                dicerow.Add(int.Parse(die1.Text));
                dicerow.Add(int.Parse(die2.Text));
                dicerow.Add(int.Parse(die3.Text));
                dicerow.Add(int.Parse(die4.Text));
                dicerow.Add(int.Parse(die5.Text));
                dicerow.Sort();
            }
        }

    }
}
