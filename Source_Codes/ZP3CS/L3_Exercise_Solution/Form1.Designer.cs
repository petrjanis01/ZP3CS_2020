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
            this.colorPanel = new System.Windows.Forms.Panel();
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
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(25, 120);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(212, 181);
            this.colorPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.showColorBtn);
            this.Controls.Add(this.colorDropDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox colorDropDown;
        private System.Windows.Forms.Button showColorBtn;
        private System.Windows.Forms.Panel colorPanel;
    }
}

