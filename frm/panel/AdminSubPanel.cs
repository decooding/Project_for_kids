using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project_for_kids.frm.panel
{
    public partial class AdminSubPanel : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";
        private readonly int userId;

        public AdminSubPanel(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM [User] INNER JOIN [Result] ON [User].[id] = [Result].[id_res] WHERE [User].[id] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", userId);
                        OleDbDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            loginTextBox.Text = reader["Login"].ToString();
                            passwordTextBox.Text = reader["Password"].ToString();
                            firstnameTextBox.Text = reader["Firstname"].ToString();
                            lastnameTextBox.Text = reader["Lastname"].ToString();
                            ageTextBox.Text = reader["Age"].ToString();
                            idUserTextBox.Text = reader["id_res"].ToString();
                            MathTextBox.Text = reader["Math_res"].ToString();
                            LetterTextBox.Text = reader["Letter_res"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void updateUserDataBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string firstname = firstnameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [User] SET [Login] = ?, [Password] = ?, [Firstname] = ?, [Lastname] = ?, [Age] = ? WHERE [id] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", login);
                        command.Parameters.AddWithValue("@p2", password);
                        command.Parameters.AddWithValue("@p3", firstname);
                        command.Parameters.AddWithValue("@p4", lastname);
                        command.Parameters.AddWithValue("@p5", age);
                        command.Parameters.AddWithValue("@p6", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить данные");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void updateResultDataBtn_Click(object sender, EventArgs e)
        {
            int mathRes = Convert.ToInt32(MathTextBox.Text);
            int letterRes = Convert.ToInt32(LetterTextBox.Text);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [Result] SET [Math_res] = ?, [Letter_res] = ? WHERE [id_res] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", mathRes);
                        command.Parameters.AddWithValue("@p2", letterRes);
                        command.Parameters.AddWithValue("@p3", userId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены");
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить данные");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
