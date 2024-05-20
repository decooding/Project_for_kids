namespace Project_for_kids.frm.Letters
{
    partial class Whatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whatis));
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(273, 421);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Padding = new Padding(25);
            label5.Size = new Size(175, 85);
            label5.TabIndex = 23;
            label5.Text = "ІРІМШІК";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.InfoText;
            label4.Location = new Point(23, 421);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Padding = new Padding(25);
            label4.Size = new Size(221, 85);
            label4.TabIndex = 22;
            label4.Text = "КІТАПХАНА";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(263, 316);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Padding = new Padding(25);
            label3.Size = new Size(220, 85);
            label3.TabIndex = 21;
            label3.Text = "ВЕЛОСИПЕД";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.blue_arrow_24;
            pictureBox2.Location = new Point(13, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(23, 316);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Padding = new Padding(25);
            label2.Size = new Size(210, 85);
            label2.TabIndex = 18;
            label2.Text = "КІТАПҚАП";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(82, 38);
            label1.Name = "label1";
            label1.Size = new Size(301, 25);
            label1.TabIndex = 17;
            label1.Text = "Суретте не көрсетілгенін анықта";
            // 
            // Whatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 533);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Whatis";
            Text = "Whatis";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}