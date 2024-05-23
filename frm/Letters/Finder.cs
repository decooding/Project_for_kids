using Project_for_kids.data;
using Project_for_kids.frm.panel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;
using static Project_for_kids.data.Auth;

namespace Project_for_kids.frm.Letters
{
    public partial class Finder : Form
    {
        public class Quiz
        {
            public Dictionary<int, (string imagePaths, List<string> options, string correctAnswer)> DicQuestionValue = new()
            {
                { 1, ("1",  new List<string> {"Б", "Д", "С", "Т"}, "Д") },
                { 2, ("2", new List<string> {"О", "Е", "Ы", "У"}, "О") },
                { 3, ("3", new List<string> {"С", "Р", "П", "Г"}, "Г") },
                { 4, ("4", new List<string> {"О", "C", "И", "Ж"}, "Ж") },
                { 5, ("5", new List<string> {"З", "А", "Ж", "Е"}, "А") },
                { 6, ("6", new List<string> {"І", "А", "Ф", "E"}, "Ф") },
                { 7, ("7", new List<string> {"Қ", "У", "К", "Ә"}, "К") },
                { 8, ("8", new List<string> {"Д", "Ң", "С", "Ү"}, "С") },
                { 9, ("9", new List<string> {"Т", "Ы", "Қ", "Ж"}, "Қ") },
                { 10, ("10", new List<string> {"Ш", "Ц", "У", "Б"}, "Ц") },
            };
        }

        private string imagesFolderPath = @$"{GFold.GPath}resource\\arip\\find\\";
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private int counter = 0;
        private int currentQuestIndex = 0;
        private Quiz quiz = new Quiz();
        private Auth auth = new Auth();
        private SoundPlayer soundPlayer;

        public Finder()
        {
            InitializeComponent();
            auth.StartTimer();
            DisplayQuestion(currentQuestIndex);
            soundPlayer = new SoundPlayer(Path.Combine(imagesFolderPath, $"sound.wav"));
            soundPlayer.Play();
        }

        private void DisplayQuestion(int index)
        {
            var question = quiz.DicQuestionValue[index + 1];
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}.jpeg");
            label2.Text = question.options[0];
            label3.Text = question.options[1];
            label4.Text = question.options[2];
            label5.Text = question.options[3];
        }

        private void CheckAnswer(string selectedOption)
        {
            var question = quiz.DicQuestionValue[currentQuestIndex + 1];

            if (selectedOption == question.correctAnswer)
            {
                counter++;
                currentQuestIndex++;

                if (currentQuestIndex < quiz.DicQuestionValue.Count)
                {
                    DisplayQuestion(currentQuestIndex);
                    soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"succ.wav"));
                    soundPlayer.Play();
                }
                else
                {
                    auth.SaveTestResults(counter, "Letter_res", "2 Деңгей");
                    counter = 0;
                    currentQuestIndex = 0;
                }
            }
            else
            {
                soundPlayer = new SoundPlayer(Path.Combine(soundFilePath, $"neto.wav"));
                soundPlayer.Play();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            CheckAnswer(label2.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CheckAnswer(label3.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CheckAnswer(label4.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CheckAnswer(label5.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LetterForm form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
