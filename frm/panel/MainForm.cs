using Program_for_kids.frm;
using Project_for_kids.frm.Video;
using WinApp.frm;
using WinApp.frm.Login;
using WinApp.frm.panel;
using WinFormsApp1;

namespace Project_for_kids
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 matform = new();
            this.Hide();
            matform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 secWin = new();
            this.Hide();
            secWin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new();
            panel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogIn logiform = new();
            logiform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VideoPanel videopanel = new();
            this.Hide();
            videopanel.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
