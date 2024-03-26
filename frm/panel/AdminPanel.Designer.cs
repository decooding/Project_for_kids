namespace WinApp.frm.panel
{
    partial class AdminPanel
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            passwordTextBox = new TextBox();
            label7 = new Label();
            ageTextBox = new TextBox();
            label6 = new Label();
            lastnameTextBox = new TextBox();
            label5 = new Label();
            firstnameTextBox = new TextBox();
            label4 = new Label();
            loginTextBox = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            button3 = new Button();
            LetterTextBox = new TextBox();
            label10 = new Label();
            MathTextBox = new TextBox();
            label9 = new Label();
            idUserTextBox = new TextBox();
            label8 = new Label();
            idTextBox = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 128);
            button1.Name = "button1";
            button1.Size = new Size(172, 27);
            button1.TabIndex = 0;
            button1.Text = "Өзгерту";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Қолданушылар:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 98);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 162);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(670, 98);
            dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 4;
            label2.Text = "Қолданушы ұпайлары:";
            // 
            // button2
            // 
            button2.Location = new Point(702, 27);
            button2.Name = "button2";
            button2.Size = new Size(76, 31);
            button2.TabIndex = 5;
            button2.Text = "Артқа";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(698, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(202, 188);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(passwordTextBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(ageTextBox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(lastnameTextBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(firstnameTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(loginTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(194, 160);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Қолданушы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(73, 38);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(111, 23);
            passwordTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 41);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 9;
            label7.Text = "Password:";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(152, 9);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(32, 23);
            ageTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(118, 12);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 7;
            label6.Text = "Age:";
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(84, 99);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(100, 23);
            lastnameTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "LastName:";
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(84, 70);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(100, 23);
            firstnameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "FirstName:";
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(51, 9);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(62, 23);
            loginTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "login:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(LetterTextBox);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(MathTextBox);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(idUserTextBox);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(194, 160);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Нәтижелер:";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 115);
            button3.Name = "button3";
            button3.Size = new Size(151, 27);
            button3.TabIndex = 11;
            button3.Text = "Өзгерту";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LetterTextBox
            // 
            LetterTextBox.Location = new Point(74, 77);
            LetterTextBox.Name = "LetterTextBox";
            LetterTextBox.Size = new Size(100, 23);
            LetterTextBox.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 80);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 9;
            label10.Text = "Әріп:";
            // 
            // MathTextBox
            // 
            MathTextBox.Location = new Point(74, 48);
            MathTextBox.Name = "MathTextBox";
            MathTextBox.Size = new Size(100, 23);
            MathTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 51);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 7;
            label9.Text = "Логика:";
            // 
            // idUserTextBox
            // 
            idUserTextBox.Location = new Point(105, 19);
            idUserTextBox.Name = "idUserTextBox";
            idUserTextBox.Size = new Size(69, 23);
            idUserTextBox.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 23);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 5;
            label8.Text = "Қолданушы:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(864, 32);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(32, 23);
            idTextBox.TabIndex = 7;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(839, 37);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 8;
            label11.Text = "ID:";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 267);
            Controls.Add(label11);
            Controls.Add(idTextBox);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminPanel";
            Text = "Form1";
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox loginTextBox;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label7;
        private TextBox ageTextBox;
        private Label label6;
        private TextBox lastnameTextBox;
        private Label label5;
        private TextBox firstnameTextBox;
        private Label label4;
        private TextBox LetterTextBox;
        private Label label10;
        private TextBox MathTextBox;
        private Label label9;
        private TextBox idUserTextBox;
        private Label label8;
        private Button button3;
        private TextBox idTextBox;
        private Label label11;
    }
}