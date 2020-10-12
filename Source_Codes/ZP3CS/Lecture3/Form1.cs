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
            // Method defined in second part of partial class => Form1.Designer.cs
            // Renders controls when application starts => How tey will look is defined in generated code.
            InitializeComponent();

            dictionary = new Dictionary<string, string>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TextBox component for word input (left one) has name property in design set to "wordTextBox".
            // This means that variable that will contain reference to instance of class TextBox representing that
            // left text box will be named "wordTextBox"
            // Next line reads value of it's property Text (can be set by user).
            var word = wordTextBox.Text;
            var explanation = explanationTextBox.Text;

            // Checks if strings in text boxes are filled.
            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(explanation))
            {
                // Shows message with given text.
                MessageBox.Show(@"Word and explanation fields are mandatory.");
                return;
            }

            if (dictionary.ContainsKey(word))
            {
                MessageBox.Show(@"Word is already saved in dictionary.");
                return;
            }

            // Adds new value to dictionary Where key will be word and value explanation.
            dictionary.Add(word, explanation);

            // Resets text boxes => sets it's text properties to empty string ("")
            wordTextBox.Text = string.Empty;
            explanationTextBox.Text = string.Empty;
        }

        // TODO add another text box for search
        // TODO add button that reads value from text box and shows dialog with explanation for that word
    }
}
