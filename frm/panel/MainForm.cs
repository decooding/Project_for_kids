using Program_for_kids.frm;
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
            SecWin2 secWin2 = new SecWin2();
            this.Hide();
            secWin2.Show();
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
    }
}
