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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.inputItem = new System.Windows.Forms.TextBox();
            this.ColorList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LToR = new System.Windows.Forms.Button();
            this.RToL = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Nam Heo",
            "Khoi hehe",
            "Luan Map dit"});
            this.listBox1.Location = new System.Drawing.Point(33, 145);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(209, 484);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.ForeColor = System.Drawing.Color.Red;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(407, 145);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(209, 484);
            this.listBox2.TabIndex = 1;
            // 
            // inputItem
            // 
            this.inputItem.Location = new System.Drawing.Point(33, 44);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(209, 26);
            this.inputItem.TabIndex = 2;
            // 
            // ColorList
            // 
            this.ColorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorList.FormattingEnabled = true;
            this.ColorList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Black"});
            this.ColorList.Location = new System.Drawing.Point(407, 41);
            this.ColorList.Name = "ColorList";
            this.ColorList.Size = new System.Drawing.Size(209, 28);
            this.ColorList.TabIndex = 3;
            this.ColorList.SelectedIndexChanged += new System.EventHandler(this.ColorList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LToR
            // 
            this.LToR.Location = new System.Drawing.Point(285, 192);
            this.LToR.Name = "LToR";
            this.LToR.Size = new System.Drawing.Size(93, 27);
            this.LToR.TabIndex = 5;
            this.LToR.Text = "==>";
            this.LToR.UseVisualStyleBackColor = true;
            this.LToR.Click += new System.EventHandler(this.LToR_Click);
            // 
            // RToL
            // 
            this.RToL.Location = new System.Drawing.Point(285, 265);
            this.RToL.Name = "RToL";
            this.RToL.Size = new System.Drawing.Size(93, 27);
            this.RToL.TabIndex = 6;
            this.RToL.Text = "<==";
            this.RToL.UseVisualStyleBackColor = true;
            this.RToL.Click += new System.EventHandler(this.RToL_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(285, 327);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(93, 27);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(285, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 27);
            this.button5.TabIndex = 8;
            this.button5.Text = "ClearAll";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(285, 473);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 27);
            this.button6.TabIndex = 9;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 692);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.RToL);
            this.Controls.Add(this.LToR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColorList);
            this.Controls.Add(this.inputItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox inputItem;
        private System.Windows.Forms.ComboBox ColorList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LToR;
        private System.Windows.Forms.Button RToL;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

