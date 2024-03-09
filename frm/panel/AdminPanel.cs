using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WinApp.frm.panel
{
    public partial class AdminPanel : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

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

                    OleDbCommand userSelectCommand = new("SELECT * FROM [User]", connection);
                    OleDbCommand resultSelectCommand = new("SELECT * FROM [result]", connection);

                    OleDbDataAdapter userAdapter = new(userSelectCommand);
                    OleDbDataAdapter resultAdapter = new(resultSelectCommand);

                    DataSet userDataSet = new();
                    DataSet resultDataSet = new();

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
    }
}
