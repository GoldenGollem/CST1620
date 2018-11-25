namespace _07SentenceGeneration
{
    partial class FrmMain
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
            this.lbxSentences = new System.Windows.Forms.ListBox();
            this.btGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSentences
            // 
            this.lbxSentences.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSentences.FormattingEnabled = true;
            this.lbxSentences.ItemHeight = 19;
            this.lbxSentences.Location = new System.Drawing.Point(13, 13);
            this.lbxSentences.Name = "lbxSentences";
            this.lbxSentences.Size = new System.Drawing.Size(316, 156);
            this.lbxSentences.TabIndex = 0;
            this.lbxSentences.TabStop = false;
            // 
            // btGenerator
            // 
            this.btGenerator.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerator.Location = new System.Drawing.Point(40, 183);
            this.btGenerator.Name = "btGenerator";
            this.btGenerator.Size = new System.Drawing.Size(262, 61);
            this.btGenerator.TabIndex = 1;
            this.btGenerator.Text = "Generate";
            this.btGenerator.UseVisualStyleBackColor = true;
            this.btGenerator.Click += new System.EventHandler(this.btGenerator_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 265);
            this.Controls.Add(this.btGenerator);
            this.Controls.Add(this.lbxSentences);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Sentence Generation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSentences;
        private System.Windows.Forms.Button btGenerator;
    }
}

