using Project_for_kids;
using Project_for_kids.data;
using System.Data;
using System.Data.OleDb;
using WinApp.frm.panel;

namespace WinApp.frm.Login
{
    public partial class LogIn : Form
    {
        private OleDbConnection connection; // Объявляем поле для соединения

        public LogIn()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";
            connection = new OleDbConnection(connectionString); // Инициализируем соединение в конструкторе
        }

        private void AuthenticateUser(string username, string password)
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT [id] FROM [User] WHERE Login = ? AND Password = ?";
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Login", username);
                    command.Parameters.AddWithValue("@Password", password);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["id"]);
                        Auth.Id = userId;
                        Auth.Username = username;
                        Auth.Password = password;

                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else if (username == "admin" && password == "admin")
                    {
                        AdminPanel panel = new AdminPanel();
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
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            AuthenticateUser(username, password);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SigIn signIn = new SigIn();
            this.Hide();
            signIn.Show();
            connection.Close();

        }
    }
}
