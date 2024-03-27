using System.Data.OleDb;
namespace Project_for_kids.data
{
    public class Auth
    {
        public static int Id { get; set; }
        public static string ?Username { get; set; }
        public static string ?Password { get; set; }
        public static int MathBall { get; set; }
        public static int LetterBall { get; set; }

        public string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

        public void SaveTestResults(int score, string table)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Получить текущее значение из базы данных
                    string selectQuery = $"SELECT [{table}] FROM [Result] WHERE [id_res] = ?";
                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p1", Id);
                        object currentScore = selectCommand.ExecuteScalar();

                        // Проверяем, не является ли текущее значение null
                        int currentValue = (currentScore != DBNull.Value) ? Convert.ToInt32(currentScore) : 0;

                        // Выполнить операцию суммирования
                        int newScore = currentValue + score;

                        // Обновить значение в базе данных
                        string updateQuery = $"UPDATE [Result] SET [{table}] = ? WHERE [id_res] = ?";
                        using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@p1", newScore);
                            updateCommand.Parameters.AddWithValue("@p2", Id);

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Результаты теста успешно сохранены");
                            }
                            else
                            {
                                MessageBox.Show("Не удалось сохранить результаты теста");
                            }
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
