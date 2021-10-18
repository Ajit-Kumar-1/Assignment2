
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.suiteSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.printedCertificateSelectionCheckBox = new System.Windows.Forms.CheckBox();
            this.printedCertificateSelectionLabel = new System.Windows.Forms.Label();
            this.participantCountSelectionBox = new System.Windows.Forms.NumericUpDown();
            this.participantCountSelectionLabel = new System.Windows.Forms.Label();
            this.venueSelectionLabel = new System.Windows.Forms.Label();
            this.venueSelectionListBox = new System.Windows.Forms.ListBox();
            this.workshopSelectionLabel = new System.Windows.Forms.Label();
            this.workshopSelectionListBox = new System.Windows.Forms.ListBox();
            this.basicSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.masterSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.mainScreenButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.suiteSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantCountSelectionBox)).BeginInit();
            this.mainScreenButtonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainScreenButtonGroupBox);
            this.mainPanel.Controls.Add(this.suiteSelectionGroupBox);
            this.mainPanel.Controls.Add(this.printedCertificateSelectionCheckBox);
            this.mainPanel.Controls.Add(this.printedCertificateSelectionLabel);
            this.mainPanel.Controls.Add(this.participantCountSelectionBox);
            this.mainPanel.Controls.Add(this.participantCountSelectionLabel);
            this.mainPanel.Controls.Add(this.venueSelectionLabel);
            this.mainPanel.Controls.Add(this.venueSelectionListBox);
            this.mainPanel.Controls.Add(this.workshopSelectionLabel);
            this.mainPanel.Controls.Add(this.workshopSelectionListBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(866, 978);
            this.mainPanel.TabIndex = 0;
            // 
            // suiteSelectionGroupBox
            // 
            this.suiteSelectionGroupBox.Controls.Add(this.masterSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Controls.Add(this.juniorSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Controls.Add(this.basicSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suiteSelectionGroupBox.Location = new System.Drawing.Point(38, 547);
            this.suiteSelectionGroupBox.Name = "suiteSelectionGroupBox";
            this.suiteSelectionGroupBox.Size = new System.Drawing.Size(408, 202);
            this.suiteSelectionGroupBox.TabIndex = 8;
            this.suiteSelectionGroupBox.TabStop = false;
            this.suiteSelectionGroupBox.Text = "5. Select suite type";
            // 
            // printedCertificateSelectionCheckBox
            // 
            this.printedCertificateSelectionCheckBox.AutoSize = true;
            this.printedCertificateSelectionCheckBox.Location = new System.Drawing.Point(571, 483);
            this.printedCertificateSelectionCheckBox.Name = "printedCertificateSelectionCheckBox";
            this.printedCertificateSelectionCheckBox.Size = new System.Drawing.Size(78, 36);
            this.printedCertificateSelectionCheckBox.TabIndex = 7;
            this.printedCertificateSelectionCheckBox.Text = "No";
            this.printedCertificateSelectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // printedCertificateSelectionLabel
            // 
            this.printedCertificateSelectionLabel.AutoSize = true;
            this.printedCertificateSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printedCertificateSelectionLabel.Location = new System.Drawing.Point(38, 484);
            this.printedCertificateSelectionLabel.Name = "printedCertificateSelectionLabel";
            this.printedCertificateSelectionLabel.Size = new System.Drawing.Size(476, 32);
            this.printedCertificateSelectionLabel.TabIndex = 6;
            this.printedCertificateSelectionLabel.Text = "4. Provide Printed Certificate? (+$39.99)";
            // 
            // participantCountSelectionBox
            // 
            this.participantCountSelectionBox.Location = new System.Drawing.Point(571, 416);
            this.participantCountSelectionBox.Name = "participantCountSelectionBox";
            this.participantCountSelectionBox.Size = new System.Drawing.Size(94, 39);
            this.participantCountSelectionBox.TabIndex = 5;
            // 
            // participantCountSelectionLabel
            // 
            this.participantCountSelectionLabel.AutoSize = true;
            this.participantCountSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.participantCountSelectionLabel.Location = new System.Drawing.Point(38, 418);
            this.participantCountSelectionLabel.Name = "participantCountSelectionLabel";
            this.participantCountSelectionLabel.Size = new System.Drawing.Size(381, 32);
            this.participantCountSelectionLabel.TabIndex = 4;
            this.participantCountSelectionLabel.Text = "3. Select number of participants";
            // 
            // venueSelectionLabel
            // 
            this.venueSelectionLabel.AutoSize = true;
            this.venueSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.venueSelectionLabel.Location = new System.Drawing.Point(571, 61);
            this.venueSelectionLabel.Name = "venueSelectionLabel";
            this.venueSelectionLabel.Size = new System.Drawing.Size(233, 32);
            this.venueSelectionLabel.TabIndex = 3;
            this.venueSelectionLabel.Text = "2. Select venue city";
            // 
            // venueSelectionListBox
            // 
            this.venueSelectionListBox.FormattingEnabled = true;
            this.venueSelectionListBox.ItemHeight = 32;
            this.venueSelectionListBox.Items.AddRange(new object[] {
            "Dublin            $99.99",
            "Belmullet       $219.99",
            "Paris               $149.99",
            "Berlin             $179.99",
            "Vienna           $149.99",
            "Lisbon\t       $89.99",
            "Madrid           $229.99",
            "Rome             $124.99",
            "Amsterdam    $199.99"});
            this.venueSelectionListBox.Location = new System.Drawing.Point(571, 96);
            this.venueSelectionListBox.Name = "venueSelectionListBox";
            this.venueSelectionListBox.Size = new System.Drawing.Size(254, 292);
            this.venueSelectionListBox.TabIndex = 2;
            // 
            // workshopSelectionLabel
            // 
            this.workshopSelectionLabel.AutoSize = true;
            this.workshopSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workshopSelectionLabel.Location = new System.Drawing.Point(38, 61);
            this.workshopSelectionLabel.Name = "workshopSelectionLabel";
            this.workshopSelectionLabel.Size = new System.Drawing.Size(228, 32);
            this.workshopSelectionLabel.TabIndex = 1;
            this.workshopSelectionLabel.Text = "1. Select workshop";
            // 
            // workshopSelectionListBox
            // 
            this.workshopSelectionListBox.FormattingEnabled = true;
            this.workshopSelectionListBox.ItemHeight = 32;
            this.workshopSelectionListBox.Items.AddRange(new object[] {
            "C£ Fundamentals                 2 Days    $900",
            "C£ Basics for Beginners        4 Days    $1,500",
            "C£ Intermediate                   4 Days    $1,800",
            "C£ Advanced Topics             3 Days    $2,300",
            "ASP.NET with C£ Part A         5 Days    $1,250",
            "ASP.NET with C£ Part B         5 Days    $1,250"});
            this.workshopSelectionListBox.Location = new System.Drawing.Point(38, 96);
            this.workshopSelectionListBox.Name = "workshopSelectionListBox";
            this.workshopSelectionListBox.Size = new System.Drawing.Size(490, 196);
            this.workshopSelectionListBox.TabIndex = 0;
            // 
            // basicSuiteOptionRadioButton
            // 
            this.basicSuiteOptionRadioButton.AutoSize = true;
            this.basicSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basicSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 54);
            this.basicSuiteOptionRadioButton.Name = "basicSuiteOptionRadioButton";
            this.basicSuiteOptionRadioButton.Size = new System.Drawing.Size(159, 36);
            this.basicSuiteOptionRadioButton.TabIndex = 0;
            this.basicSuiteOptionRadioButton.TabStop = true;
            this.basicSuiteOptionRadioButton.Text = "Basic Suite";
            this.basicSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorSuiteOptionRadioButton
            // 
            this.juniorSuiteOptionRadioButton.AutoSize = true;
            this.juniorSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.juniorSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 96);
            this.juniorSuiteOptionRadioButton.Name = "juniorSuiteOptionRadioButton";
            this.juniorSuiteOptionRadioButton.Size = new System.Drawing.Size(285, 36);
            this.juniorSuiteOptionRadioButton.TabIndex = 1;
            this.juniorSuiteOptionRadioButton.TabStop = true;
            this.juniorSuiteOptionRadioButton.Text = "Junior Suite  (+$59.99)";
            this.juniorSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterSuiteOptionRadioButton
            // 
            this.masterSuiteOptionRadioButton.AutoSize = true;
            this.masterSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masterSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 138);
            this.masterSuiteOptionRadioButton.Name = "masterSuiteOptionRadioButton";
            this.masterSuiteOptionRadioButton.Size = new System.Drawing.Size(286, 36);
            this.masterSuiteOptionRadioButton.TabIndex = 2;
            this.masterSuiteOptionRadioButton.TabStop = true;
            this.masterSuiteOptionRadioButton.Text = "Master Suite (+$99.99)";
            this.masterSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // mainScreenButtonGroupBox
            // 
            this.mainScreenButtonGroupBox.Controls.Add(this.button3);
            this.mainScreenButtonGroupBox.Controls.Add(this.button2);
            this.mainScreenButtonGroupBox.Controls.Add(this.button1);
            this.mainScreenButtonGroupBox.Location = new System.Drawing.Point(38, 776);
            this.mainScreenButtonGroupBox.Name = "mainScreenButtonGroupBox";
            this.mainScreenButtonGroupBox.Size = new System.Drawing.Size(787, 126);
            this.mainScreenButtonGroupBox.TabIndex = 9;
            this.mainScreenButtonGroupBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Display";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Summary";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 976);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.suiteSelectionGroupBox.ResumeLayout(false);
            this.suiteSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantCountSelectionBox)).EndInit();
            this.mainScreenButtonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListBox workshopSelectionListBox;
        private System.Windows.Forms.Label workshopSelectionLabel;
        private System.Windows.Forms.ListBox venueSelectionListBox;
        private System.Windows.Forms.Label venueSelectionLabel;
        private System.Windows.Forms.NumericUpDown participantCountSelectionBox;
        private System.Windows.Forms.Label participantCountSelectionLabel;
        private System.Windows.Forms.Label printedCertificateSelectionLabel;
        private System.Windows.Forms.CheckBox printedCertificateSelectionCheckBox;
        private System.Windows.Forms.GroupBox suiteSelectionGroupBox;
        private System.Windows.Forms.RadioButton masterSuiteOptionRadioButton;
        private System.Windows.Forms.RadioButton juniorSuiteOptionRadioButton;
        private System.Windows.Forms.RadioButton basicSuiteOptionRadioButton;
        private System.Windows.Forms.GroupBox mainScreenButtonGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

