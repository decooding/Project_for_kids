using Program_for_kids.frm;
using Project_for_kids.data;
using Project_for_kids.frm.Letter;
using Project_for_kids.frm.Math;
using Project_for_kids.frm.panel;
using Project_for_kids.frm.Video;
using Uniclo.frm;
using WinApp.frm;
using WinApp.frm.panel;
using static Project_for_kids.data.Auth;


namespace Project_for_kids
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            Auth auth = new Auth(); 

            // Проверяем, установлено ли значение Id
            if (Auth.Id != 0)
            {
                label1.Text = @$"Ұпай: {auth.SeeTestBall()}"; // Вызов метода SeeTestBall() через экземпляр auth
            }
            else
            {
                // Выводим сообщение об ошибке, если Id не установлено
                MessageBox.Show("Id пользователя не установлено.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Alphabet matform = new();
            this.Hide();
            matform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MathNumber secWin = new();
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
            AdminPanel logiform = new();
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

        private void button7_Click(object sender, EventArgs e)
        {
            MathCount dengei1 = new();
            dengei1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MathLess dengei2 = new();
            dengei2.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MathMore dengei3 = new();
            dengei3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MathRow dengei4 = new();
            dengei4.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Adder dengei5 = new();
            dengei5.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Matin dengei6 = new();
            dengei6.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Helper helper = new();
            helper.Show();
        }
    }
}
