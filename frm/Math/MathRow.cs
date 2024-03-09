using WinFormsApp1;

namespace Program_for_kids.frm
{
    public partial class MathRow : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
            public string? labeltext { get; set; }
        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 0, ImageName = "1"},
            new Question { CorrectOptionIndex = 1, ImageName = "2"},
            new Question { CorrectOptionIndex = 0, ImageName = "3"},
            new Question { CorrectOptionIndex = 0, ImageName = "4"},
            new Question { CorrectOptionIndex = 0, ImageName = "5"},
            new Question { CorrectOptionIndex = 0, ImageName = "6"},
            new Question { CorrectOptionIndex = 1, ImageName = "7"},
            new Question { CorrectOptionIndex = 0, ImageName = "8" }
        };

        private string imagesFolderPath = "D:\\WinApp-for-kids-master\\resource\\san\\row\\";
        private int counter = 0;
        private int currentImageIndex = 0;

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 8)
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter}");
                }
                else
                {
                    //label1.Text = questions[currentImageIndex].labeltext;
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}0.png");
                    pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
                    pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ответ. Попробуйте еще раз.");
            }
        }

        public MathRow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            this.Hide();
            form2.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void MathRow_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}0.png");
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
            pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
        }
    }
}
