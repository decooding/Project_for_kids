using Project_for_kids.data;
using Project_for_kids.frm.panel;
using WinApp.frm.panel;

namespace Project_for_kids
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Auth auth = new Auth();

            if (Auth.Id != 0)
            {
                label1.Text = @$"Ұпай: {auth.SeeTestBall()}"; 
            }
            else
            {
                MessageBox.Show("Id пользователя не установлено.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel logiform = new();
            logiform.Show();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReadingForm dengei1 = new();
            dengei1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MathForm dengei3 = new();
            dengei3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Helper dengei4 = new();
            dengei4.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LetterForm letterForm = new();
            letterForm.Show();
            this.Hide();
        }
    }
}
