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

namespace WinApp.frm
{
    public partial class MathLess : Form
    {
        public class Question
        {
            public int CorrectOptionIndex { get; set; }
            public string? ImageName { get; set; }
        }

        List<Question> questions = new List<Question>
        {
            new Question { CorrectOptionIndex = 2, ImageName = "1"},
            new Question { CorrectOptionIndex = 2, ImageName = "2"},
            new Question { CorrectOptionIndex = 1, ImageName = "3"},
            new Question { CorrectOptionIndex = 2, ImageName = "4"},
            new Question { CorrectOptionIndex = 2, ImageName = "5"},
            new Question { CorrectOptionIndex = 2, ImageName = "6"}
        };

        private string imagesFolderPath = "G:\\Project_for_kids\\resource\\san\\less\\";
        private int counter = 0;
        private int currentImageIndex = 0; // Add this line to track the current image index

        public MathLess()
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

                if (counter == 6)
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter}");
                }
                else
                {
                    pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}0.png");
                    pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}1.png");
                    pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}2.png");
                    pictureBox4.ImageLocation = Path.Combine(imagesFolderPath, $"{questions[currentImageIndex].ImageName}3.png");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ответ. Попробуйте еще раз.");
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
            Form2 form2 = new();
            this.Hide();
            form2.Show();
        }
    }
}
