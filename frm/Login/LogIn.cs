using Project_for_kids;
using Project_for_kids.data;
using System.Data.OleDb;
using WinApp.frm.panel;


namespace WinApp.frm.Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void AuthenticateUser(string username, string password)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM [User] WHERE Login = ? AND Password = ?";
                    using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Login", username);
                        command.Parameters.AddWithValue("@Password", password);

                        OleDbDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            Auth.Username = username;
                            Auth.Password = password;

                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else if (username == "admin" && password == "admin")
                        {
                            AdminPanel panel = new();
                            panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Логин немесе құпиясөз қате!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigIn sigin = new();
            this.Hide();
            sigin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            AuthenticateUser(username, password);
        }
    }
}
