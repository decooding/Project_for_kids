namespace Project_for_kids.frm.Letters
{
    partial class Finder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finder));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(118, 27);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 0;
            label1.Text = "Бірінші әріпті тап!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(93, 259);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Padding = new Padding(25);
            label2.Size = new Size(83, 85);
            label2.TabIndex = 1;
            label2.Text = "А";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(83, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.blue_arrow_24;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(228, 259);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Padding = new Padding(25);
            label3.Size = new Size(83, 85);
            label3.TabIndex = 7;
            label3.Text = "А";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(93, 365);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Padding = new Padding(25);
            label4.Size = new Size(83, 85);
            label4.TabIndex = 8;
            label4.Text = "А";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(228, 365);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Padding = new Padding(25);
            label5.Size = new Size(83, 85);
            label5.TabIndex = 9;
            label5.Text = "А";
            label5.Click += label5_Click;
            // 
            // Finder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(406, 470);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Finder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2 Деңгей";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}