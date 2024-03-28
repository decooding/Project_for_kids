using Project_for_kids.data;
using WinApp.frm;

namespace Project_for_kids.frm.Letter
{
    public partial class Adder : Form
    {
        public class Quiz
        {
            public Dictionary<int, (string imagePaths, string word, List<string> options, string correctAnswer)> DicQuestionValue = new()
            {
                { 1, ("bal", "Б..Л", new List<string> {"Б", "А", "С", "Т"}, "А") },
                { 2, ("balyq", "БАЛ..Қ", new List<string> {"О", "Е", "Ы", "У"}, "Ы") },
                { 3, ("gul", "..ҮЛ", new List<string> {"С", "Р", "П", "Г"}, "Г") },
                { 4, ("it", "..Т", new List<string> {"О", "C", "И", "Й"}, "И") },
                { 5, ("keme", "К..М..", new List<string> {"З", "А", "Ж", "Е"}, "Е") },
                { 6, ("kitap", "К..ТАП", new List<string> {"І", "А", "Қ", "E"}, "І") },
                { 7, ("kolik", "КӨ..ІК", new List<string> {"И", "У", "Л", "Ә"}, "Л") },
                { 8, ("kun", "К..Н", new List<string> {"Д", "Ң", "Ұ", "Ү"}, "Ү") },
                { 9, ("mysyq", "М..С..Қ", new List<string> {"Т", "Ы", "І", "Ж"}, "Ы") },
                { 10, ("qaishy", "ҚАЙ..Ы", new List<string> {"Ш", "Х", "У", "Б"}, "Ш") },
                { 11, ("siyr", "..ИЫР", new List<string> {"Т", "С", "В", "М"}, "С") },
                { 12, ("ushaq", "ҰШ..Қ", new List<string> {"Г", "Б", "А", "Ү"}, "А") },
                { 13, ("baqa", "Б..Қ..", new List<string> {"Ы", "Ә", "Д", "А"}, "А") }
            };
        }

        private string imagesFolderPath = "G:\\Project_for_kids\\resource\\arip\\img\\";
        private int counter = 0;
        private int currentQuestIndex = 0;
        private Quiz quiz = new Quiz();
        Auth auth = new Auth();

        public Adder()
        {
            InitializeComponent();
            DisplayQuestion(currentQuestIndex);
        }

        private void DisplayQuestion(int index)
        {
            var question = quiz.DicQuestionValue[index + 1];
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}.png");
            label1.Text = question.word;
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
                }
                else
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter} из {quiz.DicQuestionValue.Count}");
                    auth.SaveTestResults(counter, "Letter_res");

                    counter = 0;
                    currentQuestIndex = 0;
                    DisplayQuestion(currentQuestIndex);
                }
            }
            else
            {
                MessageBox.Show($"Попробуйте еще раз.");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
