namespace combolistbox
{
    partial class ComboListbox
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
            this.chooseColor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LToR = new System.Windows.Forms.Button();
            this.RToL = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 444);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(444, 140);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(236, 444);
            this.listBox2.TabIndex = 1;
            // 
            // inputItem
            // 
            this.inputItem.Location = new System.Drawing.Point(13, 34);
            this.inputItem.Name = "inputItem";
            this.inputItem.Size = new System.Drawing.Size(221, 26);
            this.inputItem.TabIndex = 2;
            // 
            // chooseColor
            // 
            this.chooseColor.FormattingEnabled = true;
            this.chooseColor.Location = new System.Drawing.Point(444, 34);
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(236, 28);
            this.chooseColor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LToR
            // 
            this.LToR.Location = new System.Drawing.Point(285, 172);
            this.LToR.Name = "LToR";
            this.LToR.Size = new System.Drawing.Size(123, 45);
            this.LToR.TabIndex = 5;
            this.LToR.Text = "==>";
            this.LToR.UseVisualStyleBackColor = true;
            // 
            // RToL
            // 
            this.RToL.Location = new System.Drawing.Point(285, 246);
            this.RToL.Name = "RToL";
            this.RToL.Size = new System.Drawing.Size(123, 45);
            this.RToL.TabIndex = 6;
            this.RToL.Text = "<==";
            this.RToL.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(285, 337);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(123, 45);
            this.remove.TabIndex = 7;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(285, 428);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(123, 45);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "ClearAll";
            this.clearAll.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(285, 506);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 45);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // ComboListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 654);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.RToL);
            this.Controls.Add(this.LToR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chooseColor);
            this.Controls.Add(this.inputItem);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "ComboListbox";
            this.Text = "ComboListbox";
            this.Load += new System.EventHandler(this.ComboListbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox inputItem;
        private System.Windows.Forms.ComboBox chooseColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LToR;
        private System.Windows.Forms.Button RToL;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button exit;
    }
}