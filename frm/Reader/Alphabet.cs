using Project_for_kids;
using Project_for_kids.frm.panel;
using System.Media;
using static Project_for_kids.data.Auth;

namespace WinApp.frm
{
    public partial class Alphabet : Form
    {
        private SoundPlayer? soundPlayer;


        public Alphabet()
        {
            InitializeComponent();
        }

        void FunCallSound(string soundName)
        {
            string soundFilePath = @$"{GFold.GPath}resource\sound\alippe\{soundName}.wav";
            soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReadingForm form3 = new();
            this.Close();
            form3.Show();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            FunCallSound("А");
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            FunCallSound("Ә");

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            FunCallSound("Б");

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            FunCallSound("В");

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            FunCallSound("Г");

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            FunCallSound("Ғ");
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            FunCallSound("Д");
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            FunCallSound("Е");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            FunCallSound("Ё");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            FunCallSound("Ж");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            FunCallSound("З");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            FunCallSound("И");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            FunCallSound("Й");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            FunCallSound("К");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            FunCallSound("Қ");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            FunCallSound("Л");
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            FunCallSound("М");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            FunCallSound("Ң");
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            FunCallSound("О");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            FunCallSound("Ө");
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            FunCallSound("П");
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            FunCallSound("Р");
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            FunCallSound("С");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FunCallSound("Т");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            FunCallSound("У");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            FunCallSound("Ұ");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            FunCallSound("Ү");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            FunCallSound("Ф");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            FunCallSound("Х");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FunCallSound("Һ");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            FunCallSound("Ц");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FunCallSound("Ч");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FunCallSound("Ш");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FunCallSound("Щ");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FunCallSound("Ы");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FunCallSound("І");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FunCallSound("Э");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FunCallSound("Ю");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FunCallSound("Я");
        }
    }
}
