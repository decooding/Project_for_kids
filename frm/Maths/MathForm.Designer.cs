namespace Project_for_kids.frm.panel
{
    partial class MathForm
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
            button9 = new Button();
            button10 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = Color.Chocolate;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(58, 374);
            button9.Name = "button9";
            button9.Size = new Size(325, 54);
            button9.TabIndex = 17;
            button9.Text = "5 Деңгей";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Orange;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(58, 305);
            button10.Name = "button10";
            button10.Size = new Size(325, 47);
            button10.TabIndex = 16;
            button10.Text = "4 Деңгей";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(58, 233);
            button3.Name = "button3";
            button3.Size = new Size(325, 53);
            button3.TabIndex = 15;
            button3.Text = "3 Деңгей";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.YellowGreen;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(58, 160);
            button6.Name = "button6";
            button6.Size = new Size(325, 54);
            button6.TabIndex = 14;
            button6.Text = "2 Деңгей";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(58, 91);
            button7.Name = "button7";
            button7.Size = new Size(325, 47);
            button7.TabIndex = 13;
            button7.Text = "1 Деңгей";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.blue_arrow_24;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(114, 12);
            label2.Name = "label2";
            label2.Size = new Size(227, 49);
            label2.TabIndex = 19;
            label2.Text = "Математика";
            // 
            // MathForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 462);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button7);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MathForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Математика";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button9;
        private Button button10;
        private Button button3;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
        private Label label2;
    }
}