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
            MainForm main = new();
            MediaPlayer1.close();
            this.Hide();
            main.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer1.URL = "G:\\Project_for_kids\\resource\\video\\1.mp4";
            MediaPlayer1.Ctlcontrols.play();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer1.URL = "G:\\Project_for_kids\\resource\\video\\2.mp4";
            MediaPlayer1.Ctlcontrols.play();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer1.URL = "G:\\Project_for_kids\\resource\\video\\3.mp4";
            MediaPlayer1.Ctlcontrols.play();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.stop();
            MediaPlayer1.URL = "G:\\Project_for_kids\\resource\\video\\4.mp4";
            MediaPlayer1.Ctlcontrols.play();
        }

    }
}
