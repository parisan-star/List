namespace List
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
            this.TxtGetText = new System.Windows.Forms.TextBox();
            this.TxtGetChar = new System.Windows.Forms.TextBox();
            this.BtnCountWord = new System.Windows.Forms.Button();
            this.BtnCountLetter = new System.Windows.Forms.Button();
            this.BtnWordList = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.LblChar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtGetText
            // 
            this.TxtGetText.Location = new System.Drawing.Point(155, 88);
            this.TxtGetText.Multiline = true;
            this.TxtGetText.Name = "TxtGetText";
            this.TxtGetText.Size = new System.Drawing.Size(260, 66);
            this.TxtGetText.TabIndex = 0;
            // 
            // TxtGetChar
            // 
            this.TxtGetChar.Location = new System.Drawing.Point(155, 175);
            this.TxtGetChar.Multiline = true;
            this.TxtGetChar.Name = "TxtGetChar";
            this.TxtGetChar.Size = new System.Drawing.Size(260, 66);
            this.TxtGetChar.TabIndex = 1;
            // 
            // BtnCountWord
            // 
            this.BtnCountWord.Location = new System.Drawing.Point(330, 322);
            this.BtnCountWord.Name = "BtnCountWord";
            this.BtnCountWord.Size = new System.Drawing.Size(110, 50);
            this.BtnCountWord.TabIndex = 2;
            this.BtnCountWord.Text = "تعداد کلمه";
            this.BtnCountWord.UseVisualStyleBackColor = true;
            this.BtnCountWord.Click += new System.EventHandler(this.BtnCountWord_Click);
            // 
            // BtnCountLetter
            // 
            this.BtnCountLetter.Location = new System.Drawing.Point(219, 322);
            this.BtnCountLetter.Name = "BtnCountLetter";
            this.BtnCountLetter.Size = new System.Drawing.Size(110, 50);
            this.BtnCountLetter.TabIndex = 3;
            this.BtnCountLetter.Text = "تعداد حرف";
            this.BtnCountLetter.UseVisualStyleBackColor = true;
            this.BtnCountLetter.Click += new System.EventHandler(this.BtnCountLetter_Click);
            // 
            // BtnWordList
            // 
            this.BtnWordList.Location = new System.Drawing.Point(110, 322);
            this.BtnWordList.Name = "BtnWordList";
            this.BtnWordList.Size = new System.Drawing.Size(110, 50);
            this.BtnWordList.TabIndex = 4;
            this.BtnWordList.Text = "لیست کلمات";
            this.BtnWordList.UseVisualStyleBackColor = true;
            this.BtnWordList.Click += new System.EventHandler(this.BtnWordList_Click);
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(445, 99);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(173, 41);
            this.LblText.TabIndex = 5;
            this.LblText.Text = "متن";
            // 
            // LblChar
            // 
            this.LblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChar.Location = new System.Drawing.Point(445, 197);
            this.LblChar.Name = "LblChar";
            this.LblChar.Size = new System.Drawing.Size(96, 35);
            this.LblChar.TabIndex = 6;
            this.LblChar.Text = "کاراکتر";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 466);
            this.Controls.Add(this.LblChar);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnWordList);
            this.Controls.Add(this.BtnCountLetter);
            this.Controls.Add(this.BtnCountWord);
            this.Controls.Add(this.TxtGetChar);
            this.Controls.Add(this.TxtGetText);
            this.Name = "Form1";
            this.Text = "Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGetChar;
        private System.Windows.Forms.Button BtnCountWord;
        private System.Windows.Forms.Button BtnCountLetter;
        private System.Windows.Forms.Button BtnWordList;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Label LblChar;
        public System.Windows.Forms.TextBox TxtGetText;
    }
}

