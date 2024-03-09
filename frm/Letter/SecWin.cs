using Project_for_kids;


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
            SecWin2 secwin2 = new();
            this.Hide();
            secwin2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form1 = new();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new();
            this.Hide();
            form1.Show();
        }
    }
}
