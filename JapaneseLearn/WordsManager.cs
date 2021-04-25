using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JapaneseLearn
{
    public partial class WordsManager : Form
    {
        public static string save_file_name = "jap.dat";

        public WordsManager()
        {
            InitializeComponent();
        }
        private int check_word_exists_get_index(String word)
        {
            int itemsCount = listBox1.Items.Count;
            for (int i = 0; i < itemsCount; i++)
            {
                if (listBox1.Items[i].ToString().Split(' ')[0] == word)
                    return i;
            }

            return -1;
        }

        private bool checkItemIsValid(string item)
        {
            if (item.Count(x => x == ' ') != 2)
            {
                MessageBox.Show("Expected 2 spaces!", "Err");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string current_text = textBox1.Text;
            if (!checkItemIsValid(current_text))
                return;
            string[] split_text = current_text.Split(' ');
            if (check_word_exists_get_index(split_text[0]) == -1)
            {
                MessageBox.Show("Word already exists!", "Err");
                return;
            }

            listBox1.Items.Add(current_text);
            textBox1.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFunction();
        }

        private void SaveFunction()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(save_file_name, FileMode.Create)))
            {
                writer.Write(listBox1.Items.Count);
                foreach (var item in listBox1.Items)
                    writer.Write(item.ToString());
            }
        }

        private void LoadFunction()
        {
            if (File.Exists(save_file_name))
            {
                listBox1.Items.Clear();
                using (BinaryReader reader = new BinaryReader(File.Open(save_file_name, FileMode.Open)))
                {
                    var itemsCount = reader.ReadInt32();
                    for (var i = 0; i < itemsCount; i++)
                        listBox1.Items.Add(reader.ReadString());

                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadFunction();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFunction();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LoadFunction();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string current_text = textBox1.Text;
            if (!checkItemIsValid(current_text))
                return;
            string[] split_text = current_text.Split(' ');
            int index = check_word_exists_get_index(split_text[0]);
            if(index==-1)
            {
                MessageBox.Show("Failed to find word!", "Err");
                return;
            }

            listBox1.Items[index] = current_text;
            listBox1.Update();
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            WordsLearner learner = new WordsLearner();
            learner.ShowDialog();
        }
    }
}
