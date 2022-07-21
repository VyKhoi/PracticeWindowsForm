namespace Guess_three_dice
{
    partial class rollDice
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
            this.components = new System.ComponentModel.Container();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.namePerson = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.result = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(57, 58);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(150, 150);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1.TabIndex = 0;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(320, 58);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(150, 150);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2.TabIndex = 1;
            this.dice2.TabStop = false;
            // 
            // dice3
            // 
            this.dice3.Location = new System.Drawing.Point(551, 58);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(150, 150);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice3.TabIndex = 2;
            this.dice3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(147, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "roll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // namePerson
            // 
            this.namePerson.AutoSize = true;
            this.namePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePerson.ForeColor = System.Drawing.Color.Black;
            this.namePerson.Location = new System.Drawing.Point(238, 9);
            this.namePerson.Name = "namePerson";
            this.namePerson.Size = new System.Drawing.Size(307, 29);
            this.namePerson.TabIndex = 6;
            this.namePerson.Text = "2051052066 - Dang Vy Khoi";
            this.namePerson.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.namePerson);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 53);
            this.panel1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(281, 228);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(190, 55);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(561, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 64);
            this.button3.TabIndex = 8;
            this.button3.Text = "Click Here To Go to play gues dice";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rollDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_three_dice.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 472);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Name = "rollDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label namePerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button3;
    }
}

