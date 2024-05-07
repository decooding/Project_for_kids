using Project_for_kids;
using Project_for_kids.data;
using System.Media;
using static Project_for_kids.data.Auth;
namespace Uniclo.frm
{
    public partial class MathCount : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
            public string? SoundPath { get; set; }
            public string? QuestLabel { get; set; }
        }
        Auth auth = new Auth(); 

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 4, ImageName = "balyq4", SoundPath= "balyq", QuestLabel="Суретте неше балық көрсетілген?"},
            new Question { CorrectOptionIndex = 3, ImageName = "alma3", SoundPath= "fruit",  QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 3, ImageName = "rakushka3", SoundPath= "ai", QuestLabel="Суретте неше айқұлақ көрсетілген?"},
            new Question { CorrectOptionIndex = 5, ImageName = "apelsin5", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 1, ImageName = "balyq1", SoundPath= "balyq", QuestLabel="Суретте неше балық көрсетілген?"},
            new Question { CorrectOptionIndex = 2, ImageName = "cocos2", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 5, ImageName = "japyraq5", SoundPath= "list", QuestLabel="Суретте неше жапырақ көрсетілген?"},
            new Question { CorrectOptionIndex = 5, ImageName = "jidek5", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 2, ImageName = "japyraq2", SoundPath= "list", QuestLabel="Суретте неше жапырақ көрсетілген?"},
            new Question { CorrectOptionIndex = 2, ImageName = "avacado2", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 1, ImageName = "rakushka1", SoundPath= "ai", QuestLabel="Суретте неше айқұлақ көрсетілген?"},
            new Question { CorrectOptionIndex = 5, ImageName = "sliva5", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 3, ImageName = "balyq3", SoundPath= "balyq", QuestLabel="Суретте неше балық көрсетілген?"},
            new Question { CorrectOptionIndex = 1, ImageName = "arbuz1", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 2, ImageName = "rakushka2", SoundPath= "ai", QuestLabel="Суретте неше айқұлақ көрсетілген?"},
            new Question { CorrectOptionIndex = 5, ImageName = "kivi5", SoundPath= "fruit",  QuestLabel="Суретте неше жеміс көрсетілген?"},
            new Question { CorrectOptionIndex = 2, ImageName = "balyq2", SoundPath= "balyq", QuestLabel="Суретте неше балық көрсетілген?"},
            new Question { CorrectOptionIndex = 1, ImageName = "ananas1", SoundPath= "fruit", QuestLabel="Суретте неше жеміс көрсетілген?"}
        };

        

        private string imagesFolderPath = @$"{GFold.GPath}resource\\san\\counter\\";
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";

        private int counter = 0;
        private int currentImageIndex = 0;
        private SoundPlayer soundPlayer;
        private SoundPlayer soundSuc;

        public MathCount()
        {
            InitializeComponent();
            PlaySound($"{questions[currentImageIndex].SoundPath}.wav");
            label1.Text = questions[currentImageIndex].QuestLabel;

        }

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (currentImageIndex == 17)
                {
                    auth.SaveTestResults(counter, "Math_res");
                    PlaySound("finish.wav");
                }
                else
                {
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}.png");
                    PlaySound($"{questions[currentImageIndex].SoundPath}.wav");
                    label1.Text = questions[currentImageIndex].QuestLabel;
                }
            }
            else
            {
                PlaySound("neto.wav");
            }
        }

        private void PlaySound(string soundFileName)
        {
            string soundPath = Path.Combine(soundFilePath, soundFileName);
            using (SoundPlayer soundPlayer = new SoundPlayer(soundPath))
            {
                soundPlayer.Play();
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
            MainForm form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}