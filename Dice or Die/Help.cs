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
    public partial class Help : Form
    {
        private Menu menu;
        public Help(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        int page_number = 1;
        private void next_button_Click(object sender, EventArgs e)
        {
            page_number++;
            flip_page(page_number);
            if (page_number == 6)
            {
                next_button.Enabled = false;
            }
            if (page_number == 2)
            {
                back_button.Enabled = true;
            }
        }

        private void flip_page(int page_number)
        {
            if (page_number == 1)
            {
                Title_label.Text = "Contents";
                explanation_label.Text = "1.  Gameplay Overview\r\n2.  Rules\r\n3.  Upper Section\r\n4.  Lower Section\r\n5.  Shop";
            }
            if (page_number == 2)
            {
                Title_label.Text = "Gameplay Overview";
                explanation_label.Text = "Start with 10 HP \r\nRoll 5 dices \r\nChoose your dices and reroll up to 3 times total \r\nPerform actions based on your dice roll to: \r\n    Attack \r\n    Defend \r\n    Clever Move \r\n\r\nOptionally, buy items from the Shop \r\n\r\nEnd of turn \r\nThe game ends when:  \r\n    A player reaches 0 HP \r\n    All upper and lower section moves are used \r\n    The player with the most HP wins";
            }
            if (page_number == 3)
            {
                Title_label.Text = "Rules";
                explanation_label.Text = "Defense cannot pass the maximum of 10 HP (unless the maximum is increased by the Vitality Stone) \r\n\r\nDefense can be stacked (it is added to the total of the HP) \r\n\r\nA player may never roll more than 6 dices at once \r\n    If the player still chooses for the LG Straight while having 6 dices equipped, \r\n    the player will be rewarded with 6 coins.  \r\n\r\nIf a player rolls a SM Straight, their opponent loses 1 dice for their next turn (the opponent may roll 4 dices instead \r\nof 5 for one round, or 5 instead of 6 until the player rolls and LG Straight again). This effect does not stack. \r\n\r\nThe damage from an Attack is applied after the opponent’s next turn to give a chance to defend. \r\n\r\nAt the end of your turn, you gain coins equal to the sum of your dices if you chose an attack from the Lower Section \r\n    When you choose an action from the Upper Section: obtain twice the amount of coins for the chosen number. ";
            }
            if (page_number == 4)
            {
                Title_label.Text = "Upper Section";
                explanation_label.Text = "Aces                    +2 coins for every ace\r\nTwos                   +4 coins for every two\r\nThrees                 +6 coins for every three\r\nFours                   +8 coins for every four\r\nFives                    +10 coins for every five\r\nSixes                    +12 coins for every six\r\n\r\nIf total upper score is 63 or over: receive + 100 coins. \r\n\r\nTotal: \r\n21 =<  : + 5 coins\r\n42 =<  : + 10 coins\r\n63    <  : +  15 coins";
            }
            if (page_number == 5)
            {
                Title_label.Text = "Lower Section";
                explanation_label.Text = "D      Pair                           Add 2 health\r\nA      3 of a kind               Deal 3 damage to opponent\r\nA      4 of a kind               Deal 5 damage to opponent\r\nD      Full house                Add 4 health\r\nC      Small Straight          Takes one of the opponent's dice away\r\nC      Large Straight          Extra dice / 6 coins if already an extra dice equipped\r\nA      Yathzee                     Deal 9 damage to opponent\r\nD      Chance                     Recieve 1.5x the amount of coins\r\n\r\nD : Defense  \r\nA : Attack \r\nC : Clever move ";
            }
            if (page_number == 6)
            {
                Title_label.Text = "Shop";
                explanation_label.Text = "Use coins to buy powerful items:\r\n\r\nSurvivor’s Grace                     Add 4 HP (can’t pass the max HP) \r\nDouble Strike                          Next attack deals double damage \r\nVitality Stone                          Increases max HP by 2 (12 HP instead of 10 HP) + 2 HP is added to the current health \r\nEarth Guard                            If you roll a pair, your defense blocks 3 damage instead of 2 for the whole game. \r\nBlade of Fate                          Does an attack of 3 damage \r\nThe Guardian’s barrier          Blocks all damage for the next 2 turns ";
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            page_number--;
            flip_page(page_number);
            if (page_number == 1)
            {
                back_button.Enabled = false;
            }
            if (page_number == 5)
            {
                next_button.Enabled = true;
            }
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            back_button.Enabled = false;
        }

        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Close();
        }
    }
}
