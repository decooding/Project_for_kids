using Project_for_kids;
using System.Data;
using System.Data.OleDb;

namespace WinApp.frm.panel
{
    public partial class AdminPanel : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";
        private OleDbCommand userSelectCommand;
        private OleDbCommand resultSelectCommand;
        private DataSet userDataSet;
        private DataSet resultDataSet;

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    userSelectCommand = new OleDbCommand("SELECT * FROM [User]", connection);
                    resultSelectCommand = new OleDbCommand("SELECT * FROM [request]", connection);

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

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string firstname = firstnameTextBox.Text;
            string lastname = lastnameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);

            try
            {
                // Создаем подключение к базе данных
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    // SQL-запрос для обновления данных
                    string query = "UPDATE [User] SET [Login] = ?, [Password] = ?, [Firstname] = ?, [Lastname] = ?, [Age] = ? WHERE [id] = ?";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Параметризованный запрос для предотвращения SQL инъекций
                        command.Parameters.AddWithValue("@p1", login);
                        command.Parameters.AddWithValue("@p2", password);
                        command.Parameters.AddWithValue("@p3", firstname);
                        command.Parameters.AddWithValue("@p4", lastname);
                        command.Parameters.AddWithValue("@p5", age);
                        command.Parameters.AddWithValue("@p6", id);

                        // Выполняем запрос
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

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }
    }
}