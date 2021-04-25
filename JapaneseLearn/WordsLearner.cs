using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JapaneseLearn
{
    public partial class WordsLearner : Form
    {
        string[] words;
        int wordsCount;
        int currentIndex = -1;
        string[] currentSplitWord;
        bool activated = false;
        List<string> wordsToLearn;
        bool inverted = false;

        public WordsLearner()
        {
            InitializeComponent();
            wordsCount = 0;
            wordsToLearn = new List<string>();
        }

        public void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void NextWord()
        {
            if (wordsToLearn.Count == 0)
            {
                submitBtn.Enabled = false;
                restartBtn.Visible = true;
                return;
            }

            if (currentIndex + 1 == wordsToLearn.Count)
                currentIndex = 0;
            else
                currentIndex++;

            currentSplitWord = wordsToLearn[currentIndex].Split(' ');
            currentWordLabel.Text = currentSplitWord[0];
            hintJapLabel.Text = currentSplitWord[inverted? 2 : 1];
            hintJapLabel.Visible = false;
        }

        private void Restart()
        {
            inverted = !inverted;
            submitBtn.Enabled = true;
            restartBtn.Visible = false;
            if (wordsCount > 0)
            {
                wordsToLearn.AddRange(words);
                if (inverted)
                {
                    for (int i = 0; i < wordsToLearn.Count; i++)
                    {
                        string[] splitWord = wordsToLearn[i].Split(' ');
                        wordsToLearn[i] = String.Format("{0} {1} {2}", splitWord[2], splitWord[1], splitWord[0]);
                    }
                    Shuffle(wordsToLearn);
                    currentIndex = wordsToLearn.Count - 1;
                    NextWord();
                }
            }
        }

        private void LoadFunction()
        {
            if (File.Exists(WordsManager.save_file_name))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(WordsManager.save_file_name, FileMode.Open)))
                {
                    var itemsCount = reader.ReadInt32();
                    wordsCount = itemsCount;
                    words = new string[itemsCount];
                    for (var i = 0; i < itemsCount; i++)
                    {
                        words[i] = reader.ReadString();
                        wordsToLearn.Add(words[i]);
                    }

                    if (inverted)
                    {
                        for (int i = 0; i < wordsToLearn.Count; i++)
                        {
                            string[] splitWord = wordsToLearn[i].Split(' ');
                            wordsToLearn[i] = String.Format("{0} {1} {2}", splitWord[2], splitWord[1], splitWord[0]);
                        }
                    }

                    if (wordsCount > 0)
                        Shuffle(wordsToLearn);
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == currentSplitWord[2])
            {
                if (!hintJapLabel.Visible)
                {
                    wordsToLearn.RemoveAt(currentIndex);
                    --currentIndex;
                }
                NextWord();
                textBox1.Clear();
            }
            else
                hintJapLabel.Visible = true;
        }

        private void Learner_Activated(object sender, EventArgs e)
        {
            if (activated)
                return;

            activated = true;
            LoadFunction();
            NextWord();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
