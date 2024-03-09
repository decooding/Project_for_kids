using Project_for_kids;
using Program_for_kids.frm;
using Uniclo.frm;
using WinApp.frm;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new();
            this.Hide();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathCount mathcount = new();
            this.Hide();
            mathcount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathRow mathrow = new();
            this.Hide();
            mathrow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MathMore mathmore = new();
            this.Hide();
            mathmore.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MathLess mathless = new();
            this.Hide();
            mathless.Show();
        }
    }
}
