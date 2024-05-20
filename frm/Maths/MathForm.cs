using Program_for_kids.frm;
using Project_for_kids.frm.Math;
using Project_for_kids.frm.Maths;
using Uniclo.frm;
using WinApp.frm;

namespace Project_for_kids.frm.panel
{
    public partial class MathForm : Form
    {
        public MathForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MathCount mathCount = new();
            mathCount.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MathMore mathMore = new();
            mathMore.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MathRow mathRow = new();
            mathRow.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MathLess mathLess = new();
            mathLess.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Summer summer = new();
            summer.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            main.Show();
            this.Hide();
        }
    }
}
