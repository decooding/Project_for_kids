using Project_for_kids.frm.Math;
using Project_for_kids.frm.Reader;
using Project_for_kids.frm.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.frm;

namespace Project_for_kids.frm.panel
{
    public partial class ReadingForm : Form
    {
        public ReadingForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VideoPanel videoPanel = new();
            this.Hide();
            videoPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers numbers = new();
            this.Hide();
            numbers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alphabet alphabet = new();
            this.Hide();
            alphabet.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Activites activites = new();
            this.Hide();
            activites.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Animals animals = new();
            this.Hide();
            animals.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Colors colors = new();
            this.Hide();
            colors.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Feelings feel = new();
            this.Hide();
            feel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Figures figures = new();
            this.Hide();
            figures.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            this.Hide();
            main.Show();
        }
    }
}
