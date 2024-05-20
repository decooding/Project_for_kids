
using Project_for_kids.data;
using System.Media;
using System.Windows.Forms;
using WinApp.frm;
using static Project_for_kids.data.Auth;

namespace Project_for_kids.frm.Letter
{
    public partial class Matin : Form
    {

        class Story
        {
            public Dictionary<int, (string imagePaths, string word, string sounder, List<int> correctanswer)> StorageValue = new()
            {
                { 1, (
                    "beach", 
                    "Жағажайда әкесі, анасы және баласы демалып жатыр. Анасы мен қызы доппен ойнап, ал әкесі мен баласы балық аулап отыр. Кейінірек ұлы мен анасы құмнан үй салады.", 
                    "beach", 
                    new List<int> {1,4,3,2 }) },
                { 2, (
                    "cook", 
                    "Аружан інісіне тамақ дайындамақшы болып ас дайындайды, пештен піскен нанды алып інісене береді, інісі Аружанның тамағын жеп, артынан ыдысын жуып қояды.", 
                    "cook", 
                    new List<int> {4,3,1,2}) },
                { 3, ("evening", 
                    "Дана кешкісін мысығымен ойын ойнап, жатарда тісің жуып ұйықтайды.", 
                    "evening", 
                    new List<int> {2,3,1}) },
                { 4, (
                    "general", 
                    "Арман шаңсорғышпен үй жинап, кір киімдерін жуып іліп қояды.", 
                    "general", 
                    new List<int> {3,1,2}) },
                { 5, (
                    "girl", 
                    "Алтынай таң атпай оянып алып спортпен шұғылданады, таңғы ас алдында тісін жуып алады.", 
                    "girl", 
                    new List<int> {4,2,1,3}) },
                { 6, (
                    "kids", 
                    "Далада балалар қар атысып, аққала жасап жатыр, Ерлан шана ал Анара кәнки теуіп жүр.", 
                    "kids", 
                    new List<int> {1,4,3,2}) },
                { 7, (
                    "nature", 
                    "Ансар дүрбімен аспанда құсты байқады, Берік ол құсты кітаптан тауып алды. Ұлдар аспанға қарап отырғанда, Риза шөпте көбелекті байқап, Дильназ оны суретке түсіріп алмақшы болды.", 
                    "nature", 
                    new List<int> {3,2,1,4}) },
                { 8, (
                    "play", 
                    "Рауан үйде тамақ дайындап, оны пешке қойғанша інілері Айдос диск лақтырып Жаслан оны ұстамақшы болып аулада ойнады.", 
                    "play", 
                    new List<int> {3,4,1,2}) },
                { 9, (
                    "winnter", 
                    "Ерасыл ата-анасымен сырғанаққа барып шанамен сырғанады. Мұз айдынында кәнки теуіп,  аққала жасады.", 
                    "winnter", 
                    new List<int> {2,1,3,4}) }
            };

        }

        private string imagesFolderPath = @$"{GFold.GPath}resource\\arip\\story\\";
        private string soundFolderPath = @$"{GFold.GPath}resource\\sound\\";
        private int counter = 0;
        private int currentQuestIndex = 0;
        private Story store = new Story();
        private SoundPlayer soundPlayer;
        Auth auth = new();

        public Matin()
        {
            InitializeComponent();
            auth.StartTimer();
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
                    soundPlayer = new SoundPlayer(Path.Combine(soundFolderPath, $"succ.wav"));
                    soundPlayer.Play();
                    ((PictureBox)Controls.Find($"pictureBox{selectedOption}", true)[0]).Visible = false;
                    addindex++;
                }
                else
                {
                    return;
                }

            } while (addindex < question.correctanswer.Count);

            if (addindex == question.correctanswer.Count)
            {
                allOptionsSelected = true;
                addindex = 0;
                
            }
            else
            {
                allOptionsSelected = false;
                return;
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
                    auth.SaveTestResults(counter, "Letter_res");
                    counter = 0;
                    currentQuestIndex = 0;
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
            MainForm form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
