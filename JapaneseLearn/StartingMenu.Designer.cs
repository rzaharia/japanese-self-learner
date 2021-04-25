
namespace JapaneseLearn
{
    partial class StartingMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.manageWordsButton = new System.Windows.Forms.Button();
            this.learnWordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Japanese learner";
            // 
            // manageWordsButton
            // 
            this.manageWordsButton.Location = new System.Drawing.Point(163, 104);
            this.manageWordsButton.Name = "manageWordsButton";
            this.manageWordsButton.Size = new System.Drawing.Size(93, 31);
            this.manageWordsButton.TabIndex = 1;
            this.manageWordsButton.Text = "Mange words";
            this.manageWordsButton.UseVisualStyleBackColor = true;
            this.manageWordsButton.Click += new System.EventHandler(this.manageWordsButton_Click);
            // 
            // learnWordsButton
            // 
            this.learnWordsButton.Location = new System.Drawing.Point(284, 104);
            this.learnWordsButton.Name = "learnWordsButton";
            this.learnWordsButton.Size = new System.Drawing.Size(93, 31);
            this.learnWordsButton.TabIndex = 2;
            this.learnWordsButton.Text = "Learn words";
            this.learnWordsButton.UseVisualStyleBackColor = true;
            this.learnWordsButton.Click += new System.EventHandler(this.learnWordsButton_Click);
            // 
            // StartingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 189);
            this.Controls.Add(this.learnWordsButton);
            this.Controls.Add(this.manageWordsButton);
            this.Controls.Add(this.label1);
            this.Name = "StartingMenu";
            this.Text = "Japanese learner - StartingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageWordsButton;
        private System.Windows.Forms.Button learnWordsButton;
    }
}