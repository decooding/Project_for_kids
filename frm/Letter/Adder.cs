using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WinApp.frm;

namespace Project_for_kids.frm.Letter
{
    public partial class Adder : Form
    {
        public Adder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new();
            this.Hide();
            form3.Show();
        }
    }
}
