using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Project_for_kids.frm.Video
{
    public partial class VideoPanel : Form
    {
        public VideoPanel()
        {
            InitializeComponent();
        }

        private void VideoPanel_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MediaPlayer1.Ctlcontrols.play();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.VerticalScroll.Value = e.NewValue;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainForm main = new();
            this.Hide();
            main.Show();
        }
    }
}
