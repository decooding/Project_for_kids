using Project_for_kids;
using Project_for_kids.frm.Letter;
using Project_for_kids.frm.Math;


namespace WinApp.frm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alphabet secwin2 = new();
            this.Hide();
            secwin2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adder adder = new();
            this.Hide();
            adder.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matin matin = new();
            this.Hide();
            matin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MathNumber number = new();
            this.Hide();
            number.Show();
        }
    }
}
