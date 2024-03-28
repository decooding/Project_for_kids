
using Project_for_kids.data;
using System.Media;
using System.Windows.Forms;
using WinApp.frm;

namespace Project_for_kids.frm.Letter
{
    public partial class Matin : Form
    {

        class Story
        {
            public Dictionary<int, (string imagePaths, string word, string sounder, List<int> correctanswer)> StorageValue = new()
            {
                { 1, ("beach", "word", "А", new List<int> {1,2,3,4 }) },
                { 2, ("cook", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 3, ("evening", "прыкрып вапывапраыв", "В", new List<int> {1,2,3 }) },
                { 4, ("general", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 5, ("girl", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 6, ("kids", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 7, ("nature", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 8, ("play", "прппары", "Б", new List<int> {1,2,3,4}) },
                { 9, ("winnter", "прппары", "Б", new List<int> {1,2,3,4}) }
            };

        }

        private string imagesFolderPath = "G:\\Project_for_kids\\resource\\arip\\story\\";
        private string soundFolderPath = "G:\\Project_for_kids\\resource\\sound\\alphabet\\";
        private int counter = 0;
        private int currentQuestIndex = 0;
        private Story store = new Story();
        private SoundPlayer soundPlayer;
        Auth auth = new();

        public Matin()
        {
            InitializeComponent();
            DisplayQuestion(currentQuestIndex);
        }

        private void DisplayQuestion(int index)
        {
            var question = store.StorageValue[index + 1];
            label1.Text = question.word;
            pictureBox1.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}1.png");
            pictureBox2.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}2.png");
            pictureBox3.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}3.png");
            pictureBox4.ImageLocation = Path.Combine(imagesFolderPath, $"{question.imagePaths}4.png");
            soundPlayer = new SoundPlayer(Path.Combine(soundFolderPath,$"{question.sounder}.wav"));
            soundPlayer.Play();
        }

        private bool allOptionsSelected = false;
        int addindex = 0;

        private void CheckAnswer(int selectedOption)
        {
            var question = store.StorageValue[currentQuestIndex + 1];


            do
            {
                if (selectedOption == question.correctanswer[addindex])
                {
                    ((PictureBox)Controls.Find($"pictureBox{selectedOption}", true)[0]).Visible = false;
                    addindex++;
                }
                else
                {
                    return; // Exit the method if the answer is incorrect
                }
            } while (addindex < question.correctanswer.Count);

            // Check if all options have been selected
            if (addindex == question.correctanswer.Count)
            {
                allOptionsSelected = true;
                addindex = 0;
            }
            else
            {
                allOptionsSelected = false;
                return; // Exit the method if not all options are selected
            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Visible = true;
                }
            }

            counter++;
            currentQuestIndex++;

            if (allOptionsSelected)
            {
                if (currentQuestIndex < store.StorageValue.Count)
                {
                    DisplayQuestion(currentQuestIndex);
                }
                else
                {
                    MessageBox.Show($"Тест завершен. Правильных ответов: {counter} из {store.StorageValue.Count}");
                    auth.SaveTestResults(counter, "Letter_res");
                    counter = 0;
                    currentQuestIndex = 0;
                    DisplayQuestion(currentQuestIndex);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4);

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
