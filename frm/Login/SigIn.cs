using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uniclo.frm;

namespace WinApp.frm.Login
{
    public partial class SigIn : Form
    {
      //  private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\data\base.accdb;Persist Security Info=False;";

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
            int userage = Convert.ToInt32(age.Text);
            string userlogin = login.Text;
            string userpassword = password.Text;

            // Строка подключения к базе данных Access
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

            // Создание объекта подключения
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Открытие подключения
                    connection.Open();

                    // Создание SQL-запроса для вставки данных
                    string insertQuery = "INSERT INTO [User] (Login, FirstName, LastName, Age, Password) VALUES (?, ?, ?, ?, ?)";

                    // Создание объекта команды для выполнения запроса
                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                    {
                        // Добавление параметров с соответствующими значениями
                        command.Parameters.AddWithValue("@Login", userlogin);
                        command.Parameters.AddWithValue("@FirstName", firstname);
                        command.Parameters.AddWithValue("@LastName", lastname);
                        command.Parameters.AddWithValue("@Age", userage);
                        command.Parameters.AddWithValue("@Password", userpassword);

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        MessageBox.Show("Запись успешно добавлена в базу данных.");
                    }
                }
                catch (Exception ex)
                {
                    // Вывод сообщения об ошибке
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
