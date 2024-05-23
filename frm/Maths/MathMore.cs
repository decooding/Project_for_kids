using Project_for_kids;
using Project_for_kids.data;
using Project_for_kids.frm.panel;
using System.Media;
using static Project_for_kids.data.Auth;

namespace Program_for_kids.frm
{
    public partial class MathMore : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
            public string? labeltext { get; set; }
            public string? SoundPath { get; set; }

        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 1, ImageName = "1", labeltext = "Қай жерде чемодан аз?", SoundPath="carry-on"},
            new Question { CorrectOptionIndex = 0, ImageName = "2", labeltext = "Қайда алма көп?", SoundPath="apple"},
            new Question { CorrectOptionIndex = 1, ImageName = "3", labeltext = "Қайда қолғап көп?", SoundPath="handbag"},
            new Question { CorrectOptionIndex = 1, ImageName = "4", labeltext = "Қай жерде көлік аз?", SoundPath="car"},
            new Question { CorrectOptionIndex = 1, ImageName = "5", labeltext = "Қай жерде кесе көп?", SoundPath="kese"},
            new Question { CorrectOptionIndex = 0, ImageName = "6", labeltext = "Жидек қай жерде аз?", SoundPath="fruitaz"},
            new Question { CorrectOptionIndex = 0, ImageName = "7", labeltext = "Қай жерде айғұлақ көп?", SoundPath="aiq"},
            new Question { CorrectOptionIndex = 0, ImageName = "8", labeltext = "Бас киім қайда көп?", SoundPath="hat"},
            new Question { CorrectOptionIndex = 1, ImageName = "9", labeltext = "Гүлдер қай жерде  көп?", SoundPath="flower"},
            new Question { CorrectOptionIndex = 1, ImageName = "10", labeltext = "Қай тарелкеде алма көп?", SoundPath="applemore"}
        };

        private string imagesFolderPath = @$"{GFold.GPath}resource\\san\\more\\";
        private int counter = 0;
        private int currentImageIndex = 0;
        Auth auth = new Auth();
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private SoundPlayer soundPlayer;

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 10)
                {
                    auth.SaveTestResults(counter, "Math_res", "2  Деңгей");
                }
                else
                {
                    soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"succ.wav"));
                    soundPlayer.Play();
                    label1.Text = questions[currentImageIndex].labeltext;
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
                    pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
                    string soundPlay = Path.Combine(soundFilePath, $"{questions[currentImageIndex].SoundPath}.wav");
                    soundPlayer = new SoundPlayer(soundPlay);
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

        public MathMore()
        {
            InitializeComponent();
            auth.StartTimer();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void MathMore_Load(object sender, EventArgs e)
        {
            label1.Text = questions[currentImageIndex].labeltext;
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
            string soundPlay = Path.Combine(soundFilePath, $"{questions[currentImageIndex].SoundPath}.wav");
            soundPlayer = new SoundPlayer(soundPlay);
            soundPlayer.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MathForm form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}
