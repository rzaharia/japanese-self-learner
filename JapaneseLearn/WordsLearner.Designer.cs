
namespace JapaneseLearn
{
    partial class WordsLearner
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
            this.currentWordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.hintJapLabel = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentWordLabel
            // 
            this.currentWordLabel.AutoSize = true;
            this.currentWordLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentWordLabel.Location = new System.Drawing.Point(354, 34);
            this.currentWordLabel.Name = "currentWordLabel";
            this.currentWordLabel.Size = new System.Drawing.Size(208, 86);
            this.currentWordLabel.TabIndex = 0;
            this.currentWordLabel.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(233, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 71);
            this.textBox1.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(422, 342);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(74, 30);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // hintJapLabel
            // 
            this.hintJapLabel.AutoSize = true;
            this.hintJapLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hintJapLabel.Location = new System.Drawing.Point(376, 133);
            this.hintJapLabel.Name = "hintJapLabel";
            this.hintJapLabel.Size = new System.Drawing.Size(155, 65);
            this.hintJapLabel.TabIndex = 3;
            this.hintJapLabel.Text = "label1";
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartBtn.Location = new System.Drawing.Point(518, 342);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(74, 30);
            this.restartBtn.TabIndex = 4;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // WordsLearner
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 657);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.hintJapLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.currentWordLabel);
            this.Name = "WordsLearner";
            this.Text = "Japanese learner - Words learner";
            this.Activated += new System.EventHandler(this.Learner_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentWordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label hintJapLabel;
        private System.Windows.Forms.Button restartBtn;
    }
}