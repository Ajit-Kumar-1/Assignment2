using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {

        // Literal values - Workshops
        const string WORKSHOP_1 = "C# Fundamentals";
        const string WORKSHOP_2 = "C# Basics for Beginners";
        const string WORKSHOP_3 = "C# Intermediate";
        const string WORKSHOP_4 = "C# Advanced Topics";
        const string WORKSHOP_5 = "ASP.NET with C# Part A";
        const string WORKSHOP_6 = "ASP.NET with C# Part B";

        // Literal values - Number of training days for each workshop
        const int TRAINING_DAYS_1 = 2;
        const int TRAINING_DAYS_2 = 4;
        const int TRAINING_DAYS_3 = 4;
        const int TRAINING_DAYS_4 = 3;
        const int TRAINING_DAYS_5 = 5;
        const int TRAINING_DAYS_6 = 5;

        // Literal values - Registration fee for each workshop
        const decimal REGISTRATION_FEE_1 = 900.00M;
        const decimal REGISTRATION_FEE_2 = 1500.00M;
        const decimal REGISTRATION_FEE_3 = 1800.00M;
        const decimal REGISTRATION_FEE_4 = 2300.00M;
        const decimal REGISTRATION_FEE_5 = 1250.00M;
        const decimal REGISTRATION_FEE_6 = 1250.00M;

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

        // Alert and error messages
        const string ALERT_TITLE = "Alert";
        const string NO_BOOKINGS_YET_DESCRIPTION = "No bookings made yet";
        const string DATA_CLEARED_DESCRIPTION = "Saved data has been cleared";
        const string ERROR_TITLE = "Error";
        const string NO_WORKSHOP_SELECTED_DESCRIPTION = "Please select a workshop";
        const string NO_LOCATION_SELECTED_DESCRIPTION = "Please select a location";
        const string ZERO_PARTICIPANTS_DESCRIPTION = "Please enter a positive number for number of participants";
        const string INVALID_PARTICIPANTS_DESCRIPTION = "Please enter a whole number for number of participants";

        // Tooltip messages
        const string DISPLAY_BUTTON_TOOLTIP_TEXT = "Show details of booking before confirmation";
        const string SUMMARY_BUTTON_TOOLTIP_TEXT = "Show summary of details of bookings made so far";
        const string CLEAR_BUTTON_TOOLTIP_TEXT = "Clear records of bookings";
        const string EXIT_BUTTON_TOOLTIP_TEXT = "Exit application";
        const string BACK_BUTTON_TOOLTIP_TEXT = "Go back to the workshop selection screen";
        const string BOOK_BUTTON_TOOLTIP_TEXT = "Proceed with booking the workshop";

        // Variables holding data for displaying booking details
        string selectedWorkshop = "";
        string selectedLocation = "";

        // Variables holding data for displaying summary information
        int totalNumberOfBookings = 0;
        decimal totalRegistrationFees = 0.00M;
        decimal totalLodgingFees = 0.00M;
        decimal totalOptionalFees = 0.00M;
        int totalNumberOfDiscountedBookings = 0;
        decimal totalRevenue = 0.00M;
        decimal registrationCostValue = 0.00M;
        decimal optionalCostValue = 0.00M;
        decimal lodgingCostValue = 0.00M;
        decimal overallCost = 0.00M;
        Boolean isDiscounted = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler called when the "Clear" button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
           // Reset the screen's controls to their default values
            resetFormAppearance();

            // Clear saved records of past bookings
            clearSummaryData();

            // Show a message indicating that data has indeed been cleared
            MessageBox.Show(DATA_CLEARED_DESCRIPTION, ALERT_TITLE, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            // Hides the Display screen
            displayDetailsPanel.Hide();
        }

        // Event handler called when the "Display" button is clicked
        private void displayButton_Click(object sender, EventArgs e)
        {

            // Variables to keep track of the selected workshop
            int selectedWorkshopIndex = -1;

            // Variable to keep track of number of participants
            int participantCountValue = 0;

            // Variables to keep track of various costs
            decimal registrationCostPerParticipant = 0.00M;
            decimal baseLodgingCostPerParticipant = 0.00M;
            decimal addedLodgingCostPerParticipant = 0.00M;
            decimal optionalCostPerParticipant = 0.00M;
            registrationCostValue = 0.00M;
            optionalCostValue = 0.00M;
            lodgingCostValue = 0.00M;
            overallCost = 0.00M;

            // Variable to keep track of the number of training days
            int numberOfTrainingDays = 2;

            // Variable to keep track of whether a room upgrade is availed
            Boolean roomUpgradeAvailed = false;

            // Obtain the selected workshop by means of its index in the ListBox control
            selectedWorkshopIndex = workshopSelectionListBox.SelectedIndex;

            // Obtain the number of participants selected
            participantCountValue = (int)participantCountSelectionControl.Value;

            if (participantCountValue > 0) { }
            else if (participantCountValue == 0)
            // Handle exception of number of participants being zero
            {
                // Show a message box indicating the issue
                var messageBoxInstance = MessageBox.Show(ZERO_PARTICIPANTS_DESCRIPTION, 
                    ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Return focus
                if (messageBoxInstance == DialogResult.OK)
                    participantCountSelectionControl.Focus();
                return;
            }
            else
            // Handle exception of number of participants being an invalid value
            {
                var messageBoxInstance = MessageBox.Show(INVALID_PARTICIPANTS_DESCRIPTION, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (messageBoxInstance == DialogResult.OK)
                    participantCountSelectionControl.Focus();
                return;
            }

            // Display and keep track of the workshop selected, number of days and the registration cost
            switch (selectedWorkshopIndex)
            {
                case 0:
                    selectedWorkshop = WORKSHOP_1;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_1;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_1.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_1;
                    numberOfTrainingDays = TRAINING_DAYS_1;
                    break;
                case 1:
                    selectedWorkshop = WORKSHOP_2;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_2;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_2.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_2;
                    numberOfTrainingDays = TRAINING_DAYS_2;
                    break;
                case 2:
                    selectedWorkshop = WORKSHOP_3;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_3;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_3.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_3;
                    numberOfTrainingDays = TRAINING_DAYS_3;
                    break;
                case 3:
                    selectedWorkshop = WORKSHOP_4;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_4;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_4.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_4;
                    numberOfTrainingDays = TRAINING_DAYS_4;
                    break;
                case 4:
                    selectedWorkshop = WORKSHOP_5;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_5;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_5.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_5;
                    numberOfTrainingDays = TRAINING_DAYS_5;
                    break;
                case 5:
                    selectedWorkshop = WORKSHOP_6;
                    selectedWorkshopDisplayLabel.Text = WORKSHOP_6;
                    numberOfDaysDisplayLabel.Text = TRAINING_DAYS_6.ToString() + DAYS_SUFFIX;
                    registrationCostPerParticipant = REGISTRATION_FEE_6;
                    numberOfTrainingDays = TRAINING_DAYS_6;
                    break;
                default:
                    // Handle exception of non-selection of a workshop
                    var messageBoxInstance = MessageBox.Show(NO_WORKSHOP_SELECTED_DESCRIPTION, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (messageBoxInstance == DialogResult.OK)
                        workshopSelectionListBox.Focus();
                    return;
            }

            // Obtain the selected location by means of its index in the ListBox control
            int selectedLocationIndex = locationSelectionListBox.SelectedIndex;

            // Display the location and keep track of the location and the base cost for lodging
            switch (selectedLocationIndex)
            {
                case 0:
                    selectedLocationDisplayLabel.Text = LOCATION_1;
                    selectedLocation = LOCATION_1;
                    baseLodgingCostPerParticipant = LODGING_FEE_1 * numberOfTrainingDays;
                    break;
                case 1:
                    selectedLocationDisplayLabel.Text = LOCATION_2;
                    selectedLocation = LOCATION_2;
                    baseLodgingCostPerParticipant = LODGING_FEE_2 * numberOfTrainingDays;
                    break;
                case 2:
                    selectedLocationDisplayLabel.Text = LOCATION_3;
                    selectedLocation = LOCATION_3;
                    baseLodgingCostPerParticipant = LODGING_FEE_3 * numberOfTrainingDays;
                    break;
                case 3:
                    selectedLocationDisplayLabel.Text = LOCATION_4;
                    selectedLocation = LOCATION_4;
                    baseLodgingCostPerParticipant = LODGING_FEE_4 * numberOfTrainingDays;
                    break;
                case 4:
                    selectedLocationDisplayLabel.Text = LOCATION_5;
                    selectedLocation = LOCATION_5;
                    baseLodgingCostPerParticipant = LODGING_FEE_5 * numberOfTrainingDays;
                    break;
                case 5:
                    selectedLocationDisplayLabel.Text = LOCATION_6;
                    selectedLocation = LOCATION_6;
                    baseLodgingCostPerParticipant = LODGING_FEE_6 * numberOfTrainingDays;
                    break;
                case 6:
                    selectedLocationDisplayLabel.Text = LOCATION_7;
                    selectedLocation = LOCATION_7;
                    baseLodgingCostPerParticipant = LODGING_FEE_7 * numberOfTrainingDays;
                    break;
                case 7:
                    selectedLocationDisplayLabel.Text = LOCATION_8;
                    selectedLocation = LOCATION_8;
                    baseLodgingCostPerParticipant = LODGING_FEE_8 * numberOfTrainingDays;
                    break;
                case 8:
                    selectedLocationDisplayLabel.Text = LOCATION_9;
                    selectedLocation = LOCATION_9;
                    baseLodgingCostPerParticipant = LODGING_FEE_9 * numberOfTrainingDays;
                    break;
                default:
                    // Handle exception of non-selection of a location
                    var messageBoxInstance = MessageBox.Show(NO_LOCATION_SELECTED_DESCRIPTION, ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (messageBoxInstance == DialogResult.OK)
                        locationSelectionListBox.Focus();
                    return;
            }

            // Display the number of participants
            selectedParticipantCountDisplayLabel.Text = participantCountValue.ToString();

            // Obtain the choice taken on the printed certificate option
            Boolean printedCertificateValue = printedCertificateSelectionCheckBox.Checked;

            // If applicable, keep track of the added cost for the printed certificate
            optionalCostPerParticipant = printedCertificateValue ? PRINTED_CERTIFICATE_COST : 0;

            // Display whether the printed certificate option is availed
            selectedPrintedCertificateDisplayLabel.Text = printedCertificateValue ? YES : NO;

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

            // Display the registration cost
            registrationCostDisplayLabel.Text = registrationCostValue.ToString("C");

            // Calculate the optional costs
            optionalCostValue = optionalCostPerParticipant * participantCountValue;

            // Display the optional costs
            addedOptionalCostDisplayLabel.Text = optionalCostValue.ToString("C");

            // Calculate the lodging cost
            lodgingCostValue = baseLodgingCostPerParticipant * participantCountValue;
            lodgingCostValue += addedLodgingCostPerParticipant * participantCountValue;

            // Display the lodging cost
            lodgingCostDisplayLabel.Text = lodgingCostValue.ToString("C");

            // Add the registration cost to the overall cost
            overallCost += registrationCostValue;

            // Add the lodging cost to the overall cost
            overallCost += lodgingCostValue;

            // Add the optional costs to the overall cost
            overallCost += optionalCostValue;

            // Check if discount is applicable
            isDiscounted = participantCountValue >= 4 && roomUpgradeAvailed;

            // If applicable, apply discount
            if (isDiscounted)
                overallCost *= (100 - DISCOUNT_RATE) / 100;

            // Display the overall cost
            overallCostDisplayLabel.Text = overallCost.ToString("C");

            // Display whether the group discount was applied
            discountAppliedDisplayLabel.Text = isDiscounted ? YES : NO;

            // Show screen with booking details
            homePanel.Hide();
            displayDetailsPanel.Show();

        }

        // Event handler called on toggling the checkbox for the printed certificate option
        private void printedCertificateSelectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Boolean printedCertificateSelectionValue = printedCertificateSelectionCheckBox.Checked;
            printedCertificateSelectionCheckBox.Text = printedCertificateSelectionValue ? YES : NO;
        }

        // Event handler called on clicking the "Book" button
        private void bookButton_Click(object sender, EventArgs e)
        {
            var messageBoxInstance = MessageBox.Show($"Do you wish to confirm booking of the {selectedWorkshop} workshop at {selectedLocation} for {overallCost.ToString("C")}?",
                ALERT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (messageBoxInstance == DialogResult.Yes)
            {
                // Go back to home screen
                homePanel.Show();
                displayDetailsPanel.Hide();

                // Update data for summary information
                totalNumberOfBookings++;
                totalRegistrationFees += registrationCostValue;
                totalLodgingFees += lodgingCostValue;
                totalOptionalFees += optionalCostValue;
                totalRevenue += overallCost;
                totalNumberOfDiscountedBookings += isDiscounted ? 1 : 0;

                resetFormAppearance();
            }
        }

        // Method to reset the form's appearance to it's initial state
        // (Disposing and initializing the entire form seems to cause an unsightly flicker)
        private void resetFormAppearance()
        {
            homePanel.Show();
            displayDetailsPanel.Hide();
            summaryPanel.Hide();
            workshopSelectionListBox.SelectedIndex = 0;
            locationSelectionListBox.SelectedIndex = 0;
            workshopSelectionListBox.ClearSelected();
            locationSelectionListBox.ClearSelected();
            participantCountSelectionControl.Value = 0;
            printedCertificateSelectionCheckBox.Checked = false;
            printedCertificateSelectionCheckBox.Text = NO;
            basicSuiteOptionRadioButton.Checked = true;
            juniorSuiteOptionRadioButton.Checked = false;
            masterSuiteOptionRadioButton.Checked = false;
            workshopSelectionListBox.Focus();
        }

        // Method to clear saved records of bookings
        private void clearSummaryData()
        {
            // Variables holding data for displaying summary information
            totalNumberOfBookings = 0;
            totalRegistrationFees = 0.00M;
            totalLodgingFees = 0.00M;
            totalOptionalFees = 0.00M;
            totalNumberOfDiscountedBookings = 0;
            totalRevenue = 0.00M;
        }

        // Event handler called on pressing the "Exit" button in the Summary screen
        private void summaryScreenExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler called on pressing the "Back" button in the Summary screen
        private void summaryScreenBackButton_Click(object sender, EventArgs e)
        {           
            // Go back to the main screen
            homePanel.Show(); 
            summaryPanel.Hide();
        }

        // Event handler called on pressing the "Clear" button in the Summary screen 
        private void summaryScreenClearButton_Click(object sender, EventArgs e)
        {
            // Reset the controls on the main screen to default
            resetFormAppearance();

            // Clear records of summary data
            clearSummaryData();
        }

        // Event handler called on pressing the "Summary" button
        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Prevent going to Summary screen if there are no bookings to show a summary of
            if (totalNumberOfBookings < 1) {
                MessageBox.Show(NO_BOOKINGS_YET_DESCRIPTION, ALERT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Show Summary screen
            summaryPanel.Show();

            // Hide home screen
            homePanel.Hide();

            // Display summary information from saved records
            totalNumberOfBookingsDisplayLabel.Text = totalNumberOfBookings.ToString();
            totalRegistrationFeesDisplayLabel.Text = totalRegistrationFees.ToString("C");
            totalLodgingFeesDisplayLabel.Text = totalLodgingFees.ToString("C");
            totalValueOfOptionsChosenDisplayLabel.Text = totalOptionalFees.ToString("C");
            numberOfDiscountedBookingsDisplayLabel.Text = totalNumberOfDiscountedBookings.ToString();
            averageRevenueDisplayLabel.Text = (totalRevenue / totalNumberOfBookings).ToString("C");
        }

        // Display a tooltip on hovering over the "Display" button
        private void displayButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(displayButton, DISPLAY_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Summary" button
        private void summaryButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(summaryButton, SUMMARY_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Clear" button
        private void clearButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(clearButton, CLEAR_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Exit" button
        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(exitButton, EXIT_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Back" button in the Display screen
        private void displayScreenBackButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(displayScreenBackButton, BACK_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Book" button
        private void bookButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(bookButton, BOOK_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Back" button in the Summary screen
        private void summaryScreenBackButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(displayScreenBackButton, BACK_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Clear" button in the Summary screen
        private void summaryScreenClearButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(clearButton, CLEAR_BUTTON_TOOLTIP_TEXT);
        }

        // Display a tooltip on hovering over the "Exit" button in the Summary screen
        private void summaryScreenExitButton_MouseHover(object sender, EventArgs e)
        {
            applicationToolTip.SetToolTip(exitButton, EXIT_BUTTON_TOOLTIP_TEXT);
        }

    }

}
