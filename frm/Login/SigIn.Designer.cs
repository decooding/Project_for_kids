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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 296);
            button1.Name = "button1";
            button1.Size = new Size(170, 31);
            button1.TabIndex = 0;
            button1.Text = "Тіркелу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 201);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин:";
            // 
            // login
            // 
            login.Location = new Point(57, 198);
            login.Name = "login";
            login.Size = new Size(125, 23);
            login.TabIndex = 2;
            // 
            // fname
            // 
            fname.Location = new Point(12, 114);
            fname.Name = "fname";
            fname.Size = new Size(131, 23);
            fname.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Аты-жөні:";
            // 
            // lname
            // 
            lname.Location = new Point(12, 160);
            lname.Name = "lname";
            lname.Size = new Size(172, 23);
            lname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Тегі:";
            // 
            // age
            // 
            age.Location = new Point(149, 114);
            age.Name = "age";
            age.Size = new Size(35, 23);
            age.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 96);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "Жас:";
            // 
            // password
            // 
            password.Location = new Point(11, 247);
            password.Name = "password";
            password.Size = new Size(172, 23);
            password.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 229);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Құпия сөз:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(15, 332);
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
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(32, 19);
            label6.Name = "label6";
            label6.Size = new Size(132, 45);
            label6.TabIndex = 12;
            label6.Text = "Тіркелу";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(-14, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 94);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            Controls.Add(pictureBox1);
            Name = "SigIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SigIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}