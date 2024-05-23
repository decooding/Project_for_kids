using Project_for_kids.data;
using Project_for_kids.frm.panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_for_kids.data.Auth;


namespace Project_for_kids.frm.Maths
{
    public partial class Summer : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 1, ImageName = "1"},
            new Question { CorrectOptionIndex = 1, ImageName = "2"},
            new Question { CorrectOptionIndex = 1, ImageName = "3"},
            new Question { CorrectOptionIndex = 0, ImageName = "4"},
            new Question { CorrectOptionIndex = 0, ImageName = "5"},
            new Question { CorrectOptionIndex = 1, ImageName = "6"},
            new Question { CorrectOptionIndex = 0, ImageName = "7"},
            new Question { CorrectOptionIndex = 1, ImageName = "8" },
            new Question { CorrectOptionIndex = 1, ImageName = "9" },
            new Question { CorrectOptionIndex = 0, ImageName = "10"},
            new Question { CorrectOptionIndex = 1, ImageName = "11" },
            new Question { CorrectOptionIndex = 0, ImageName = "12"}
        };

        private string imagesFolderPath = @$"{GFold.GPath}resource\\san\\sum\\";
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private int counter = 0;
        private int currentImageIndex = 0;
        Auth auth = new();
        private SoundPlayer soundPlayer;

        public Summer()
        {
            InitializeComponent();
            auth.StartTimer();
            soundPlayer = new SoundPlayer(Path.Combine(imagesFolderPath, $"sound.wav"));
            soundPlayer.Play();
        }

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 12)
                {
                    auth.SaveTestResults(counter, "Math_res", "5 Деңгей");
                }
                else
                {
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}.jpeg");
                    soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"succ.wav"));
                    soundPlayer.Play();
                }
            }
            else
            {
                soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"neto.wav"));
                soundPlayer.Play();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MathForm mather = new();
            this.Hide();
            mather.Show();
        }
    }
}
