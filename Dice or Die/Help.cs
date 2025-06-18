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
        public Help()
        {
            InitializeComponent();
        }

        int page_number = 1;
        private void next_button_Click(object sender, EventArgs e)
        {
            page_number++;
            if (page_number == 1)
            {
                Title_label.Text = "Contents";
                explanation_label.Text = "1.  Gameplay Overview\r\n2.  Rules\r\n3.  Upper Section\r\n4.  Lower Section\r\n5.  Shop";
            }
            if (page_number == 2)
            {
                Title_label.Text = "Gameplay Overview";
                explanation_label.Text = "";
            }
            if (page_number == 3)
            {
                Title_label.Text = "Rules";
                explanation_label.Text = "";
            }
            if (page_number == 4)
            {
                Title_label.Text = "Upper_section";
                explanation_label.Text = "";
            }
            if (page_number == 1)
            {
                Title_label.Text = "Lower Section";
                explanation_label.Text = "";
            }
            if (page_number == 1)
            {
                Title_label.Text = "Shop";
                explanation_label.Text = "";
            }
        }
    }
}
