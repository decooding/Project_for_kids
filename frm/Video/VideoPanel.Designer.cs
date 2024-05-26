namespace Project_for_kids.frm.Video
{
    partial class VideoPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPanel));
            MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            linkLabel4 = new LinkLabel();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            linkLabel3 = new LinkLabel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // MediaPlayer1
            // 
            MediaPlayer1.Enabled = true;
            MediaPlayer1.Location = new Point(362, 101);
            MediaPlayer1.Name = "MediaPlayer1";
            MediaPlayer1.OcxState = (AxHost.State)resources.GetObject("MediaPlayer1.OcxState");
            MediaPlayer1.Size = new Size(650, 400);
            MediaPlayer1.TabIndex = 3;
            MediaPlayer1.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 342);
            panel1.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(linkLabel4);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(6, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(276, 92);
            panel5.TabIndex = 6;
            panel5.Click += panel5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(179, 44);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 3;
            label7.Text = "Ұзақтығы:";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new Point(237, 44);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(28, 15);
            linkLabel4.TabIndex = 2;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "4:04";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(176, 22);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 0;
            label8.Text = "Жануарлар";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(linkLabel3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(6, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(276, 92);
            panel4.TabIndex = 5;
            panel4.Click += panel4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(179, 44);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 3;
            label5.Text = "Ұзақтығы:";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(237, 44);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(28, 15);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "1:54";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(176, 22);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 0;
            label6.Text = "Бағдаршам";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(170, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(6, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 92);
            panel3.TabIndex = 4;
            panel3.Click += panel3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 44);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 3;
            label3.Text = "Ұзақтығы:";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(237, 44);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(28, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "2:47";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(176, 22);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "Қуырмаш";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 92);
            panel2.TabIndex = 3;
            panel2.Click += panel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 44);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Ұзақтығы:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(237, 44);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(28, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "1:23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(176, 22);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Джунгли биі";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(74, 12);
            label11.Name = "label11";
            label11.Size = new Size(209, 45);
            label11.TabIndex = 6;
            label11.Text = "Бейнежинақ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // VideoPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(984, 418);
            Controls.Add(pictureBox6);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(MediaPlayer1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VideoPanel";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VideoPanel";
            ((System.ComponentModel.ISupportInitialize)MediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Label label3;
        private LinkLabel linkLabel2;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label7;
        private LinkLabel linkLabel4;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Label label5;
        private LinkLabel linkLabel3;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label11;
        private PictureBox pictureBox6;
    }
}