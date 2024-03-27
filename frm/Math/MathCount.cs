using Project_for_kids.data;
using WinFormsApp1;
namespace Uniclo.frm
{
    public partial class MathCount : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
        }
        Auth auth = new Auth();

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 4, ImageName = "balyq4"},
            new Question { CorrectOptionIndex = 3, ImageName = "alma3"},
            new Question { CorrectOptionIndex = 1, ImageName = "ananas1"},
            new Question { CorrectOptionIndex = 5, ImageName = "apelsin5"},
            new Question { CorrectOptionIndex = 1, ImageName = "arbuz1"},
            new Question { CorrectOptionIndex = 2, ImageName = "avacado2"},
            new Question { CorrectOptionIndex = 1, ImageName = "balyq1"},
            new Question { CorrectOptionIndex = 2, ImageName = "cocos2"},
            new Question { CorrectOptionIndex = 5, ImageName = "japyraq5"},
            new Question { CorrectOptionIndex = 5, ImageName = "jidek5"},
            new Question { CorrectOptionIndex = 2, ImageName = "japyraq2"},
            new Question { CorrectOptionIndex = 1, ImageName = "rakushka1"},
            new Question { CorrectOptionIndex = 5, ImageName = "sliva5"},
            new Question { CorrectOptionIndex = 3, ImageName = "balyq3"},
            new Question { CorrectOptionIndex = 2, ImageName = "rakushka2"},
            new Question { CorrectOptionIndex = 5, ImageName = "kivi5"},
            new Question { CorrectOptionIndex = 2, ImageName = "balyq2"},
            new Question { CorrectOptionIndex = 3, ImageName = "rakushka3"}
        };

        private string imagesFolderPath = "G:\\Project_for_kids\\resource\\san\\counter\\";
        private int counter = 0;
        private int currentImageIndex = 0;

        public MathCount()
        {
            InitializeComponent();
        }

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (currentImageIndex == 18)
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter}");
                    auth.SaveTestResults(counter,"Math_res");
                }
                else
                {
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}.png");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ответ. Попробуйте еще раз.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            CheckAnswer(4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CheckAnswer(5);
        }

        private void MathCount_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"balyq4.png");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}