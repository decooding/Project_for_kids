using Project_for_kids;
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
            string soundFilePath = @$"{GFold.GPath}resource\sound\alphabet\{soundName}.wav";
            soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form3 = new();
            this.Hide();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FunCallSound("А");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FunCallSound("Ә");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FunCallSound("Б");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FunCallSound("В");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FunCallSound("Г");

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FunCallSound("Ғ");

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FunCallSound("Д");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            FunCallSound("Е");

        }

        private void label9_Click(object sender, EventArgs e)
        {
            FunCallSound("Ё");

        }

        private void label10_Click(object sender, EventArgs e)
        {
            FunCallSound("Ж");

        }

        private void label11_Click(object sender, EventArgs e)
        {
            FunCallSound("З");

        }

        private void label12_Click(object sender, EventArgs e)
        {
            FunCallSound("И");

        }

        private void label13_Click(object sender, EventArgs e)
        {
            FunCallSound("Й");

        }

        private void label14_Click(object sender, EventArgs e)
        {
            FunCallSound("К");

        }

        private void label15_Click(object sender, EventArgs e)
        {
            FunCallSound("Қ");

        }

        private void label16_Click(object sender, EventArgs e)
        {
            FunCallSound("Л");

        }

        private void label17_Click(object sender, EventArgs e)
        {
            FunCallSound("М");

        }

        private void label18_Click(object sender, EventArgs e)
        {
            FunCallSound("Н");

        }

        private void label19_Click(object sender, EventArgs e)
        {
            FunCallSound("Ң");

        }

        private void label20_Click(object sender, EventArgs e)
        {
            FunCallSound("О");

        }

        private void label21_Click(object sender, EventArgs e)
        {
            FunCallSound("Ө");

        }

        private void label22_Click(object sender, EventArgs e)
        {
            FunCallSound("П");

        }

        private void label23_Click(object sender, EventArgs e)
        {
            FunCallSound("Р");

        }

        private void label24_Click(object sender, EventArgs e)
        {
            FunCallSound("С");

        }

        private void label25_Click(object sender, EventArgs e)
        {
            FunCallSound("Т");

        }

        private void label26_Click(object sender, EventArgs e)
        {
            FunCallSound("У");

        }

        private void label27_Click(object sender, EventArgs e)
        {
            FunCallSound("Ұ");

        }

        private void label28_Click(object sender, EventArgs e)
        {
            FunCallSound("Ү");

        }

        private void label29_Click(object sender, EventArgs e)
        {
            FunCallSound("Ф");

        }

        private void label30_Click(object sender, EventArgs e)
        {
            FunCallSound("Х");

        }

        private void label31_Click(object sender, EventArgs e)
        {
            FunCallSound("Ц");

        }

        private void label32_Click(object sender, EventArgs e)
        {
            FunCallSound("Ч");

        }

        private void label33_Click(object sender, EventArgs e)
        {
            FunCallSound("Ш");

        }

        private void label34_Click(object sender, EventArgs e)
        {
            FunCallSound("Щ");

        }

        private void label35_Click(object sender, EventArgs e)
        {
            FunCallSound("Ы");

        }

        private void label36_Click(object sender, EventArgs e)
        {
            FunCallSound("І");

        }

        private void label40_Click(object sender, EventArgs e)
        {
            FunCallSound("Һ");

        }

        private void label37_Click(object sender, EventArgs e)
        {
            FunCallSound("Э");

        }

        private void label38_Click(object sender, EventArgs e)
        {
            FunCallSound("Ю");

        }

        private void label39_Click(object sender, EventArgs e)
        {
            FunCallSound("Я");

        }
    }
}
