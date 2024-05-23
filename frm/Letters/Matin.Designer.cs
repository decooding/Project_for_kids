namespace Project_for_kids.frm.Letter
{
    partial class Matin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matin));
            backbutton = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)backbutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.Transparent;
            backbutton.Image = Properties.Resources.blue_arrow_24;
            backbutton.Location = new Point(12, 12);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(52, 45);
            backbutton.SizeMode = PictureBoxSizeMode.StretchImage;
            backbutton.TabIndex = 0;
            backbutton.TabStop = false;
            backbutton.Click += backbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(169, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(467, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(169, 332);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(187, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(467, 332);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(185, 189);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(148, 35);
            label1.Name = "label1";
            label1.Size = new Size(549, 67);
            label1.TabIndex = 5;
            label1.Text = "Жағажайда әкесі, анасы және баласы демалып жатыр. Анасы мен қызы доппен ойнап, ал әкесі мен баласы балық аулап отыр. Кейінірек ұлы мен анасы құмнан үй салады.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // Matin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._69b90ed4e4087e02faaaccf33a843dfb;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 633);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(backbutton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Matin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "5 деңгей";
            ((System.ComponentModel.ISupportInitialize)backbutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backbutton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
    }
}