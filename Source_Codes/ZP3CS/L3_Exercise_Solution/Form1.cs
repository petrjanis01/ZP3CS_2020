using System;
using System.Drawing;
using System.Windows.Forms;

namespace L3_Exercise_Solution
{
    public partial class Form1 : Form
    {
        private Color[] _colors;

        public Form1()
        {
            InitializeComponent();

            LoadColors();
            AddColorsToDropDown();
        }

        private void LoadColors()
        {
            _colors = new Color[4];
            _colors[0] = Color.Black;
            _colors[1] = Color.Blue;
            _colors[2] = Color.Green;

            // Creates struct color from 3 integers (R,G,B).
            var color = Color.FromArgb(255, 170, 170);
            _colors[3] = color;
        }

        private void AddColorsToDropDown()
        {
            foreach (var color in _colors)
            {
                // Items is property that represents items that will be shown to user in drop down.
                colorDropDown.Items.Add(color);
            }
        }

        private void ShowColorBtn_Click(object sender, EventArgs e)
        {
            var selectedColor = (Color)colorDropDown.SelectedItem;
            colorPanel.BackColor = selectedColor;
        }
    }
}
