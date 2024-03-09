using Program_for_kids;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WinApp.frm
{
    public partial class SecWin2 : Form
    {
        private SoundPlayer soundPlayer;

        public SecWin2()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer(@".\WinApp\sound\tts.wav");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                soundPlayer.Play();
            }
            catch
            {
                MessageBox.Show($"Проверьте расположен ли папка sound в диске /С:", "Ошибка воспроизведения звука", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
