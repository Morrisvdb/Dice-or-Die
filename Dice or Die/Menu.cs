using AxWMPLib;
using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Dice_or_Die
{
    public partial class Menu : Form
    {
        public int sound_volume = 50; // Default volume level - Can be changed in setting, will revert after game restart
        public int music_volume = 30; // Default music volume level - Can be changed in setting, will revert after game restart
        
        public Menu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);
            game.Show();
            this.Hide();
            FadeOutMusic(100, musicPlayer);
            PlayTrackWithFadeIn(new MemoryStream(Resource1.battle_music), musicPlayer, 100, music_volume); // Play the battle music with fade-in effect
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help(this);
            help.Show();
            this.Hide();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetGameButton_Click(object sender, EventArgs e)
        {
            Game game = new Game(this);
            game.reset_save();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            PlayStreamWithWMP(Resource1.menu_music, musicPlayer);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void PlayStreamWithWMP(Stream audioStream, AxWindowsMediaPlayer player)
        {
            string tempFile = Path.GetTempFileName() + ".wav";
            using (var fileStream = File.Create(tempFile))
            {
                audioStream.Seek(0, SeekOrigin.Begin);
                audioStream.CopyTo(fileStream);
            }

            player.URL = tempFile;
            player.Ctlcontrols.play();
        }

        public void FadeOutMusic(int fadeDuration, AxWindowsMediaPlayer player) // Duration in ms
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                for (int i = player.settings.volume; i >= 0; i -= 10)
                {
                    player.settings.volume = i;
                    System.Threading.Thread.Sleep(fadeDuration / 10);
                }
                player.Ctlcontrols.stop();
            }
        }

        public void PlayTrackWithFadeIn(Stream audioStream, AxWindowsMediaPlayer player, int fadeDuration = 1000, int volume = 50) // Duration in ms
        {
            PlayStreamWithWMP(audioStream, player);
            for (int i = 0; i <= volume; i += 10)
            {
                musicPlayer.settings.volume = i;
                System.Threading.Thread.Sleep(fadeDuration / 10);
            }
        }

    }
}
