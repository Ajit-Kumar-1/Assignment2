
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
            this.homePanel = new System.Windows.Forms.Panel();
            this.mainScreenButtonGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.displayButton = new System.Windows.Forms.Button();
            this.suiteSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.masterSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.basicSuiteOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.printedCertificateSelectionCheckBox = new System.Windows.Forms.CheckBox();
            this.printedCertificateSelectionLabel = new System.Windows.Forms.Label();
            this.participantCountSelectionControl = new System.Windows.Forms.NumericUpDown();
            this.participantCountSelectionLabel = new System.Windows.Forms.Label();
            this.locationSelectionLabel = new System.Windows.Forms.Label();
            this.locationSelectionListBox = new System.Windows.Forms.ListBox();
            this.workshopSelectionLabel = new System.Windows.Forms.Label();
            this.workshopSelectionListBox = new System.Windows.Forms.ListBox();
            this.displayDetailsPanel = new System.Windows.Forms.Panel();
            this.registrationCostDisplayLabel = new System.Windows.Forms.Label();
            this.registrationCostTitleLabel = new System.Windows.Forms.Label();
            this.lodgingCostDisplayLabel = new System.Windows.Forms.Label();
            this.lodgingCostTitleLabel = new System.Windows.Forms.Label();
            this.addedOptionalCostDisplayLabel = new System.Windows.Forms.Label();
            this.addedOptionalCostTitleLabel = new System.Windows.Forms.Label();
            this.displayScreenButtonGroup = new System.Windows.Forms.GroupBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.displayScreenBackButton = new System.Windows.Forms.Button();
            this.overallCostDisplayLabel = new System.Windows.Forms.Label();
            this.overallCostTitleLabel = new System.Windows.Forms.Label();
            this.numberOfDaysDisplayLabel = new System.Windows.Forms.Label();
            this.numberOfDaysTitleLabel = new System.Windows.Forms.Label();
            this.selectedSuiteDisplayLabel = new System.Windows.Forms.Label();
            this.selectedPrintedCertificateDisplayLabel = new System.Windows.Forms.Label();
            this.selectedParticipantCountDisplayLabel = new System.Windows.Forms.Label();
            this.selectedLocationDisplayLabel = new System.Windows.Forms.Label();
            this.selectedWorkshopDisplayLabel = new System.Windows.Forms.Label();
            this.selectedSuiteTitleLabel = new System.Windows.Forms.Label();
            this.selectedPrintedCertificateTitleLabel = new System.Windows.Forms.Label();
            this.selectedParticipantCountTitleLabel = new System.Windows.Forms.Label();
            this.selectedLocationTitleLabel = new System.Windows.Forms.Label();
            this.selectedWorkshopTitleLabel = new System.Windows.Forms.Label();
            this.homePanel.SuspendLayout();
            this.mainScreenButtonGroupBox.SuspendLayout();
            this.suiteSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantCountSelectionControl)).BeginInit();
            this.displayDetailsPanel.SuspendLayout();
            this.displayScreenButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.mainScreenButtonGroupBox);
            this.homePanel.Controls.Add(this.suiteSelectionGroupBox);
            this.homePanel.Controls.Add(this.printedCertificateSelectionCheckBox);
            this.homePanel.Controls.Add(this.printedCertificateSelectionLabel);
            this.homePanel.Controls.Add(this.participantCountSelectionControl);
            this.homePanel.Controls.Add(this.participantCountSelectionLabel);
            this.homePanel.Controls.Add(this.locationSelectionLabel);
            this.homePanel.Controls.Add(this.locationSelectionListBox);
            this.homePanel.Controls.Add(this.workshopSelectionLabel);
            this.homePanel.Controls.Add(this.workshopSelectionListBox);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(866, 978);
            this.homePanel.TabIndex = 0;
            // 
            // mainScreenButtonGroupBox
            // 
            this.mainScreenButtonGroupBox.Controls.Add(this.exitButton);
            this.mainScreenButtonGroupBox.Controls.Add(this.clearButton);
            this.mainScreenButtonGroupBox.Controls.Add(this.summaryButton);
            this.mainScreenButtonGroupBox.Controls.Add(this.displayButton);
            this.mainScreenButtonGroupBox.Location = new System.Drawing.Point(32, 803);
            this.mainScreenButtonGroupBox.Name = "mainScreenButtonGroupBox";
            this.mainScreenButtonGroupBox.Size = new System.Drawing.Size(787, 126);
            this.mainScreenButtonGroupBox.TabIndex = 9;
            this.mainScreenButtonGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(592, 47);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 46);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(411, 47);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 46);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(231, 47);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(150, 46);
            this.summaryButton.TabIndex = 1;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(52, 47);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(150, 46);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "&Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // suiteSelectionGroupBox
            // 
            this.suiteSelectionGroupBox.Controls.Add(this.masterSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Controls.Add(this.juniorSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Controls.Add(this.basicSuiteOptionRadioButton);
            this.suiteSelectionGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suiteSelectionGroupBox.Location = new System.Drawing.Point(32, 574);
            this.suiteSelectionGroupBox.Name = "suiteSelectionGroupBox";
            this.suiteSelectionGroupBox.Size = new System.Drawing.Size(388, 202);
            this.suiteSelectionGroupBox.TabIndex = 8;
            this.suiteSelectionGroupBox.TabStop = false;
            this.suiteSelectionGroupBox.Text = "5. Select suite type";
            // 
            // masterSuiteOptionRadioButton
            // 
            this.masterSuiteOptionRadioButton.AutoSize = true;
            this.masterSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masterSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 138);
            this.masterSuiteOptionRadioButton.Name = "masterSuiteOptionRadioButton";
            this.masterSuiteOptionRadioButton.Size = new System.Drawing.Size(286, 36);
            this.masterSuiteOptionRadioButton.TabIndex = 2;
            this.masterSuiteOptionRadioButton.Text = "Master Suite (+$99.99)";
            this.masterSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorSuiteOptionRadioButton
            // 
            this.juniorSuiteOptionRadioButton.AutoSize = true;
            this.juniorSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.juniorSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 96);
            this.juniorSuiteOptionRadioButton.Name = "juniorSuiteOptionRadioButton";
            this.juniorSuiteOptionRadioButton.Size = new System.Drawing.Size(285, 36);
            this.juniorSuiteOptionRadioButton.TabIndex = 1;
            this.juniorSuiteOptionRadioButton.Text = "Junior Suite  (+$59.99)";
            this.juniorSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // basicSuiteOptionRadioButton
            // 
            this.basicSuiteOptionRadioButton.AutoSize = true;
            this.basicSuiteOptionRadioButton.Checked = true;
            this.basicSuiteOptionRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basicSuiteOptionRadioButton.Location = new System.Drawing.Point(52, 54);
            this.basicSuiteOptionRadioButton.Name = "basicSuiteOptionRadioButton";
            this.basicSuiteOptionRadioButton.Size = new System.Drawing.Size(159, 36);
            this.basicSuiteOptionRadioButton.TabIndex = 0;
            this.basicSuiteOptionRadioButton.TabStop = true;
            this.basicSuiteOptionRadioButton.Text = "Basic Suite";
            this.basicSuiteOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // printedCertificateSelectionCheckBox
            // 
            this.printedCertificateSelectionCheckBox.AutoSize = true;
            this.printedCertificateSelectionCheckBox.Location = new System.Drawing.Point(565, 510);
            this.printedCertificateSelectionCheckBox.Name = "printedCertificateSelectionCheckBox";
            this.printedCertificateSelectionCheckBox.Size = new System.Drawing.Size(78, 36);
            this.printedCertificateSelectionCheckBox.TabIndex = 7;
            this.printedCertificateSelectionCheckBox.Text = "No";
            this.printedCertificateSelectionCheckBox.UseVisualStyleBackColor = true;
            this.printedCertificateSelectionCheckBox.CheckedChanged += new System.EventHandler(this.printedCertificateSelectionCheckBox_CheckedChanged);
            // 
            // printedCertificateSelectionLabel
            // 
            this.printedCertificateSelectionLabel.AutoSize = true;
            this.printedCertificateSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printedCertificateSelectionLabel.Location = new System.Drawing.Point(32, 511);
            this.printedCertificateSelectionLabel.Name = "printedCertificateSelectionLabel";
            this.printedCertificateSelectionLabel.Size = new System.Drawing.Size(476, 32);
            this.printedCertificateSelectionLabel.TabIndex = 6;
            this.printedCertificateSelectionLabel.Text = "4. Provide Printed Certificate? (+$39.99)";
            // 
            // participantCountSelectionControl
            // 
            this.participantCountSelectionControl.Location = new System.Drawing.Point(565, 443);
            this.participantCountSelectionControl.Name = "participantCountSelectionControl";
            this.participantCountSelectionControl.Size = new System.Drawing.Size(94, 39);
            this.participantCountSelectionControl.TabIndex = 5;
            // 
            // participantCountSelectionLabel
            // 
            this.participantCountSelectionLabel.AutoSize = true;
            this.participantCountSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.participantCountSelectionLabel.Location = new System.Drawing.Point(32, 445);
            this.participantCountSelectionLabel.Name = "participantCountSelectionLabel";
            this.participantCountSelectionLabel.Size = new System.Drawing.Size(381, 32);
            this.participantCountSelectionLabel.TabIndex = 4;
            this.participantCountSelectionLabel.Text = "3. Select number of participants";
            // 
            // locationSelectionLabel
            // 
            this.locationSelectionLabel.AutoSize = true;
            this.locationSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.locationSelectionLabel.Location = new System.Drawing.Point(565, 46);
            this.locationSelectionLabel.Name = "locationSelectionLabel";
            this.locationSelectionLabel.Size = new System.Drawing.Size(209, 32);
            this.locationSelectionLabel.TabIndex = 3;
            this.locationSelectionLabel.Text = "2. Select location";
            // 
            // locationSelectionListBox
            // 
            this.locationSelectionListBox.FormattingEnabled = true;
            this.locationSelectionListBox.ItemHeight = 32;
            this.locationSelectionListBox.Items.AddRange(new object[] {
            " Dublin           €99.99",
            " Belmullet      €219.99",
            " Paris              €149.99",
            " Berlin            €179.99",
            " Vienna          €149.99",
            " Lisbon\t       €89.99",
            " Madrid          €229.99",
            " Rome            €124.99",
            " Amsterdam   €199.99"});
            this.locationSelectionListBox.Location = new System.Drawing.Point(565, 81);
            this.locationSelectionListBox.Name = "locationSelectionListBox";
            this.locationSelectionListBox.Size = new System.Drawing.Size(254, 324);
            this.locationSelectionListBox.TabIndex = 2;
            // 
            // workshopSelectionLabel
            // 
            this.workshopSelectionLabel.AutoSize = true;
            this.workshopSelectionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workshopSelectionLabel.Location = new System.Drawing.Point(32, 46);
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
            " C# Fundamentals                 2 Days    $900",
            " C# Basics for Beginners        4 Days    $1,500",
            " C# Intermediate                   4 Days    $1,800",
            " C# Advanced Topics             3 Days    $2,300",
            " ASP.NET with C# Part A         5 Days    $1,250",
            " ASP.NET with C# Part B         5 Days    $1,250"});
            this.workshopSelectionListBox.Location = new System.Drawing.Point(32, 81);
            this.workshopSelectionListBox.Name = "workshopSelectionListBox";
            this.workshopSelectionListBox.Size = new System.Drawing.Size(500, 228);
            this.workshopSelectionListBox.TabIndex = 0;
            // 
            // displayDetailsPanel
            // 
            this.displayDetailsPanel.Controls.Add(this.registrationCostDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.registrationCostTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.lodgingCostDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.lodgingCostTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.addedOptionalCostDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.addedOptionalCostTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.displayScreenButtonGroup);
            this.displayDetailsPanel.Controls.Add(this.overallCostDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.overallCostTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.numberOfDaysDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.numberOfDaysTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedSuiteDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedPrintedCertificateDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedParticipantCountDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedLocationDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedWorkshopDisplayLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedSuiteTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedPrintedCertificateTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedParticipantCountTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedLocationTitleLabel);
            this.displayDetailsPanel.Controls.Add(this.selectedWorkshopTitleLabel);
            this.displayDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.displayDetailsPanel.Name = "displayDetailsPanel";
            this.displayDetailsPanel.Size = new System.Drawing.Size(866, 975);
            this.displayDetailsPanel.TabIndex = 10;
            this.displayDetailsPanel.Visible = false;
            // 
            // registrationCostDisplayLabel
            // 
            this.registrationCostDisplayLabel.AutoSize = true;
            this.registrationCostDisplayLabel.Location = new System.Drawing.Point(567, 466);
            this.registrationCostDisplayLabel.Name = "registrationCostDisplayLabel";
            this.registrationCostDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.registrationCostDisplayLabel.TabIndex = 20;
            this.registrationCostDisplayLabel.Text = "label5";
            // 
            // registrationCostTitleLabel
            // 
            this.registrationCostTitleLabel.AutoSize = true;
            this.registrationCostTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationCostTitleLabel.Location = new System.Drawing.Point(112, 466);
            this.registrationCostTitleLabel.Name = "registrationCostTitleLabel";
            this.registrationCostTitleLabel.Size = new System.Drawing.Size(217, 32);
            this.registrationCostTitleLabel.TabIndex = 19;
            this.registrationCostTitleLabel.Text = "Registration Cost:";
            // 
            // lodgingCostDisplayLabel
            // 
            this.lodgingCostDisplayLabel.AutoSize = true;
            this.lodgingCostDisplayLabel.Location = new System.Drawing.Point(567, 522);
            this.lodgingCostDisplayLabel.Name = "lodgingCostDisplayLabel";
            this.lodgingCostDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.lodgingCostDisplayLabel.TabIndex = 18;
            this.lodgingCostDisplayLabel.Text = "label5";
            // 
            // lodgingCostTitleLabel
            // 
            this.lodgingCostTitleLabel.AutoSize = true;
            this.lodgingCostTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lodgingCostTitleLabel.Location = new System.Drawing.Point(112, 522);
            this.lodgingCostTitleLabel.Name = "lodgingCostTitleLabel";
            this.lodgingCostTitleLabel.Size = new System.Drawing.Size(172, 32);
            this.lodgingCostTitleLabel.TabIndex = 17;
            this.lodgingCostTitleLabel.Text = "Lodging Cost:";
            // 
            // addedOptionalCostDisplayLabel
            // 
            this.addedOptionalCostDisplayLabel.AutoSize = true;
            this.addedOptionalCostDisplayLabel.Location = new System.Drawing.Point(567, 582);
            this.addedOptionalCostDisplayLabel.Name = "addedOptionalCostDisplayLabel";
            this.addedOptionalCostDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.addedOptionalCostDisplayLabel.TabIndex = 16;
            this.addedOptionalCostDisplayLabel.Text = "label5";
            // 
            // addedOptionalCostTitleLabel
            // 
            this.addedOptionalCostTitleLabel.AutoSize = true;
            this.addedOptionalCostTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addedOptionalCostTitleLabel.Location = new System.Drawing.Point(112, 582);
            this.addedOptionalCostTitleLabel.Name = "addedOptionalCostTitleLabel";
            this.addedOptionalCostTitleLabel.Size = new System.Drawing.Size(259, 32);
            this.addedOptionalCostTitleLabel.TabIndex = 15;
            this.addedOptionalCostTitleLabel.Text = "Added Optional Cost:";
            // 
            // displayScreenButtonGroup
            // 
            this.displayScreenButtonGroup.Controls.Add(this.bookButton);
            this.displayScreenButtonGroup.Controls.Add(this.displayScreenBackButton);
            this.displayScreenButtonGroup.Location = new System.Drawing.Point(75, 755);
            this.displayScreenButtonGroup.Name = "displayScreenButtonGroup";
            this.displayScreenButtonGroup.Size = new System.Drawing.Size(717, 158);
            this.displayScreenButtonGroup.TabIndex = 14;
            this.displayScreenButtonGroup.TabStop = false;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(451, 64);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(201, 46);
            this.bookButton.TabIndex = 1;
            this.bookButton.Text = "&Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // displayScreenBackButton
            // 
            this.displayScreenBackButton.Location = new System.Drawing.Point(69, 64);
            this.displayScreenBackButton.Name = "displayScreenBackButton";
            this.displayScreenBackButton.Size = new System.Drawing.Size(214, 46);
            this.displayScreenBackButton.TabIndex = 0;
            this.displayScreenBackButton.Text = "B&ack to Previous";
            this.displayScreenBackButton.UseVisualStyleBackColor = true;
            this.displayScreenBackButton.Click += new System.EventHandler(this.displayScreenBackButton_Click);
            // 
            // overallCostDisplayLabel
            // 
            this.overallCostDisplayLabel.AutoSize = true;
            this.overallCostDisplayLabel.Location = new System.Drawing.Point(567, 643);
            this.overallCostDisplayLabel.Name = "overallCostDisplayLabel";
            this.overallCostDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.overallCostDisplayLabel.TabIndex = 13;
            this.overallCostDisplayLabel.Text = "label5";
            // 
            // overallCostTitleLabel
            // 
            this.overallCostTitleLabel.AutoSize = true;
            this.overallCostTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.overallCostTitleLabel.Location = new System.Drawing.Point(112, 643);
            this.overallCostTitleLabel.Name = "overallCostTitleLabel";
            this.overallCostTitleLabel.Size = new System.Drawing.Size(159, 32);
            this.overallCostTitleLabel.TabIndex = 12;
            this.overallCostTitleLabel.Text = "Overall Cost:";
            // 
            // numberOfDaysDisplayLabel
            // 
            this.numberOfDaysDisplayLabel.AutoSize = true;
            this.numberOfDaysDisplayLabel.Location = new System.Drawing.Point(567, 372);
            this.numberOfDaysDisplayLabel.Name = "numberOfDaysDisplayLabel";
            this.numberOfDaysDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.numberOfDaysDisplayLabel.TabIndex = 11;
            this.numberOfDaysDisplayLabel.Text = "label5";
            // 
            // numberOfDaysTitleLabel
            // 
            this.numberOfDaysTitleLabel.AutoSize = true;
            this.numberOfDaysTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfDaysTitleLabel.Location = new System.Drawing.Point(112, 372);
            this.numberOfDaysTitleLabel.Name = "numberOfDaysTitleLabel";
            this.numberOfDaysTitleLabel.Size = new System.Drawing.Size(208, 32);
            this.numberOfDaysTitleLabel.TabIndex = 10;
            this.numberOfDaysTitleLabel.Text = "Number of Days:";
            // 
            // selectedSuiteDisplayLabel
            // 
            this.selectedSuiteDisplayLabel.AutoSize = true;
            this.selectedSuiteDisplayLabel.Location = new System.Drawing.Point(567, 306);
            this.selectedSuiteDisplayLabel.Name = "selectedSuiteDisplayLabel";
            this.selectedSuiteDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.selectedSuiteDisplayLabel.TabIndex = 9;
            this.selectedSuiteDisplayLabel.Text = "label5";
            // 
            // selectedPrintedCertificateDisplayLabel
            // 
            this.selectedPrintedCertificateDisplayLabel.AutoSize = true;
            this.selectedPrintedCertificateDisplayLabel.Location = new System.Drawing.Point(567, 245);
            this.selectedPrintedCertificateDisplayLabel.Name = "selectedPrintedCertificateDisplayLabel";
            this.selectedPrintedCertificateDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.selectedPrintedCertificateDisplayLabel.TabIndex = 8;
            this.selectedPrintedCertificateDisplayLabel.Text = "label4";
            // 
            // selectedParticipantCountDisplayLabel
            // 
            this.selectedParticipantCountDisplayLabel.AutoSize = true;
            this.selectedParticipantCountDisplayLabel.Location = new System.Drawing.Point(567, 183);
            this.selectedParticipantCountDisplayLabel.Name = "selectedParticipantCountDisplayLabel";
            this.selectedParticipantCountDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.selectedParticipantCountDisplayLabel.TabIndex = 7;
            this.selectedParticipantCountDisplayLabel.Text = "label3";
            // 
            // selectedLocationDisplayLabel
            // 
            this.selectedLocationDisplayLabel.AutoSize = true;
            this.selectedLocationDisplayLabel.Location = new System.Drawing.Point(567, 121);
            this.selectedLocationDisplayLabel.Name = "selectedLocationDisplayLabel";
            this.selectedLocationDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.selectedLocationDisplayLabel.TabIndex = 6;
            this.selectedLocationDisplayLabel.Text = "label2";
            // 
            // selectedWorkshopDisplayLabel
            // 
            this.selectedWorkshopDisplayLabel.AutoSize = true;
            this.selectedWorkshopDisplayLabel.Location = new System.Drawing.Point(567, 61);
            this.selectedWorkshopDisplayLabel.Name = "selectedWorkshopDisplayLabel";
            this.selectedWorkshopDisplayLabel.Size = new System.Drawing.Size(78, 32);
            this.selectedWorkshopDisplayLabel.TabIndex = 5;
            this.selectedWorkshopDisplayLabel.Text = "label1";
            // 
            // selectedSuiteTitleLabel
            // 
            this.selectedSuiteTitleLabel.AutoSize = true;
            this.selectedSuiteTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedSuiteTitleLabel.Location = new System.Drawing.Point(112, 306);
            this.selectedSuiteTitleLabel.Name = "selectedSuiteTitleLabel";
            this.selectedSuiteTitleLabel.Size = new System.Drawing.Size(187, 32);
            this.selectedSuiteTitleLabel.TabIndex = 4;
            this.selectedSuiteTitleLabel.Text = "Suite selection:";
            // 
            // selectedPrintedCertificateTitleLabel
            // 
            this.selectedPrintedCertificateTitleLabel.AutoSize = true;
            this.selectedPrintedCertificateTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedPrintedCertificateTitleLabel.Location = new System.Drawing.Point(112, 245);
            this.selectedPrintedCertificateTitleLabel.Name = "selectedPrintedCertificateTitleLabel";
            this.selectedPrintedCertificateTitleLabel.Size = new System.Drawing.Size(410, 32);
            this.selectedPrintedCertificateTitleLabel.TabIndex = 3;
            this.selectedPrintedCertificateTitleLabel.Text = "Printed Certificate to be provided?";
            // 
            // selectedParticipantCountTitleLabel
            // 
            this.selectedParticipantCountTitleLabel.AutoSize = true;
            this.selectedParticipantCountTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedParticipantCountTitleLabel.Location = new System.Drawing.Point(112, 183);
            this.selectedParticipantCountTitleLabel.Name = "selectedParticipantCountTitleLabel";
            this.selectedParticipantCountTitleLabel.Size = new System.Drawing.Size(290, 32);
            this.selectedParticipantCountTitleLabel.TabIndex = 2;
            this.selectedParticipantCountTitleLabel.Text = "Number of participants:";
            // 
            // selectedLocationTitleLabel
            // 
            this.selectedLocationTitleLabel.AutoSize = true;
            this.selectedLocationTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedLocationTitleLabel.Location = new System.Drawing.Point(112, 121);
            this.selectedLocationTitleLabel.Name = "selectedLocationTitleLabel";
            this.selectedLocationTitleLabel.Size = new System.Drawing.Size(228, 32);
            this.selectedLocationTitleLabel.TabIndex = 1;
            this.selectedLocationTitleLabel.Text = "Location Selected: ";
            // 
            // selectedWorkshopTitleLabel
            // 
            this.selectedWorkshopTitleLabel.AutoSize = true;
            this.selectedWorkshopTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedWorkshopTitleLabel.Location = new System.Drawing.Point(112, 61);
            this.selectedWorkshopTitleLabel.Name = "selectedWorkshopTitleLabel";
            this.selectedWorkshopTitleLabel.Size = new System.Drawing.Size(246, 32);
            this.selectedWorkshopTitleLabel.TabIndex = 0;
            this.selectedWorkshopTitleLabel.Text = "Workshop Selected: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 976);
            this.Controls.Add(this.displayDetailsPanel);
            this.Controls.Add(this.homePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.mainScreenButtonGroupBox.ResumeLayout(false);
            this.suiteSelectionGroupBox.ResumeLayout(false);
            this.suiteSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantCountSelectionControl)).EndInit();
            this.displayDetailsPanel.ResumeLayout(false);
            this.displayDetailsPanel.PerformLayout();
            this.displayScreenButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.ListBox workshopSelectionListBox;
        private System.Windows.Forms.Label workshopSelectionLabel;
        private System.Windows.Forms.ListBox locationSelectionListBox;
        private System.Windows.Forms.Label locationSelectionLabel;
        private System.Windows.Forms.NumericUpDown participantCountSelectionControl;
        private System.Windows.Forms.Label participantCountSelectionLabel;
        private System.Windows.Forms.Label printedCertificateSelectionLabel;
        private System.Windows.Forms.CheckBox printedCertificateSelectionCheckBox;
        private System.Windows.Forms.GroupBox suiteSelectionGroupBox;
        private System.Windows.Forms.RadioButton masterSuiteOptionRadioButton;
        private System.Windows.Forms.RadioButton juniorSuiteOptionRadioButton;
        private System.Windows.Forms.RadioButton basicSuiteOptionRadioButton;
        private System.Windows.Forms.GroupBox mainScreenButtonGroupBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel displayDetailsPanel;
        private System.Windows.Forms.Label selectedSuiteTitleLabel;
        private System.Windows.Forms.Label selectedPrintedCertificateTitleLabel;
        private System.Windows.Forms.Label selectedParticipantCountTitleLabel;
        private System.Windows.Forms.Label selectedLocationTitleLabel;
        private System.Windows.Forms.Label selectedWorkshopTitleLabel;
        private System.Windows.Forms.Label selectedSuiteDisplayLabel;
        private System.Windows.Forms.Label selectedPrintedCertificateDisplayLabel;
        private System.Windows.Forms.Label selectedParticipantCountDisplayLabel;
        private System.Windows.Forms.Label selectedLocationDisplayLabel;
        private System.Windows.Forms.Label selectedWorkshopDisplayLabel;
        private System.Windows.Forms.Label overallCostDisplayLabel;
        private System.Windows.Forms.Label overallCostTitleLabel;
        private System.Windows.Forms.Label numberOfDaysDisplayLabel;
        private System.Windows.Forms.Label numberOfDaysTitleLabel;
        private System.Windows.Forms.GroupBox displayScreenButtonGroup;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Button displayScreenBackButton;
        private System.Windows.Forms.Label registrationCostDisplayLabel;
        private System.Windows.Forms.Label registrationCostTitleLabel;
        private System.Windows.Forms.Label lodgingCostDisplayLabel;
        private System.Windows.Forms.Label lodgingCostTitleLabel;
        private System.Windows.Forms.Label addedOptionalCostDisplayLabel;
        private System.Windows.Forms.Label addedOptionalCostTitleLabel;
    }
}

