using System;
using System.Data.OleDb;
using System.Windows.Forms;

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

            // Проверка на наличие данных перед выполнением запроса
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) ||
                string.IsNullOrEmpty(userlogin) || string.IsNullOrEmpty(userpassword))
            {
                MessageBox.Show("Барлық мәліметтерді енгізіңіз.");
                return;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertUserQuery = @"INSERT INTO [User] ([Login], [FirstName], [LastName], [Age], [Password]) 
                                               VALUES (?, ?, ?, ?, ?)";

                    string getUserIdQuery = @"SELECT [id] FROM [User] WHERE [Login] = ?";

                    string insertResultQuery = @"INSERT INTO [Result] ([id_res], [Math_res], [Letter_res]) 
                                                 VALUES (?, 0, 0)";

                    using (OleDbCommand command = new OleDbCommand(insertUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@p1", userlogin);
                        command.Parameters.AddWithValue("@p2", firstname);
                        command.Parameters.AddWithValue("@p3", lastname);
                        command.Parameters.AddWithValue("@p4", userage);
                        command.Parameters.AddWithValue("@p5", userpassword);

                        command.ExecuteNonQuery();
                    }

                    // Получение идентификатора вновь добавленного пользователя
                    int userId;
                    using (OleDbCommand command = new OleDbCommand(getUserIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@p1", userlogin);
                        object result = command.ExecuteScalar();
                        userId = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }

                    // Вставка начальных результатов в таблицу Result
                    if (userId > 0)
                    {
                        using (OleDbCommand command = new OleDbCommand(insertResultQuery, connection))
                        {
                            command.Parameters.AddWithValue("@p1", userId);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Қолданушы сәтті тіркелді.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось получить идентификатор пользователя.");
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
