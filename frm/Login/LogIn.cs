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
            // Строка подключения к базе данных Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

            // Создание объекта подключения
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();

                    // Создание SQL-запроса для выборки пользователя по логину и паролю
                    string selectQuery = "SELECT * FROM [User] WHERE Login = ? AND Password = ?";

                    // Создание объекта команды для выполнения запроса
                    using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                    {
                        // Добавление параметров с соответствующими значениями
                        command.Parameters.AddWithValue("@Login", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Выполнение запроса
                        OleDbDataReader reader = command.ExecuteReader();

                        // Проверка наличия пользователя с указанным логином и паролем
                        if (reader.Read())
                        {
                            MessageBox.Show("Авторизация успешна!");
                            Auth.Username = username;
                            Auth.Password = password;

                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else if (username == "admin" && password == "password")
                        {
                            AdminPanel panel = new();
                            panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Вывод сообщения об ошибке
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
