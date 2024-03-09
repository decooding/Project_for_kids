namespace WinApp.frm.Login
{
    partial class SigIn
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
            login = new TextBox();
            fname = new TextBox();
            label2 = new Label();
            lname = new TextBox();
            label3 = new Label();
            age = new TextBox();
            label4 = new Label();
            password = new TextBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 281);
            button1.Name = "button1";
            button1.Size = new Size(174, 31);
            button1.TabIndex = 0;
            button1.Text = "Тіркелу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 182);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // login
            // 
            login.Location = new Point(57, 179);
            login.Name = "login";
            login.Size = new Size(125, 23);
            login.TabIndex = 2;
            // 
            // fname
            // 
            fname.Location = new Point(12, 92);
            fname.Name = "fname";
            fname.Size = new Size(131, 23);
            fname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Аты-жөні:";
            // 
            // lname
            // 
            lname.Location = new Point(12, 136);
            lname.Name = "lname";
            lname.Size = new Size(172, 23);
            lname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Тегі:";
            // 
            // age
            // 
            age.Location = new Point(149, 92);
            age.Name = "age";
            age.Size = new Size(35, 23);
            age.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 74);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Жас:";
            // 
            // password
            // 
            password.Location = new Point(10, 231);
            password.Name = "password";
            password.Size = new Size(172, 23);
            password.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 213);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Құпия сөз:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(13, 326);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(165, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Аккаунтыңыз бар ма? Кіріңіз";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label6.Location = new Point(57, 23);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 12;
            label6.Text = "Тіркелу";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SigIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 365);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(age);
            Controls.Add(label4);
            Controls.Add(lname);
            Controls.Add(label3);
            Controls.Add(fname);
            Controls.Add(label2);
            Controls.Add(login);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "SigIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SigIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox login;
        private TextBox fname;
        private Label label2;
        private TextBox lname;
        private Label label3;
        private TextBox age;
        private Label label4;
        private TextBox password;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label6;
    }
}