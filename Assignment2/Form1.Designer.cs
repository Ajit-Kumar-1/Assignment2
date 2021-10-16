
namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectionScreen1 = new System.Windows.Forms.Panel();
            this.workshopSelector = new System.Windows.Forms.ListBox();
            this.selectionScreen1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionScreen1
            // 
            this.selectionScreen1.Controls.Add(this.workshopSelector);
            this.selectionScreen1.Location = new System.Drawing.Point(0, 0);
            this.selectionScreen1.Margin = new System.Windows.Forms.Padding(0);
            this.selectionScreen1.Name = "selectionScreen1";
            this.selectionScreen1.Size = new System.Drawing.Size(1104, 978);
            this.selectionScreen1.TabIndex = 0;
            // 
            // workshopSelector
            // 
            this.workshopSelector.FormattingEnabled = true;
            this.workshopSelector.ItemHeight = 32;
            this.workshopSelector.Items.AddRange(new object[] {
            "C£ Fundamentals",
            "C£ Basics for Beginners",
            "C£ Intermediate",
            "C£ Advanced Topics",
            "ASP.NET with C£ Part A",
            "ASP.NET with C£ Part B"});
            this.workshopSelector.Location = new System.Drawing.Point(85, 126);
            this.workshopSelector.Name = "workshopSelector";
            this.workshopSelector.Size = new System.Drawing.Size(358, 196);
            this.workshopSelector.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 974);
            this.Controls.Add(this.selectionScreen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.selectionScreen1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectionScreen1;
        private System.Windows.Forms.ListBox workshopSelector;
    }
}

