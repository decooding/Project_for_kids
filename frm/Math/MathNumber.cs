using System.Windows.Forms;
using WinApp.frm;

namespace Project_for_kids.frm.Math
{
    public partial class MathNumber : Form
    {
        public MathNumber()
        {
            InitializeComponent();
            SetTransparentPictures(this);

        }

        private void SetTransparentPictures(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is PictureBox)
                {
                    PictureBox picture = (PictureBox)ctrl;
                    picture.BackColor = Color.Transparent;
                    picture.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 secwin = new();
            this.Hide();
            secwin.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text");

        }

    }
}
