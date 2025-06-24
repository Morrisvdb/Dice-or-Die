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
    public partial class Settings : Form
    {
        public Menu menu;
        public Settings(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        bool music_on = true;
        bool effect_on = true;
        int sound_value;
        int sound_effect_value;
        private void music_sound_button_Click(object sender, EventArgs e)
        {
            if (music_on == true)
            {
                music_on = false;
                music_bar.Enabled = false;
                sound_value = 0;
                music_sound_button.Text = "Sound: off";
            }
            else
            {
                music_on = true;
                music_bar.Enabled = true;
                sound_value = music_bar.Value;
                music_sound_button.Text = "Sound: on";
            }
        }

        private void effect_sound_button_Click(object sender, EventArgs e)
        {
            if (effect_on == true)
            {
                effect_on = false;
                sound_effects_bar.Enabled = false;
                sound_effect_value = 0;
                effect_sound_button.Text = "Sound: off";
            }
            else
            {
                effect_on = true;
                sound_effects_bar.Enabled = true;
                sound_effect_value = sound_effects_bar.Value;
                effect_sound_button.Text = "Sound: on";
            }
        }

        private void music_bar_Scroll(object sender, EventArgs e)
        {
            sound_value = (int)music_bar.Value;
        }

        private void sound_effects_bar_Scroll(object sender, EventArgs e)
        {
            sound_effect_value = (int)sound_effects_bar.Value;
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
    }
}
