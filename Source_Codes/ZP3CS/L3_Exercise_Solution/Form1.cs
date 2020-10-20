using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace L3_Exercise_Solution
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, Color> _colors;

        public Form1()
        {
            _colors = new Dictionary<string, Color>();
            InitializeComponent();
            LoadColors();
            AddColorsToDropDown();

            // Initialize controls before first change in text boxes happens.
            ColorChanged();
        }

        // Adds predefined colors to drop down.
        private void LoadColors()
        {
            _colors.Add("Black", Color.Black);
            _colors.Add("Blue", Color.Blue);
            _colors.Add("Green", Color.Green);
        }

        private void AddColorsToDropDown()
        {
            foreach (var color in _colors)
            {
                colorDropDown.Items.Add(color.Key);
            }
        }

        private void ShowColorBtn_Click(object sender, EventArgs e)
        {
            var selectedColorText = colorDropDown.SelectedItem.ToString();

            // Gets value from dictionary by it's key. In our case it's name of the color.
            dropDownListColorPanel.BackColor = _colors[selectedColorText];
        }

        private void TextBoxRed_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxValue(textBoxRed);

            ColorChanged();
        }

        private void TextBoxBlue_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxValue(textBoxBlue);

            ColorChanged();
        }

        private void TextBoxGreen_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxValue(textBoxGreen);

            ColorChanged();
        }

        // Easier ways to do this. But not cover on lecture yet.
        private void ValidateTextBoxValue(TextBox textBox)
        {
            try
            {
                var number = int.Parse(textBox.Text);
                if (number < 0 || number > 255)
                {
                    SetTextBoxValueToZero(textBox);
                }
            }
            catch (Exception)
            {
                SetTextBoxValueToZero(textBox);
            }
        }

        private void SetTextBoxValueToZero(TextBox textBox)
        {
            textBox.Text = "0";
        }


        private void ColorChanged()
        {
            // Creates new color from entered values inside text boxes. 
            var color = Color.FromArgb(
                int.Parse(textBoxRed.Text),
                int.Parse(textBoxGreen.Text),
                int.Parse(textBoxBlue.Text));

            // Shows color in panel.
            RGBColorPanel.BackColor = color;
        }

        private void SaveColorButton_Click(object sender, EventArgs e)
        {
            // Checks if name of color is filled and is unique. Otherwise shows message box.
            if (string.IsNullOrEmpty(textBoxColorName.Text) == false &&
                _colors.ContainsKey(textBoxColorName.Text) == false)
            {
                var newColor = Color.FromArgb(
                    int.Parse(textBoxRed.Text),
                    int.Parse(textBoxGreen.Text),
                    int.Parse(textBoxBlue.Text));

                // Adds color with it's name into collection _colors.
                _colors.Add(textBoxColorName.Text, newColor);

                // Add color name into drop down list.
                colorDropDown.Items.Add(textBoxColorName.Text);

                // Resets user controls.
                textBoxColorName.Text = string.Empty;
                SetTextBoxValueToZero(textBoxRed);
                SetTextBoxValueToZero(textBoxGreen);
                SetTextBoxValueToZero(textBoxBlue);
            }
            else
            {
                MessageBox.Show(@"Name of color has to be defined and has to be unique.");
            }
        }
    }
}
