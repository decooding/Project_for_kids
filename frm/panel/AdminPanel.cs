using Project_for_kids;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

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

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // Сохраняем изменения таблицы пользователей
                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(userSelectCommand);
                    OleDbCommandBuilder userCommandBuilder = new OleDbCommandBuilder(userAdapter);
                    userAdapter.SelectCommand.Connection = connection;
                    userAdapter.Update(userDataSet, "UserTable");

                    // Сохраняем изменения таблицы результатов
                    OleDbDataAdapter resultAdapter = new OleDbDataAdapter(resultSelectCommand);
                    OleDbCommandBuilder resultCommandBuilder = new OleDbCommandBuilder(resultAdapter);
                    resultAdapter.SelectCommand.Connection = connection;
                    resultAdapter.Update(resultDataSet, "ResultTable");

                    MessageBox.Show("Изменения сохранены успешно.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении изменений: " + ex.Message);
            }
        }
    }
}
