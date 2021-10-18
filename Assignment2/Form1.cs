using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {

        // Literal values - Workshops
        const string WORKSHOP_1 = "C£ Fundamentals";
        const string WORKSHOP_2 = "C£ Basics for Beginners";
        const string WORKSHOP_3 = "C£ Intermediate";
        const string WORKSHOP_4 = "C£ Advanced Topics";
        const string WORKSHOP_5 = "ASP.NET with C£ Part A";
        const string WORKSHOP_6 = "ASP.NET with C£ Part B";

        // Literal values - Number of training days for each workshop
        const int TRAINING_DAYS_1 = 2;
        const int TRAINING_DAYS_2 = 4;
        const int TRAINING_DAYS_3 = 4;
        const int TRAINING_DAYS_4 = 3;
        const int TRAINING_DAYS_5 = 5;
        const int TRAINING_DAYS_6 = 5;

        // Literal values - Registration fee for each workshop
        const int REGISTRATION_FEE_1 = 900;
        const int REGISTRATION_FEE_2 = 1500;
        const int REGISTRATION_FEE_3 = 1800;
        const int REGISTRATION_FEE_4 = 2300;
        const int REGISTRATION_FEE_5 = 1250;
        const int REGISTRATION_FEE_6 = 1250;

        // Literal values - Locations
        const string LOCATION_1 = "Dublin";
        const string LOCATION_2 = "Belmullet";
        const string LOCATION_3 = "Paris";
        const string LOCATION_4 = "Berlin";
        const string LOCATION_5 = "Vienna";
        const string LOCATION_6 = "Lisbon";
        const string LOCATION_7 = "Madrid";
        const string LOCATION_8 = "Rome";
        const string LOCATION_9 = "Amsterdam";

        // Literal values - Lodging fee for each location
        const decimal LODGING_FEE_1 = 99.99M;
        const decimal LODGING_FEE_2 = 219.99M;
        const decimal LODGING_FEE_3 = 149.99M;
        const decimal LODGING_FEE_4 = 179.99M;
        const decimal LODGING_FEE_5 = 149.99M;
        const decimal LODGING_FEE_6 = 89.99M;
        const decimal LODGING_FEE_7 = 229.99M;
        const decimal LODGING_FEE_8 = 124.99M;
        const decimal LODGING_FEE_9 = 199.99M;

        // Literal values - Added optional costs
        const decimal PRINTED_CERTIFICATE_COST = 39.99M;

        // Literal values - Suite upgrade costs
        const decimal JUNIOR_SUITE_COST = 59.99M;
        const decimal MASTER_SUITE_COST = 99.99M;

        // Literal values - Discount rate
        const decimal DISCOUNT_RATE = 7.5M;

        // Literal values - the suffix for number of training days
        const string DAYS_SUFFIX = " Days";

        // Literal values - indication of whether the printed certificate option was availed
        const string YES = "Yes";
        const string NO = "No";

        // Literal values - Suite types
        const string BASIC = "Basic";
        const string JUNIOR = "Junior";
        const string MASTER = "Master";

        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Deleting all the controls in the form
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            // Restore the initial state of the form
            InitializeComponent();
        }

        // Event handler called when the "Exit" button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        // Event handler called when the "Back" button is clicked 
        private void displayScreenBackButton_Click(object sender, EventArgs e)
        {
            // Shows the previous screen
            homePanel.Show();
            displayDetailsPanel.Hide();
        }

        // Event handler called when the "Display" button is clicked
        private void displayButton_Click(object sender, EventArgs e)
        {
            // Show screen with booking details
            homePanel.Hide();
            displayDetailsPanel.Show();

            // Variables to keep track of various costs
            decimal registrationCostPerParticipant = 0.00M;
            decimal baseLodgingCostPerParticipant = 0.00M;
            decimal addedLodgingCostPerParticipant = 0.00M;
            decimal optionalCostPerParticipant = 0.00M;
            decimal registrationCostValue = 0.00M;
            decimal optionalCostValue = 0.00M;
            decimal lodgingCostValue = 0.00M;
            decimal overallCostBeforeDiscount = 0.00M;
            decimal overallCost = 0.00M;

            // Variable to keep track of the number of training days
            int numberOfTrainingDays = 2;

            // Variable to keep track of whether a room upgrade is availed
            Boolean roomUpgradeAvailed = false;

            // Obtain the selected workshop by means of its index in the ListBox control
            int selectedWorkshopIndex = workshopSelectionListBox.SelectedIndex;

            // Display the workshop selected, number of days and the registration cost
            // Also keep track of the registration cost and the number of training days
            switch (selectedWorkshopIndex)
            {
                case 0:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_1;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_1.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_1.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_1;
                    numberOfTrainingDays = TRAINING_DAYS_1;
                    break;
                case 1:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_2;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_2.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_2.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_2;
                    numberOfTrainingDays = TRAINING_DAYS_2;
                    break;
                case 2:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_3;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_3.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_3.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_3;
                    numberOfTrainingDays = TRAINING_DAYS_3;
                    break;
                case 3:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_4;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_4.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_4.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_4;
                    numberOfTrainingDays = TRAINING_DAYS_4;
                    break;
                case 4:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_5;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_5.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_5.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_5;
                    numberOfTrainingDays = TRAINING_DAYS_5;

                    break;
                case 5:
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_6;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_6.ToString() + DAYS_SUFFIX;
                    registrationCostDisplayLabel.Text = REGISTRATION_FEE_6.ToString("C");
                    registrationCostPerParticipant = REGISTRATION_FEE_6;
                    numberOfTrainingDays = TRAINING_DAYS_6;
                    break;
            }

            // Obtain the selected location by means of its index in the ListBox control
            int selectedLocationIndex = locationSelectionListBox.SelectedIndex;

            // Display the location and keep track of the base cost for lodging
            switch (selectedLocationIndex)
            {
                case 0:
                    selectedLocationDisplayLabel.Text = LOCATION_1;
                    baseLodgingCostPerParticipant = LODGING_FEE_1 * numberOfTrainingDays;
                    break;
                case 1:
                    selectedLocationDisplayLabel.Text = LOCATION_2;
                    baseLodgingCostPerParticipant = LODGING_FEE_2 * numberOfTrainingDays;
                    break;
                case 2:
                    selectedLocationDisplayLabel.Text = LOCATION_3;
                    baseLodgingCostPerParticipant = LODGING_FEE_3 * numberOfTrainingDays;
                    break;
                case 3:
                    selectedLocationDisplayLabel.Text = LOCATION_4;
                    baseLodgingCostPerParticipant = LODGING_FEE_4 * numberOfTrainingDays;
                    break;
                case 4:
                    selectedLocationDisplayLabel.Text = LOCATION_5;
                    baseLodgingCostPerParticipant = LODGING_FEE_5 * numberOfTrainingDays;
                    break;
                case 5:
                    selectedLocationDisplayLabel.Text = LOCATION_6;
                    baseLodgingCostPerParticipant = LODGING_FEE_6 * numberOfTrainingDays;
                    break;
                case 6:
                    selectedLocationDisplayLabel.Text = LOCATION_7;
                    baseLodgingCostPerParticipant = LODGING_FEE_7 * numberOfTrainingDays;
                    break;
                case 7:
                    selectedLocationDisplayLabel.Text = LOCATION_8;
                    baseLodgingCostPerParticipant = LODGING_FEE_8 * numberOfTrainingDays;
                    break;
                case 8:
                    selectedLocationDisplayLabel.Text = LOCATION_9;
                    baseLodgingCostPerParticipant = LODGING_FEE_9 * numberOfTrainingDays;
                    break;
            }

            // Obtain the number of participants selected
            int participantCountValue = (int)participantCountSelectionControl.Value;

            // Obtain the choice taken on the printed certificate option
            Boolean printedCertificateValue = printedCertificateSelectionCheckBox.Checked;

            // If applicable, keep track of the added cost for the printed certificate
            optionalCostPerParticipant = printedCertificateValue ? PRINTED_CERTIFICATE_COST : 0;

            // Display whether the printed certificate option is availed
            selectedPrintedCertificateDisplayLabel.Text = YES;

            // Display and keep track of the selected suite type, and keep track of the added cost
            if (basicSuiteOptionRadioButton.Checked)
            {
                selectedSuiteDisplayLabel.Text = BASIC;
                addedLodgingCostPerParticipant = 0.00M;
                roomUpgradeAvailed = false;
            }
            if (juniorSuiteOptionRadioButton.Checked)
            {
                selectedSuiteDisplayLabel.Text = JUNIOR;
                addedLodgingCostPerParticipant = JUNIOR_SUITE_COST * numberOfTrainingDays;
                roomUpgradeAvailed = true;
            }
            else if (masterSuiteOptionRadioButton.Checked)
            {
                selectedSuiteDisplayLabel.Text = MASTER;
                addedLodgingCostPerParticipant = MASTER_SUITE_COST * numberOfTrainingDays;
                roomUpgradeAvailed = true;
            }

            // Calculate the registration cost
            registrationCostValue = registrationCostPerParticipant * participantCountValue;

            // Add the registration cost to the overall cost
            overallCost += registrationCostValue;

            // Display the registration cost
            overallCostDisplayLabel.Text = registrationCostValue.ToString("C");

            // Calculate the optional costs
            optionalCostValue = optionalCostPerParticipant * participantCountValue;

            // Add the optional costs to the overall cost
            overallCost += optionalCostValue;

            // Display the optional costs
            addedOptionalCostDisplayLabel.Text = optionalCostValue.ToString("C");

            // Calculate the lodging cost
            lodgingCostValue = baseLodgingCostPerParticipant * participantCountValue;
            lodgingCostValue += addedLodgingCostPerParticipant * participantCountValue;

            // Add the lodging cost to the overall cost
            overallCost += lodgingCostValue;

            // Display the lodging cost
            lodgingCostDisplayLabel.Text = lodgingCostValue.ToString("C");

            // Check if discount is applicable
            Boolean isDiscountApplicable = participantCountValue >= 4 && roomUpgradeAvailed;

            // If applicable, apply discount
            if (isDiscountApplicable)
                overallCost *= (100 - DISCOUNT_RATE) / 100;

            // Display the overall cost
            overallCostDisplayLabel.Text = overallCost.ToString("C");
        }
    }
}
