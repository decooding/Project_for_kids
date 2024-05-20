using Project_for_kids.frm.Letter;
using Project_for_kids.frm.Letters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_kids.frm.panel
{
    public partial class LetterForm : Form
    {
        public LetterForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adder adder = new();
            this.Hide();
            adder.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Matin matin = new();
            matin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Finder finder = new();
            this.Hide();
            finder.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fulld full = new();
            this.Hide();
            full.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Whatis what = new();
            this.Hide();
            what.Show();
        }
    }
}
