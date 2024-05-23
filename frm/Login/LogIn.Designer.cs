namespace WinApp.frm.Login
{
    partial class LogIn
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
            linkLabel1 = new LinkLabel();
            textBox_Password = new TextBox();
            label5 = new Label();
            textBox_Username = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 237);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(183, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Аккаунтыңыз жоқ па? Тіркеліңіз";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox_Password
            // 
            textBox_Password.ImeMode = ImeMode.NoControl;
            textBox_Password.Location = new Point(12, 147);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.PlaceholderText = "password";
            textBox_Password.Size = new Size(183, 23);
            textBox_Password.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 129);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 15;
            label5.Text = "Құпия сөз:";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(59, 94);
            textBox_Username.Margin = new Padding(3, 30, 3, 3);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.PlaceholderText = "login";
            textBox_Username.Size = new Size(136, 23);
            textBox_Username.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 13;
            label1.Text = "Логин:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 198);
            button1.Name = "button1";
            button1.Size = new Size(183, 31);
            button1.TabIndex = 12;
            button1.Text = "Кіру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Dungeon", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(69, 23);
            label6.Name = "label6";
            label6.Size = new Size(75, 35);
            label6.TabIndex = 18;
            label6.Text = "Кіру";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(-4, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 85);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 264);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(textBox_Password);
            Controls.Add(label5);
            Controls.Add(textBox_Username);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox textBox_Password;
        private Label label5;
        private TextBox textBox_Username;
        private Label label1;
        private Button button1;
        private Label label6;
        private PictureBox pictureBox1;
    }
}