namespace Project_for_kids
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            label1 = new Label();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(-1, 510);
            button4.Name = "button4";
            button4.Size = new Size(39, 39);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(107, 284);
            button3.Name = "button3";
            button3.Size = new Size(325, 53);
            button3.TabIndex = 8;
            button3.Text = "Математика";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(107, 128);
            button7.Name = "button7";
            button7.Size = new Size(325, 47);
            button7.TabIndex = 6;
            button7.Text = "Оқыту";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(107, 438);
            button8.Name = "button8";
            button8.Size = new Size(325, 53);
            button8.TabIndex = 11;
            button8.Text = "Шығу";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Orange;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(107, 367);
            button10.Name = "button10";
            button10.Size = new Size(325, 47);
            button10.TabIndex = 9;
            button10.Text = "Көмек";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(107, 204);
            button1.Name = "button1";
            button1.Size = new Size(325, 53);
            button1.TabIndex = 13;
            button1.Text = "Сауат ашу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources._3b54191d83179b231a20125790af21b5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(510, 550);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(button10);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            ImeMode = ImeMode.Off;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Label label1;
        private Button button3;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button1;
    }
}
