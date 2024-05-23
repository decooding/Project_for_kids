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
                MessageBox.Show("Database error: " + ex.Message);
            }
            return currentValue;
        }

        public void SaveTestResults(int score, string category, string levelName)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string scoreColumn = category == "Math_res" ? "Math_res" : "letter_res";

                    string selectQuery = $"SELECT [{scoreColumn}] FROM [Result] WHERE [id_res] = ?";
                    int currentScore = 0;
                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@Id", Id);
                        object result = selectCommand.ExecuteScalar();
                        currentScore = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    }

                    int newScore = currentScore + score;
                    string updateQuery = $"UPDATE [Result] SET [{scoreColumn}] = ? WHERE [id_res] = ?";
                    using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@p1", newScore);
                        updateCommand.Parameters.AddWithValue("@p2", Id);
                        updateCommand.ExecuteNonQuery();
                    }

                    stopwatch.Stop();
                    TimeSpan elapsed = stopwatch.Elapsed;
                    string elapsedTime = elapsed.ToString(@"mm\:ss");

                    string insertQuery = "INSERT INTO [lvl] ([user_id], [category_lvl], [name_lvl], [score_lvl], [time_lvl]) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@user_id", Id);
                        insertCommand.Parameters.AddWithValue("@category", category);
                        insertCommand.Parameters.AddWithValue("@level_name", levelName);
                        insertCommand.Parameters.AddWithValue("@score", score);
                        insertCommand.Parameters.AddWithValue("@elapsed_time", elapsedTime);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            soundPlayer = new SoundPlayer($@"{GFold.GPath}resource\sound\finish.wav");
                            soundPlayer.Play();
                            MessageBox.Show($"Құттықтаймын!\n Сіз деңгейді сәтті өттіңіз!\n Өткен уақыт: {elapsed:mm\\:ss}");
                            stopwatch.Reset();
                        }
                        else
                        {
                            MessageBox.Show("Тест қотындысы сақталмады :(");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
