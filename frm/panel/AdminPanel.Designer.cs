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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            idTextBox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            deletebtn = new Button();
            Updatebtn = new Button();
            selectBtn = new Button();
            button1 = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
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
            dataGridView1.Size = new Size(670, 70);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 127);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(670, 71);
            dataGridView3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 4;
            label2.Text = "Қолданушы ұпайлары:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(710, 62);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(45, 23);
            idTextBox.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(710, 44);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 8;
            label11.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(844, 44);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 10;
            label12.Text = "PATH:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(769, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(710, 199);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(172, 27);
            deletebtn.TabIndex = 11;
            deletebtn.Text = "Жою";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.Location = new Point(710, 156);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(172, 27);
            Updatebtn.TabIndex = 12;
            Updatebtn.Text = "Өзгерту";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(710, 114);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(172, 27);
            selectBtn.TabIndex = 13;
            selectBtn.Text = "Таңдау";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(710, 241);
            button1.Name = "button1";
            button1.Size = new Size(172, 27);
            button1.TabIndex = 14;
            button1.Text = "Экспорттау";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Export_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 16;
            label3.Text = "Жалпы ұпай саны";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 224);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(670, 71);
            dataGridView2.TabIndex = 15;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 309);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(selectBtn);
            Controls.Add(Updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(label12);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private Label label2;
        private TextBox idTextBox;
        private Label label11;
        private Label label12;
        private TextBox textBox1;
        private Button deletebtn;
        private Button Updatebtn;
        private Button selectBtn;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView2;
    }
}