using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lecture3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dictionary;

        public Form1()
        {
            dictionary = new Dictionary<string, string>();

            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var word = wordTextBox.Text;
            var explanation = explanationTextBox.Text;

            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(explanation))
            {
                MessageBox.Show(@"Word and explanation fields are mandatory.");
                return;
            }

            // adds new value to dictionary
            if (dictionary.ContainsKey(word))
            {
                MessageBox.Show(@"Word is already saved in dictionary.");
                return;
            }

            dictionary.Add(word, explanation);

            // resets text boxes
            wordTextBox.Text = string.Empty;
            explanationTextBox.Text = string.Empty;
        }
    }
}
