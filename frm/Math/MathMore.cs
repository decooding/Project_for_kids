using Project_for_kids.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Program_for_kids.frm
{
    public partial class MathMore : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
            public string? labeltext { get; set; }
        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 1, ImageName = "1", labeltext = "Қай жерде чемодан аз?"},
            new Question { CorrectOptionIndex = 0, ImageName = "2", labeltext = "Қайда алма көп?"},
            new Question { CorrectOptionIndex = 1, ImageName = "3", labeltext = "Қайда қолғап көп?"},
            new Question { CorrectOptionIndex = 1, ImageName = "4", labeltext = "Қай жерде көлік аз?"},
            new Question { CorrectOptionIndex = 1, ImageName = "5", labeltext = "Қай жерде кесе көп?"},
            new Question { CorrectOptionIndex = 0, ImageName = "6", labeltext = "Жидек қай жерде аз?"},
            new Question { CorrectOptionIndex = 0, ImageName = "7", labeltext = "Қай жерде айғұлақ көп?"},
            new Question { CorrectOptionIndex = 0, ImageName = "8", labeltext = "Бас киім қайда көп?"},
            new Question { CorrectOptionIndex = 1, ImageName = "9", labeltext = "Гүлдер қай жерде  көп?"},
            new Question { CorrectOptionIndex = 1, ImageName = "10", labeltext = "Қай тарелкеде алма көп?"}
        };

        private string imagesFolderPath = "G:\\Project_for_kids\\resource\\san\\more\\";
        private int counter = 0;
        private int currentImageIndex = 0;
        Auth auth = new Auth();

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentImageIndex];

            if (selectedOption == currentQuestion.CorrectOptionIndex)
            {
                counter++;
                currentImageIndex = (currentImageIndex + 1) % questions.Count;

                if (counter == 10)
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter}");
                    auth.SaveTestResults(counter, "Math_res");

                }
                else
                {
                    label1.Text = questions[currentImageIndex].labeltext;
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
                    pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ответ. Попробуйте еще раз.");
            }
        }

        public MathMore()
        {
            InitializeComponent();
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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}
