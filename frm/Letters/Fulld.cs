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

namespace Project_for_kids.frm.Letters
{
    public partial class Fulld : Form
    {
        public class Quiz
        {
            public Dictionary<int, (string imagePaths, List<string> options, string correctAnswer)> DicQuestionValue = new()
            {
                { 1, ("1",  new List<string> {"-ГЕР", "-МЕ", "-ТҮН", "-РІК"}, "-ТҮН") },
                { 2, ("2", new List<string> {"-НА", "-ТОН", "-ҒЫ", "-ҒАШ"}, "-ҒЫ") },
                { 3, ("3", new List<string> {"-ПАҚ", "-ДЫС", "-ШАҚ", "-РЫҚ"}, "-ДЫС") },
                { 4, ("4", new List<string> {"-ЧИК", "-ТА", "-АТ", "-КА"}, "-КА") },
                { 5, ("5", new List<string> {"-КЕН", "-ГУРТ", "-ТАН", "-ГА"}, "-ГУРТ") },
                { 6, ("6", new List<string> {"-ГОН", "-НГА", "-ТАР", "-ЖАГ"}, "-ГОН") },
                { 7, ("7", new List<string> {"-ТАН", "-КРАН", "-ФАН", "-ТЛАН"}, "-КРАН") },
                { 8, ("8", new List<string> {"-КА", "-ХАН", "-ЛАР", "-ДАН"}, "-ДАН") },
                { 9, ("9", new List<string> {"-ТА", "-ЗА", "-РА", "-ША"}, "-ЗА") },
                { 10, ("10", new List<string> {"-ШІР", "-МІР", "-РІК", "-ЛІК"}, "-РІК") },
            };
        }

        private string imagesFolderPath = @$"{GFold.GPath}resource\\arip\\fulld\\";
        private string soundFilePath = @$"{GFold.GPath}resource\\sound\\";
        private int counter = 0;
        private int currentQuestIndex = 0;
        private Quiz quiz = new Quiz();
        private Auth auth = new Auth();
        private SoundPlayer soundPlayer;

        public Fulld()
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
                    auth.SaveTestResults(counter, "Letter_res", "4 Деңгей");
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
