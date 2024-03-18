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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(42, 114);
            button1.Name = "button1";
            button1.Size = new Size(264, 47);
            button1.TabIndex = 0;
            button1.Text = "Математика";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(42, 173);
            button2.Name = "button2";
            button2.Size = new Size(264, 47);
            button2.TabIndex = 1;
            button2.Text = "Әріп";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumBlue;
            button3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(42, 291);
            button3.Name = "button3";
            button3.Size = new Size(264, 47);
            button3.TabIndex = 2;
            button3.Text = "Мини-ойындар";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(304, 12);
            button4.Name = "button4";
            button4.Size = new Size(34, 34);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(42, 233);
            button5.Name = "button5";
            button5.Size = new Size(264, 47);
            button5.TabIndex = 4;
            button5.Text = "Бейнелер";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 5;
            label1.Text = "Ұпай: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(350, 400);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
