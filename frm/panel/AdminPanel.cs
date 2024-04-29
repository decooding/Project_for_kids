using Project_for_kids;
using System.Data;
using System.Data.OleDb;
using static Project_for_kids.data.Auth;

namespace WinApp.frm.panel
{
    public partial class AdminPanel : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";
        private OleDbCommand userSelectCommand;
        private OleDbCommand resultSelectCommand;
        private DataSet userDataSet;
        private DataSet resultDataSet;

        public AdminPanel() => InitializeComponent();

        public void LoadDataTable()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    userSelectCommand = new OleDbCommand("SELECT * FROM [User]", connection);
                    resultSelectCommand = new OleDbCommand("SELECT * FROM [Result]", connection);

                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(userSelectCommand);
                    OleDbDataAdapter resultAdapter = new OleDbDataAdapter(resultSelectCommand);

                    userDataSet = new DataSet();
                    resultDataSet = new DataSet();

                    userAdapter.Fill(userDataSet, "UserTable");
                    resultAdapter.Fill(resultDataSet, "ResultTable");

                    dataGridView1.DataSource = userDataSet.Tables["UserTable"];
                    dataGridView2.DataSource = resultDataSet.Tables["ResultTable"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadDataTable();
            textBox1.Text = GFold.GPath;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
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
                        command.Parameters.AddWithValue("@p6", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены");
                            LoadDataTable();
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
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            int math_res = Convert.ToInt32(MathTextBox.Text);
            int letter_res = Convert.ToInt32(LetterTextBox.Text);

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [Result] SET [Math_res] = ?, [Letter_res] = ? WHERE [id_res] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@p1", math_res);
                        command.Parameters.AddWithValue("@p2", letter_res);
                        command.Parameters.AddWithValue("@p3", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены");
                            LoadDataTable();
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

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (idTextBox.Text == "")
                    {
                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";
                        firstnameTextBox.Text = "";
                        lastnameTextBox.Text = "";
                        ageTextBox.Text = "";
                        idUserTextBox.Text = "";
                        MathTextBox.Text = "";
                        LetterTextBox.Text = "";
                    }
                    else
                    {
                        string query = "SELECT * FROM [User] INNER JOIN [Result] ON [User].[id] = [Result].[id_res] WHERE [User].[id] = ?";

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@p1", idTextBox.Text);

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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextChanged -= textBox1_TextChanged;
            GFold.GPath = textBox1.Text;
            textBox1.TextChanged += textBox1_TextChanged;
        }
    }
}