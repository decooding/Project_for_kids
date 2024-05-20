using Project_for_kids;
using Project_for_kids.frm.panel;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextChanged -= textBox1_TextChanged;
            GFold.GPath = textBox1.Text;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int userId))
            {
                AdminSubPanel panel = new AdminSubPanel(userId);
                panel.Show();
            }
            else
            {
                MessageBox.Show("Введите корректный идентификатор.");
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string userQuery = "SELECT * FROM [User] WHERE [id] = ?";
                    OleDbCommand userCommand = new OleDbCommand(userQuery, connection);
                    userCommand.Parameters.AddWithValue("@ID", id);

                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(userCommand);
                    DataTable userDataTable = new DataTable();
                    userAdapter.Fill(userDataTable);

                    string resultQuery = "SELECT * FROM [Result] WHERE [id_res] = ?";
                    OleDbCommand resultCommand = new OleDbCommand(resultQuery, connection);
                    resultCommand.Parameters.AddWithValue("@ID", id);

                    OleDbDataAdapter resultAdapter = new OleDbDataAdapter(resultCommand);
                    DataTable resultDataTable = new DataTable();
                    resultAdapter.Fill(resultDataTable);

                    if (userDataTable.Rows.Count > 0 || resultDataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = userDataTable;
                        dataGridView2.DataSource = resultDataTable;
                    }
                    else
                    {
                        MessageBox.Show("No records found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void deletebtn_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string deleteResultQuery = "DELETE FROM [Result] WHERE [id_res] = ?";
                    OleDbCommand deleteResultCommand = new OleDbCommand(deleteResultQuery, connection);
                    deleteResultCommand.Parameters.AddWithValue("@ID", id);
                    int resultRows = deleteResultCommand.ExecuteNonQuery();

                    string deleteUserQuery = "DELETE FROM [User] WHERE [id] = ?";
                    OleDbCommand deleteUserCommand = new OleDbCommand(deleteUserQuery, connection);
                    deleteUserCommand.Parameters.AddWithValue("@ID", id);
                    int userRows = deleteUserCommand.ExecuteNonQuery();

                    if (userRows > 0 && resultRows > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        LoadDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No records found to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            ExportDataToTxt("exportedData.txt");
        }

        private void ExportDataToTxt(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(Path.Combine(GFold.GPath, fileName)))
            {
                // Экспорт данных из таблицы UserTable
                if (userDataSet.Tables.Contains("UserTable"))
                {
                    DataTable userTable = userDataSet.Tables["UserTable"];
                    writer.WriteLine("User Table Data:");
                    foreach (DataColumn column in userTable.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    foreach (DataRow row in userTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            writer.Write(item.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                    writer.WriteLine(); // Добавить пустую строку между таблицами
                }
                else
                {
                    writer.WriteLine("User Table not found.");
                }

                // Экспорт данных из таблицы ResultTable
                if (resultDataSet.Tables.Contains("ResultTable"))
                {
                    DataTable resultTable = resultDataSet.Tables["ResultTable"];
                    writer.WriteLine("Result Table Data:");
                    foreach (DataColumn column in resultTable.Columns)
                    {
                        writer.Write(column.ColumnName + "\t");
                    }
                    writer.WriteLine();

                    foreach (DataRow row in resultTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            writer.Write(item.ToString() + "\t");
                        }
                        writer.WriteLine();
                    }
                }
                else
                {
                    writer.WriteLine("Result Table not found.");
                }
            }

            MessageBox.Show($"Data exported to {fileName}");
        }

    }
}
