using System.Media;

namespace _0610GuessAWord
{
    partial class FormMain
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
            this.lbHiddenWord = new System.Windows.Forms.Label();
            this.lbGuessALetter = new System.Windows.Forms.Label();
            this.lbNumTries = new System.Windows.Forms.Label();
            this.txtGuessLetter = new System.Windows.Forms.TextBox();
            this.txtTries = new System.Windows.Forms.TextBox();
            this.btGuess = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLettersUsed = new System.Windows.Forms.Label();
            this.txtLettersUsed = new System.Windows.Forms.TextBox();
            this.txtUnusedLetters = new System.Windows.Forms.TextBox();
            this.lbUnusedLetters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHiddenWord
            // 
            this.lbHiddenWord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHiddenWord.Location = new System.Drawing.Point(9, 4);
            this.lbHiddenWord.Name = "lbHiddenWord";
            this.lbHiddenWord.Size = new System.Drawing.Size(127, 20);
            this.lbHiddenWord.TabIndex = 0;
            this.lbHiddenWord.Text = "Hidden Word";
            this.lbHiddenWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbGuessALetter
            // 
            this.lbGuessALetter.AutoSize = true;
            this.lbGuessALetter.Location = new System.Drawing.Point(16, 30);
            this.lbGuessALetter.Name = "lbGuessALetter";
            this.lbGuessALetter.Size = new System.Drawing.Size(82, 13);
            this.lbGuessALetter.TabIndex = 1;
            this.lbGuessALetter.Text = "Guess a Letter: ";
            // 
            // lbNumTries
            // 
            this.lbNumTries.AutoSize = true;
            this.lbNumTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumTries.Location = new System.Drawing.Point(15, 87);
            this.lbNumTries.Name = "lbNumTries";
            this.lbNumTries.Size = new System.Drawing.Size(81, 13);
            this.lbNumTries.TabIndex = 2;
            this.lbNumTries.Text = "Number of tries:";
            // 
            // txtGuessLetter
            // 
            this.txtGuessLetter.AcceptsReturn = true;
            this.txtGuessLetter.Location = new System.Drawing.Point(102, 27);
            this.txtGuessLetter.Name = "txtGuessLetter";
            this.txtGuessLetter.Size = new System.Drawing.Size(34, 20);
            this.txtGuessLetter.TabIndex = 3;
            this.txtGuessLetter.TextChanged += new System.EventHandler(this.txtGuessLetter_TextChanged);
            // 
            // txtTries
            // 
            this.txtTries.BackColor = System.Drawing.SystemColors.Control;
            this.txtTries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTries.Enabled = false;
            this.txtTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTries.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTries.Location = new System.Drawing.Point(102, 84);
            this.txtTries.Name = "txtTries";
            this.txtTries.Size = new System.Drawing.Size(34, 13);
            this.txtTries.TabIndex = 4;
            this.txtTries.TabStop = false;
            // 
            // btGuess
            // 
            this.btGuess.Enabled = false;
            this.btGuess.Location = new System.Drawing.Point(13, 53);
            this.btGuess.Name = "btGuess";
            this.btGuess.Size = new System.Drawing.Size(123, 25);
            this.btGuess.TabIndex = 5;
            this.btGuess.Text = "Guess";
            this.btGuess.UseVisualStyleBackColor = true;
            this.btGuess.Click += new System.EventHandler(this.btGuess_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(13, 140);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(123, 30);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(16, 112);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(120, 25);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Status Message";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLettersUsed
            // 
            this.lbLettersUsed.AutoSize = true;
            this.lbLettersUsed.Enabled = false;
            this.lbLettersUsed.Location = new System.Drawing.Point(150, 8);
            this.lbLettersUsed.Name = "lbLettersUsed";
            this.lbLettersUsed.Size = new System.Drawing.Size(70, 13);
            this.lbLettersUsed.TabIndex = 8;
            this.lbLettersUsed.Text = "Letters Used:";
            // 
            // txtLettersUsed
            // 
            this.txtLettersUsed.BackColor = System.Drawing.SystemColors.Control;
            this.txtLettersUsed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLettersUsed.Enabled = false;
            this.txtLettersUsed.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLettersUsed.Location = new System.Drawing.Point(153, 27);
            this.txtLettersUsed.Multiline = true;
            this.txtLettersUsed.Name = "txtLettersUsed";
            this.txtLettersUsed.Size = new System.Drawing.Size(127, 51);
            this.txtLettersUsed.TabIndex = 9;
            // 
            // txtUnusedLetters
            // 
            this.txtUnusedLetters.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnusedLetters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnusedLetters.Enabled = false;
            this.txtUnusedLetters.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnusedLetters.Location = new System.Drawing.Point(153, 112);
            this.txtUnusedLetters.Multiline = true;
            this.txtUnusedLetters.Name = "txtUnusedLetters";
            this.txtUnusedLetters.Size = new System.Drawing.Size(127, 51);
            this.txtUnusedLetters.TabIndex = 11;
            // 
            // lbUnusedLetters
            // 
            this.lbUnusedLetters.AutoSize = true;
            this.lbUnusedLetters.Enabled = false;
            this.lbUnusedLetters.Location = new System.Drawing.Point(150, 93);
            this.lbUnusedLetters.Name = "lbUnusedLetters";
            this.lbUnusedLetters.Size = new System.Drawing.Size(93, 13);
            this.lbUnusedLetters.TabIndex = 10;
            this.lbUnusedLetters.Text = "Letters  Not Used:";
            // 
            // FormMain
            // 
            this.AcceptButton = this.btGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.txtUnusedLetters);
            this.Controls.Add(this.lbUnusedLetters);
            this.Controls.Add(this.txtLettersUsed);
            this.Controls.Add(this.lbLettersUsed);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btGuess);
            this.Controls.Add(this.txtTries);
            this.Controls.Add(this.txtGuessLetter);
            this.Controls.Add(this.lbNumTries);
            this.Controls.Add(this.lbGuessALetter);
            this.Controls.Add(this.lbHiddenWord);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Guess A Word";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            //Startup Sound
            new SoundPlayer(_0610GuessAWord.Properties.Resources.helloWorld).Play();
        }

        #endregion

        private System.Windows.Forms.Label lbHiddenWord;
        private System.Windows.Forms.Label lbGuessALetter;
        private System.Windows.Forms.Label lbNumTries;
        private System.Windows.Forms.TextBox txtGuessLetter;
        private System.Windows.Forms.TextBox txtTries;
        private System.Windows.Forms.Button btGuess;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbLettersUsed;
        private System.Windows.Forms.TextBox txtLettersUsed;
        private System.Windows.Forms.TextBox txtUnusedLetters;
        private System.Windows.Forms.Label lbUnusedLetters;
    }
}

