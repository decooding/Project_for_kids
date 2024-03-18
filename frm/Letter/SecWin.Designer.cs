namespace WinApp.frm
{
    partial class Form3
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
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(64, 100);
            button1.Name = "button1";
            button1.Size = new Size(248, 55);
            button1.TabIndex = 0;
            button1.Text = "Әліппе";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 64, 0);
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(64, 174);
            button3.Name = "button3";
            button3.Size = new Size(248, 55);
            button3.TabIndex = 2;
            button3.Text = "Сөз құра";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Project_for_kids.Properties.Resources.blue_arrow_24;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 64, 0);
            button2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(64, 252);
            button2.Name = "button2";
            button2.Size = new Size(248, 55);
            button2.TabIndex = 4;
            button2.Text = "Мәтін";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(385, 394);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "String";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button2;
    }
}