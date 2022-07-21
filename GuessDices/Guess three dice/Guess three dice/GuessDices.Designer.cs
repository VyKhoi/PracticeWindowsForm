namespace Guess_three_dice
{
    partial class GuessDices
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dice5 = new System.Windows.Forms.Button();
            this.Dice4 = new System.Windows.Forms.Button();
            this.Dice6 = new System.Windows.Forms.Button();
            this.Dice3 = new System.Windows.Forms.Button();
            this.Dice2 = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.Button();
            this.DiceChoose = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.roll = new System.Windows.Forms.Button();
            this.DiceResult = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timesLost = new System.Windows.Forms.Label();
            this.timesWin = new System.Windows.Forms.Label();
            this.CountTheNumberOfGamesPlayed = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiceChoose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiceResult)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Dice5);
            this.groupBox1.Controls.Add(this.Dice4);
            this.groupBox1.Controls.Add(this.Dice6);
            this.groupBox1.Controls.Add(this.Dice3);
            this.groupBox1.Controls.Add(this.Dice2);
            this.groupBox1.Controls.Add(this.Dice1);
            this.groupBox1.Controls.Add(this.DiceChoose);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đoán Số";
            // 
            // Dice5
            // 
            this.Dice5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice5.Location = new System.Drawing.Point(294, 91);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(61, 48);
            this.Dice5.TabIndex = 6;
            this.Dice5.Text = "5";
            this.Dice5.UseVisualStyleBackColor = false;
            this.Dice5.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice4
            // 
            this.Dice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice4.Location = new System.Drawing.Point(294, 37);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(61, 48);
            this.Dice4.TabIndex = 5;
            this.Dice4.Text = "4";
            this.Dice4.UseVisualStyleBackColor = false;
            this.Dice4.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice6
            // 
            this.Dice6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice6.Location = new System.Drawing.Point(294, 145);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(61, 48);
            this.Dice6.TabIndex = 4;
            this.Dice6.Text = "6";
            this.Dice6.UseVisualStyleBackColor = false;
            this.Dice6.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice3
            // 
            this.Dice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice3.Location = new System.Drawing.Point(20, 145);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(61, 48);
            this.Dice3.TabIndex = 3;
            this.Dice3.Text = "3";
            this.Dice3.UseVisualStyleBackColor = false;
            this.Dice3.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice2
            // 
            this.Dice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice2.Location = new System.Drawing.Point(20, 91);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(61, 48);
            this.Dice2.TabIndex = 2;
            this.Dice2.Text = "2";
            this.Dice2.UseVisualStyleBackColor = false;
            this.Dice2.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // Dice1
            // 
            this.Dice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Dice1.Location = new System.Drawing.Point(20, 37);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(61, 48);
            this.Dice1.TabIndex = 1;
            this.Dice1.Text = "1";
            this.Dice1.UseVisualStyleBackColor = false;
            this.Dice1.Click += new System.EventHandler(this.Dice1_Click);
            // 
            // DiceChoose
            // 
            this.DiceChoose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiceChoose.Location = new System.Drawing.Point(128, 46);
            this.DiceChoose.Name = "DiceChoose";
            this.DiceChoose.Size = new System.Drawing.Size(119, 127);
            this.DiceChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiceChoose.TabIndex = 0;
            this.DiceChoose.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.roll);
            this.groupBox2.Controls.Add(this.DiceResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quay số (sinh số ngẫu nhiên)";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Cyan;
            this.reset.Location = new System.Drawing.Point(231, 81);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(124, 53);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset(ESC)";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.BackColor = System.Drawing.Color.Cyan;
            this.roll.Location = new System.Drawing.Point(231, 26);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(124, 49);
            this.roll.TabIndex = 1;
            this.roll.Text = "Quay số(enter)";
            this.roll.UseVisualStyleBackColor = false;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // DiceResult
            // 
            this.DiceResult.Location = new System.Drawing.Point(20, 26);
            this.DiceResult.Name = "DiceResult";
            this.DiceResult.Size = new System.Drawing.Size(141, 108);
            this.DiceResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DiceResult.TabIndex = 0;
            this.DiceResult.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.timesLost);
            this.groupBox3.Controls.Add(this.timesWin);
            this.groupBox3.Controls.Add(this.CountTheNumberOfGamesPlayed);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // timesLost
            // 
            this.timesLost.AutoSize = true;
            this.timesLost.Location = new System.Drawing.Point(20, 107);
            this.timesLost.Name = "timesLost";
            this.timesLost.Size = new System.Drawing.Size(84, 20);
            this.timesLost.TabIndex = 2;
            this.timesLost.Text = "Lần thua : ";
            // 
            // timesWin
            // 
            this.timesWin.AutoSize = true;
            this.timesWin.Location = new System.Drawing.Point(20, 72);
            this.timesWin.Name = "timesWin";
            this.timesWin.Size = new System.Drawing.Size(93, 20);
            this.timesWin.TabIndex = 1;
            this.timesWin.Text = "Lần thắng : ";
            // 
            // CountTheNumberOfGamesPlayed
            // 
            this.CountTheNumberOfGamesPlayed.AutoSize = true;
            this.CountTheNumberOfGamesPlayed.Location = new System.Drawing.Point(20, 36);
            this.CountTheNumberOfGamesPlayed.Name = "CountTheNumberOfGamesPlayed";
            this.CountTheNumberOfGamesPlayed.Size = new System.Drawing.Size(87, 20);
            this.CountTheNumberOfGamesPlayed.TabIndex = 0;
            this.CountTheNumberOfGamesPlayed.Text = "Thống kê : ";
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 20;
            this.history.Location = new System.Drawing.Point(432, 27);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(383, 504);
            this.history.TabIndex = 3;
            // 
            // GuessDices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_three_dice.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(827, 652);
            this.Controls.Add(this.history);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuessDices";
            this.Text = "GuessDices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuessDices_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuessDices_FormClosed);
            this.Load += new System.EventHandler(this.GuessDices_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiceChoose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiceResult)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dice5;
        private System.Windows.Forms.Button Dice4;
        private System.Windows.Forms.Button Dice6;
        private System.Windows.Forms.Button Dice3;
        private System.Windows.Forms.Button Dice2;
        private System.Windows.Forms.Button Dice1;
        private System.Windows.Forms.PictureBox DiceChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.PictureBox DiceResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label timesLost;
        private System.Windows.Forms.Label timesWin;
        private System.Windows.Forms.Label CountTheNumberOfGamesPlayed;
        private System.Windows.Forms.ListBox history;
    }
}