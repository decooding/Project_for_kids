using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace Project_for_kids.data
{
    public class Auth
    {
        public static class GFold
        {
            public static string GPath = @"G:\Project_for_kids\";
        }

        public static int Id { get; set; }
        public static string? Username { get; set; }
        public static string? Password { get; set; }
        public static int MathBall { get; set; }
        public static int LetterBall { get; set; }

        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=base.accdb";

        private Stopwatch stopwatch;
        private SoundPlayer soundPlayer;

        public void StartTimer()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public int SeeTestBall()
        {
            int currentValue = 0;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT [All_res] FROM [Result] WHERE [id_res] = ?";
                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Id", Id);

                        object currentScore = selectCommand.ExecuteScalar();

                        currentValue = (currentScore != DBNull.Value) ? Convert.ToInt32(currentScore) : 0;
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message);
            }
            return currentValue;
        }

        public void SaveTestResults(int score, string table)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = $"SELECT [{table}] FROM [Result] WHERE [id_res] = ?";
                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@p1", Id);
                        object currentScore = selectCommand.ExecuteScalar();

                        int currentValue = (currentScore != DBNull.Value) ? Convert.ToInt32(currentScore) : 0;

                        int newScore = currentValue + score;

                        string updateQuery = $"UPDATE [Result] SET [{table}] = ? WHERE [id_res] = ?";
                        using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@p1", newScore);
                            updateCommand.Parameters.AddWithValue("@p2", Id);

                            int rowsAffected = updateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                stopwatch.Stop();
                                TimeSpan elapsed = stopwatch.Elapsed;
                                soundPlayer = new SoundPlayer(@$"{GFold.GPath}resource\sound\finish.wav");
                                soundPlayer.Play();
                                MessageBox.Show($"Құттықтайм!\n Барлық тапсырманы сәтті өттіңіз\n Орындау уақыты: {elapsed:mm\\:ss}");
                                stopwatch.Reset();
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
