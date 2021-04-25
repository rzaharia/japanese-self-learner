using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JapaneseLearn
{
    public partial class StartingMenu : Form
    {
        public StartingMenu()
        {
            InitializeComponent();
        }

        private void manageWordsButton_Click(object sender, EventArgs e)
        {
            new WordsManager().ShowDialog();
        }

        private void learnWordsButton_Click(object sender, EventArgs e)
        {
            new WordsLearner().ShowDialog();
        }
    }
}
