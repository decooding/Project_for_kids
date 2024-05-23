using Project_for_kids.frm.panel;
using static Project_for_kids.data.Auth;

namespace Project_for_kids.frm.Video
{
    public partial class VideoPanel : Form
    {
        public VideoPanel()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReadingForm main = new();
            MediaPlayer1.close();
            this.Hide();
            main.Show();
        }

        private void soundVideoPanel(string val)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer1.URL = @$"{GFold.GPath}resource\\video\\{val}.mp4";
            MediaPlayer1.Ctlcontrols.play();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            soundVideoPanel("1");
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            soundVideoPanel("2");

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            soundVideoPanel("3");

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            soundVideoPanel("4");

        }

    }
}
