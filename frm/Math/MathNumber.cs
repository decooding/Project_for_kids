using System.Media;
using System.Windows.Forms;
using WinApp.frm;

namespace Project_for_kids.frm.Math
{
    public partial class MathNumber : Form
    {
        private SoundPlayer soundPlayer;

        public MathNumber()
        {
            InitializeComponent();
            SetTransparentPictures(this);

        }

        private void SetTransparentPictures(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is PictureBox)
                {
                    PictureBox picture = (PictureBox)ctrl;
                    picture.BackColor = Color.Transparent;
                    picture.BorderStyle = BorderStyle.None;
                }
            }
        }

        void FunCallSound(string soundName)
        {
            string soundFilePath = $@"G:\Project_for_kids\resource\sound\san\{soundName}.wav";
            soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 secwin = new();
            this.Hide();
            secwin.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FunCallSound("1");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FunCallSound("2");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FunCallSound("3");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FunCallSound("4");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FunCallSound("5");

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FunCallSound("6");

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FunCallSound("7");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FunCallSound("8");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FunCallSound("9");

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FunCallSound("10");

        }

    }
}
