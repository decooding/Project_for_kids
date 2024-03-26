using System.Data.OleDb;

namespace WinApp.frm.Login
{
    public partial class SigIn : Form
    {
        public SigIn()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = fname.Text;
            string lastname = lname.Text;
            int userage;

            if (!int.TryParse(age.Text, out userage))
            {
                MessageBox.Show("Тіркелуші жасын дұрыс енгізіңіз.");
                return;
            }

            string userlogin = login.Text;
            string userpassword = password.Text;

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO [User] ([Login], [FirstName], [LastName], [Age], [Password]) VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@p1", userlogin);
                        command.Parameters.AddWithValue("@p2", firstname);
                        command.Parameters.AddWithValue("@p3", lastname);
                        command.Parameters.AddWithValue("@p4", userage);
                        command.Parameters.AddWithValue("@p5", userpassword);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Қолданушы сәтті тіркелді.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
