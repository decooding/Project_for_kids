using Project_for_kids;
using Project_for_kids.data;
using Project_for_kids.frm.panel;
using System.Media;
using static Project_for_kids.data.Auth;

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

        private string imagesFolderPath = @$"{GFold.GPath}resource\\san\\row\\";
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private int counter = 0;
        private int currentImageIndex = 0;
        Auth auth = new();
        private SoundPlayer soundPlayer;

          
        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 8)
                {
                    auth.SaveTestResults(counter, "Math_res", "3  Деңгей");
                }
                else
                {
                    //label1.Text = questions[currentImageIndex].labeltext;
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}0.png");
                    pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
                    pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
                    soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"succ.wav"));
                    soundPlayer.Play();
                }
            }
            else
            {
                //MessageBox.Show("Неправильный ответ. Попробуйте еще раз.");
                soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"neto.wav"));
                soundPlayer.Play();
            }
        }

        public MathRow()
        {
            InitializeComponent();
            auth.StartTimer();
            soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"qatar.wav"));
            soundPlayer.Play();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MathForm form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}
