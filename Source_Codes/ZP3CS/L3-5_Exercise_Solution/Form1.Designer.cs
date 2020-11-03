namespace L3_Exercise_Solution
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
            this.colorDropDown = new System.Windows.Forms.ComboBox();
            this.showColorBtn = new System.Windows.Forms.Button();
            this.dropDownListColorPanel = new System.Windows.Forms.Panel();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.RGBColorPanel = new System.Windows.Forms.Panel();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxColorName = new System.Windows.Forms.TextBox();
            this.saveColorButton = new System.Windows.Forms.Button();
            this.htmlColorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveColorToFileButton = new System.Windows.Forms.Button();
            this.loadColorsFromFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.htmlColorConvertedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorDropDown
            // 
            this.colorDropDown.FormattingEnabled = true;
            this.colorDropDown.Location = new System.Drawing.Point(25, 15);
            this.colorDropDown.Name = "colorDropDown";
            this.colorDropDown.Size = new System.Drawing.Size(213, 21);
            this.colorDropDown.TabIndex = 0;
            // 
            // showColorBtn
            // 
            this.showColorBtn.Location = new System.Drawing.Point(25, 53);
            this.showColorBtn.Name = "showColorBtn";
            this.showColorBtn.Size = new System.Drawing.Size(212, 23);
            this.showColorBtn.TabIndex = 1;
            this.showColorBtn.Text = "Show selected color";
            this.showColorBtn.UseVisualStyleBackColor = true;
            this.showColorBtn.Click += new System.EventHandler(this.ShowColorBtn_Click);
            // 
            // dropDownListColorPanel
            // 
            this.dropDownListColorPanel.Location = new System.Drawing.Point(25, 120);
            this.dropDownListColorPanel.Name = "dropDownListColorPanel";
            this.dropDownListColorPanel.Size = new System.Drawing.Size(212, 181);
            this.dropDownListColorPanel.TabIndex = 2;
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(346, 16);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(100, 20);
            this.textBoxRed.TabIndex = 3;
            this.textBoxRed.Text = "0";
            this.textBoxRed.TextChanged += new System.EventHandler(this.TextBoxRed_TextChanged);
            // 
            // RGBColorPanel
            // 
            this.RGBColorPanel.Location = new System.Drawing.Point(409, 53);
            this.RGBColorPanel.Name = "RGBColorPanel";
            this.RGBColorPanel.Size = new System.Drawing.Size(212, 181);
            this.RGBColorPanel.TabIndex = 4;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(602, 16);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(100, 20);
            this.textBoxBlue.TabIndex = 5;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.TextBoxBlue_TextChanged);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(475, 16);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(100, 20);
            this.textBoxGreen.TabIndex = 6;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.TextBoxGreen_TextChanged);
            // 
            // textBoxColorName
            // 
            this.textBoxColorName.Location = new System.Drawing.Point(409, 253);
            this.textBoxColorName.Name = "textBoxColorName";
            this.textBoxColorName.Size = new System.Drawing.Size(100, 20);
            this.textBoxColorName.TabIndex = 7;
            // 
            // saveColorButton
            // 
            this.saveColorButton.Location = new System.Drawing.Point(546, 250);
            this.saveColorButton.Name = "saveColorButton";
            this.saveColorButton.Size = new System.Drawing.Size(75, 23);
            this.saveColorButton.TabIndex = 8;
            this.saveColorButton.Text = "Save Color";
            this.saveColorButton.UseVisualStyleBackColor = true;
            this.saveColorButton.Click += new System.EventHandler(this.SaveColorButton_Click);
            // 
            // htmlColorLabel
            // 
            this.htmlColorLabel.AutoSize = true;
            this.htmlColorLabel.Location = new System.Drawing.Point(454, 288);
            this.htmlColorLabel.Name = "htmlColorLabel";
            this.htmlColorLabel.Size = new System.Drawing.Size(10, 13);
            this.htmlColorLabel.TabIndex = 9;
            this.htmlColorLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Color Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 288);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Html color";
            // 
            // saveColorToFileButton
            // 
            this.saveColorToFileButton.Location = new System.Drawing.Point(346, 355);
            this.saveColorToFileButton.Name = "saveColorToFileButton";
            this.saveColorToFileButton.Size = new System.Drawing.Size(123, 21);
            this.saveColorToFileButton.TabIndex = 15;
            this.saveColorToFileButton.Text = "Save Colors To File";
            this.saveColorToFileButton.UseVisualStyleBackColor = true;
            this.saveColorToFileButton.Click += new System.EventHandler(this.SaveColorToFileButton_Click);
            // 
            // loadColorsFromFileButton
            // 
            this.loadColorsFromFileButton.Location = new System.Drawing.Point(521, 355);
            this.loadColorsFromFileButton.Name = "loadColorsFromFileButton";
            this.loadColorsFromFileButton.Size = new System.Drawing.Size(127, 21);
            this.loadColorsFromFileButton.TabIndex = 16;
            this.loadColorsFromFileButton.Text = "Load Colors From File";
            this.loadColorsFromFileButton.UseVisualStyleBackColor = true;
            this.loadColorsFromFileButton.Click += new System.EventHandler(this.LoadColorsFromFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 318);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Html Color Converted";
            // 
            // htmlColorConvertedLabel
            // 
            this.htmlColorConvertedLabel.AutoSize = true;
            this.htmlColorConvertedLabel.Location = new System.Drawing.Point(456, 318);
            this.htmlColorConvertedLabel.Name = "htmlColorConvertedLabel";
            this.htmlColorConvertedLabel.Size = new System.Drawing.Size(10, 13);
            this.htmlColorConvertedLabel.TabIndex = 17;
            this.htmlColorConvertedLabel.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htmlColorConvertedLabel);
            this.Controls.Add(this.loadColorsFromFileButton);
            this.Controls.Add(this.saveColorToFileButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.htmlColorLabel);
            this.Controls.Add(this.saveColorButton);
            this.Controls.Add(this.textBoxColorName);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.RGBColorPanel);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.dropDownListColorPanel);
            this.Controls.Add(this.showColorBtn);
            this.Controls.Add(this.colorDropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox colorDropDown;
        private System.Windows.Forms.Button showColorBtn;
        private System.Windows.Forms.Panel dropDownListColorPanel;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.Panel RGBColorPanel;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxColorName;
        private System.Windows.Forms.Button saveColorButton;
        private System.Windows.Forms.Label htmlColorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveColorToFileButton;
        private System.Windows.Forms.Button loadColorsFromFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label htmlColorConvertedLabel;
    }
}

