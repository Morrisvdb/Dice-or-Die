using Microsoft.VisualBasic.Devices;

namespace Dice_or_Die
{
    public partial class Menu : Form
    {
        public int sound_volume = 50; // Default volume level - Can be changed in setting, will revert after game restart
        public int music_volume = 50; // Default music volume level - Can be changed in setting, will revert after game restart
        public Menu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
            FadeOutMusic(1000);
            PlayTrackWithFadeIn(new MemoryStream(Resource1.battle_music), 1000, music_volume); // Play the battle music with fade-in effect
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetGameButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.reset_save();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            PlayStreamWithWMP(Resource1.menu_music);
        } 

        public void PlayStreamWithWMP(Stream audioStream)
        {
            string tempFile = Path.GetTempFileName() + ".wav";
            using (var fileStream = File.Create(tempFile))
            {
                audioStream.Seek(0, SeekOrigin.Begin);
                audioStream.CopyTo(fileStream);
            }

            axWindowsMediaPlayer1.URL = tempFile;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        public void FadeOutMusic(int fadeDuration) // Duration in ms
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                for (int i = axWindowsMediaPlayer1.settings.volume; i >= 0; i -= 10)
                {
                    axWindowsMediaPlayer1.settings.volume = i;
                    System.Threading.Thread.Sleep(fadeDuration / 10);
                }
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }

        public void PlayTrackWithFadeIn(Stream audioStream, int fadeDuration = 1000, int volume = 50) // Duration in ms
        {
            PlayStreamWithWMP(audioStream);
            for (int i = 0; i <= volume; i += 10)
            {
                axWindowsMediaPlayer1.settings.volume = i;
                System.Threading.Thread.Sleep(fadeDuration / 10);
            }
        }

    }
}
