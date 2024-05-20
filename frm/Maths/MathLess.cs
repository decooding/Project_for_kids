using Project_for_kids;
using Project_for_kids.data;
using Project_for_kids.frm.panel;
using System.Media;
using static Project_for_kids.data.Auth;


namespace WinApp.frm
{
    public partial class MathLess : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
            public string? SoundPath { get; set; }
            public string? QLabel { get; set; }
        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 2, ImageName = "1", SoundPath="applehow" , QLabel="Әр тәрелкеге алмадан қою үшін, неше алма қажет?" },
            new Question { CorrectOptionIndex = 2, ImageName = "2", SoundPath="carrot"   , QLabel="Әр қоянға сәбізден беру үшін, неше сәбіз қажет?" },
            new Question { CorrectOptionIndex = 1, ImageName = "3", SoundPath="baloon"   , QLabel="Әр балаға шардан беру үшін, неше шар қажет?" },
            new Question { CorrectOptionIndex = 2, ImageName = "4", SoundPath="velohat"  , QLabel="Әр балаға велокаска кию үшін, неше велокаска қажет?" },
            new Question { CorrectOptionIndex = 2, ImageName = "5", SoundPath="finger"   , QLabel="Әр саусаққа ойыншықтарды кию үшін, неше ойыншық қажет?" },
            new Question { CorrectOptionIndex = 2, ImageName = "6", SoundPath="birdhouse", QLabel="Әр торғайда ұя болу үшін, неше ұя қажет?" }
        };

        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private SoundPlayer soundPlayer;
        private string imagesFolderPath = @$"{GFold.GPath}resource\\san\\less\\";
        private int counter = 0;
        private int currentImageIndex = 0;
        Auth auth = new Auth();

        public MathLess()
        {
            InitializeComponent();
            auth.StartTimer();
            PlaySound("applehow.wav");
        }

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 6)
                {
                    auth.SaveTestResults(counter, "Math_res");
                }
                else
                {
                    PlaySound("succ.wav");
                    UpdateImagesAndSound(currentImageIndex);
                }
            }
            else
            {
                PlaySound("neto.wav");
            }
        }

        private void UpdateImagesAndSound(int index)
        {
            label1.Text = questions[index].QLabel;
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[index].ImageName}0.png");
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[index].ImageName}1.png");
            pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[index].ImageName}2.png");
            pictureBox4.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[index].ImageName}3.png");
            PlaySound($"{questions[index].SoundPath}.wav");
        }

        private void PlaySound(string soundFileName)
        {
            string soundPath = Path.Combine(soundFilePath, soundFileName);
            using (SoundPlayer soundPlayer = new SoundPlayer(soundPath))
            {
                soundPlayer.Play();
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void MathLess_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}0.png");
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
            pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
            pictureBox4.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}3.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MathForm form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}
