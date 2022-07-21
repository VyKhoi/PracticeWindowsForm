namespace OpenFile
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
            this.ChoseFile = new System.Windows.Forms.Button();
            this.chooseFiles = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ShowFile = new System.Windows.Forms.ListBox();
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.files = new System.Windows.Forms.OpenFileDialog();
            this.chooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseColor = new System.Windows.Forms.ColorDialog();
            this.chooseFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // ChoseFile
            // 
            this.ChoseFile.Location = new System.Drawing.Point(12, 34);
            this.ChoseFile.Name = "ChoseFile";
            this.ChoseFile.Size = new System.Drawing.Size(136, 43);
            this.ChoseFile.TabIndex = 0;
            this.ChoseFile.Text = "chon 1 file";
            this.ChoseFile.UseVisualStyleBackColor = true;
            this.ChoseFile.Click += new System.EventHandler(this.ChoseFile_Click);
            // 
            // chooseFiles
            // 
            this.chooseFiles.Location = new System.Drawing.Point(12, 110);
            this.chooseFiles.Name = "chooseFiles";
            this.chooseFiles.Size = new System.Drawing.Size(136, 43);
            this.chooseFiles.TabIndex = 1;
            this.chooseFiles.Text = "chon nhieu file";
            this.chooseFiles.UseVisualStyleBackColor = true;
            this.chooseFiles.Click += new System.EventHandler(this.chooseFiles_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "chon thu muc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "chon mau nen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "chon mau chu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 423);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "chon font";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(232, 423);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(136, 43);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(443, 423);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 43);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ShowFile
            // 
            this.ShowFile.FormattingEnabled = true;
            this.ShowFile.ItemHeight = 20;
            this.ShowFile.Location = new System.Drawing.Point(215, 43);
            this.ShowFile.Name = "ShowFile";
            this.ShowFile.Size = new System.Drawing.Size(614, 364);
            this.ShowFile.TabIndex = 8;
            // 
            // file
            // 
            this.file.FileName = "file";
            // 
            // files
            // 
            this.files.FileName = "openFileDialog1";
            this.files.Multiselect = true;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Description = "chon 1 thu muc";
            // 
            // chooseColor
            // 
            this.chooseColor.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 498);
            this.Controls.Add(this.ShowFile);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chooseFiles);
            this.Controls.Add(this.ChoseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChoseFile;
        private System.Windows.Forms.Button chooseFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox ShowFile;
        private System.Windows.Forms.OpenFileDialog file;
        private System.Windows.Forms.OpenFileDialog files;
        private System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.ColorDialog chooseColor;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.FontDialog chooseFont;
    }
}

