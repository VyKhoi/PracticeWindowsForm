namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.originArr = new System.Windows.Forms.TextBox();
            this.ArrayIncrease = new System.Windows.Forms.TextBox();
            this.ArrayReduce = new System.Windows.Forms.TextBox();
            this.ArrayRevert = new System.Windows.Forms.TextBox();
            this.EO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeArr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originArr
            // 
            this.originArr.Location = new System.Drawing.Point(253, 131);
            this.originArr.Name = "originArr";
            this.originArr.Size = new System.Drawing.Size(429, 26);
            this.originArr.TabIndex = 0;
            this.originArr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ArrayIncrease
            // 
            this.ArrayIncrease.Location = new System.Drawing.Point(252, 179);
            this.ArrayIncrease.Name = "ArrayIncrease";
            this.ArrayIncrease.Size = new System.Drawing.Size(429, 26);
            this.ArrayIncrease.TabIndex = 1;
            // 
            // ArrayReduce
            // 
            this.ArrayReduce.Location = new System.Drawing.Point(252, 220);
            this.ArrayReduce.Name = "ArrayReduce";
            this.ArrayReduce.Size = new System.Drawing.Size(429, 26);
            this.ArrayReduce.TabIndex = 3;
            // 
            // ArrayRevert
            // 
            this.ArrayRevert.Location = new System.Drawing.Point(253, 264);
            this.ArrayRevert.Name = "ArrayRevert";
            this.ArrayRevert.Size = new System.Drawing.Size(429, 26);
            this.ArrayRevert.TabIndex = 4;
            // 
            // EO
            // 
            this.EO.Location = new System.Drawing.Point(253, 308);
            this.EO.Name = "EO";
            this.EO.Size = new System.Drawing.Size(429, 26);
            this.EO.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "mảng ban đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "mảng tăng dần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "mảng giảm dần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "mảng đảo";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "mảng chẳn tăng, mang lẻ giảm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số phần tử";
            // 
            // sizeArr
            // 
            this.sizeArr.Location = new System.Drawing.Point(133, 27);
            this.sizeArr.Name = "sizeArr";
            this.sizeArr.Size = new System.Drawing.Size(100, 26);
            this.sizeArr.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "tạo mảng ngẫu nhiên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "sắp xếp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sizeArr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EO);
            this.Controls.Add(this.ArrayRevert);
            this.Controls.Add(this.ArrayReduce);
            this.Controls.Add(this.ArrayIncrease);
            this.Controls.Add(this.originArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originArr;
        private System.Windows.Forms.TextBox ArrayIncrease;
        private System.Windows.Forms.TextBox ArrayReduce;
        private System.Windows.Forms.TextBox ArrayRevert;
        private System.Windows.Forms.TextBox EO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sizeArr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

