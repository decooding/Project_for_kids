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

namespace Project_for_kids.frm.Reader
{
    public partial class Animals : Form
    {
        private SoundPlayer? soundPlayer;

        public Animals()
        {
            InitializeComponent();
        }

        void FunCallSound(int soundName)
        {
            string soundFilePath = @$"{GFold.GPath}resource\read\Animals\{soundName}.wav";
            soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FunCallSound(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FunCallSound(2);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FunCallSound(3);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FunCallSound(4);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FunCallSound(5);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FunCallSound(6);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FunCallSound(7);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReadingForm readerform = new();
            this.Hide();
            readerform.Show();
        }
    }
}
