namespace UI
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.birthDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radSex = new System.Windows.Forms.Panel();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.nam = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelUserNam = new System.Windows.Forms.Label();
            this.listStudent = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthDay
            // 
            this.birthDay.CustomFormat = "dd/MM/yyyy";
            this.birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDay.Location = new System.Drawing.Point(147, 129);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(243, 26);
            this.birthDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1231, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lý Học Sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(147, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(243, 26);
            this.name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh";
            // 
            // radSex
            // 
            this.radSex.BackColor = System.Drawing.Color.Transparent;
            this.radSex.Controls.Add(this.Nu);
            this.radSex.Controls.Add(this.nam);
            this.radSex.Location = new System.Drawing.Point(147, 161);
            this.radSex.Name = "radSex";
            this.radSex.Size = new System.Drawing.Size(156, 46);
            this.radSex.TabIndex = 6;
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nu.ForeColor = System.Drawing.Color.Yellow;
            this.Nu.Location = new System.Drawing.Point(85, 3);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(65, 30);
            this.Nu.TabIndex = 1;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // nam
            // 
            this.nam.AutoSize = true;
            this.nam.Checked = true;
            this.nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nam.ForeColor = System.Drawing.Color.Yellow;
            this.nam.Location = new System.Drawing.Point(-1, 3);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(84, 30);
            this.nam.TabIndex = 0;
            this.nam.TabStop = true;
            this.nam.Text = "Nam";
            this.nam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelUserNam
            // 
            this.labelUserNam.BackColor = System.Drawing.Color.Transparent;
            this.labelUserNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNam.ForeColor = System.Drawing.Color.Yellow;
            this.labelUserNam.Location = new System.Drawing.Point(-2, 461);
            this.labelUserNam.Name = "labelUserNam";
            this.labelUserNam.Size = new System.Drawing.Size(239, 35);
            this.labelUserNam.TabIndex = 10;
            this.labelUserNam.Text = "label4";
            this.labelUserNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserNam.Click += new System.EventHandler(this.label4_Click);
            // 
            // listStudent
            // 
            this.listStudent.Location = new System.Drawing.Point(454, 60);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(775, 312);
            this.listStudent.TabIndex = 11;
            this.listStudent.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "save as";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(168, 312);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(243, 26);
            this.searchName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 59);
            this.button5.TabIndex = 16;
            this.button5.Text = "tim kiem theo ten";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1135, 378);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 47);
            this.button6.TabIndex = 17;
            this.button6.Text = "Reload";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.s4;
            this.ClientSize = new System.Drawing.Size(1232, 505);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.labelUserNam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly hoc sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.radSex.ResumeLayout(false);
            this.radSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker birthDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel radSex;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.RadioButton nam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelUserNam;
        private System.Windows.Forms.ListView listStudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}