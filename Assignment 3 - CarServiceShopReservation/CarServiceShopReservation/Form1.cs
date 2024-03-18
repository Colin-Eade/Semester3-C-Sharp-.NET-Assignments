/*
 * Filename:    Form1.cs
 * Author:      Colin Eade
 * Date:        Novemeber 5, 2023
 * Description: Form that manages a car service shop reservation system
 */

namespace CarServiceShopReservation
{
    public partial class Form1 : Form
    {
        // Variables
        string firstName;
        string lastName;
        long phoneNumber;
        string make;
        string model;
        int year;
        string colour;
        bool engOilChange;
        bool transOilChange;
        bool airFilterChange;
        decimal price;
        string errorMessage = "";

        // Service object variable
        Service selectedServiceEntry;

        // Car manufacturer array
        public string[] manufacturers = { "Select a manufacturer", "Audi", "BMW", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Ford", "General Motors", "Honda", "Hyundai", "Jeep", "Kia", "Lamborghini", "Lexus", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Porsche", "Renault", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo" };

        // Year array
        public string[] years = new string[20];

        // List of Service objects
        List<Service> serviceList = new List<Service>();

        public Form1()
        {
            InitializeComponent();

            // Generate the array of years
            GenerateYears();

            // Add data to the dropdowns
            makeCombo.Items.AddRange(manufacturers);
            yearCombo.Items.AddRange(years);

            // Start the selections on index[0]
            makeCombo.SelectedIndex = 0;
            yearCombo.SelectedIndex = 0;
        }

        /// <summary>
        /// Generates the years for the year selection dropdown
        /// </summary>
        private void GenerateYears()
        {
            // Variables
            int year = 2023;

            // Index[0]
            years[0] = "Select a year";

            // Start at index[1] = 2023 and subtract 1 for each iteration
            for (int i = 1; i < years.Length; i++)
            {
                years[i] = year.ToString();
                year--;
            }
        }

        /// <summary>
        /// Validates the user inputs for the car service reservation form
        /// </summary>
        /// <param name="errorMessage">Outputs the error message if validation fails</param>
        /// <returns>Returns true if all validations pass, otherwise false</returns>
        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = "";

            // Validate first name
            if (string.IsNullOrWhiteSpace(firstNameInput.Text))
            {
                firstNameInput.Focus();
                errorMessage = "First name cannot be empty.";
                return false;
            }
            firstName = firstNameInput.Text.Trim();

            // Validate last name
            if (string.IsNullOrWhiteSpace(lastNameInput.Text))
            {
                lastNameInput.Focus();
                errorMessage = "Last name cannot be empty.";
                return false;
            }
            lastName = lastNameInput.Text.Trim();

            // Validate phone number
            if (string.IsNullOrWhiteSpace(phoneInput.Text))
            {
                phoneInput.Focus();
                errorMessage = "Phone number cannot be empty.";
                return false;
            }
            else if (!long.TryParse(phoneInput.Text, out phoneNumber) || phoneInput.Text.Length != 10)
            {
                phoneInput.Clear();
                phoneInput.Focus();
                errorMessage = "Phone number must be a 10-digit number.";
                return false;
            }

            // Validate make
            if (makeCombo.SelectedIndex == 0)
            {
                makeCombo.Focus();
                errorMessage = "Please select a car manufacturer.";
                return false;
            }
            make = makeCombo.Text;

            // Validate model
            if (string.IsNullOrWhiteSpace(modelInput.Text))
            {
                modelInput.Focus();
                errorMessage = "Model name cannot be empty.";
                return false;
            }
            model = modelInput.Text.Trim();

            // Validate year
            if (!int.TryParse(yearCombo.Text, out year))
            {
                yearCombo.Focus();
                errorMessage = "Please select a year.";
                return false;
            }

            // Validate colour
            if (string.IsNullOrWhiteSpace(colourInput.Text))
            {
                colourInput.Focus();
                errorMessage = "Colour cannot be empty.";
                return false;
            }
            colour = colourInput.Text.Trim();

            // Validate services
            if (!engineOilChangeCheck.Checked &&
                !transmissionOilChangeCheck.Checked &&
                !airFilterChangeCheck.Checked)
            {
                errorMessage = "Please select at least one service.";
                return false;
            }
            engOilChange = engineOilChangeCheck.Checked;
            transOilChange = transmissionOilChangeCheck.Checked;
            airFilterChange = airFilterChangeCheck.Checked;

            // If all validations pass
            return true;
        }

        /// <summary>
        /// Sets all input fields to their default state
        /// </summary>
        private void ResetInputFields()
        {
            // Set all input fields to their default state
            firstNameInput.Clear();
            lastNameInput.Clear();
            phoneInput.Clear();
            makeCombo.SelectedIndex = 0;
            modelInput.Clear();
            yearCombo.SelectedIndex = 0;
            colourInput.Clear();
            engineOilChangeCheck.Checked = false;
            transmissionOilChangeCheck.Checked = false;
            airFilterChangeCheck.Checked = false;

            // Reset the selected service entry to null
            selectedServiceEntry = null;

            // Focus on first name field
            firstNameInput.Focus();
        }

        /// <summary>
        /// Dynamically sets the cost output field based on the cost constants in the Service class
        /// </summary>
        private void SetCostOutput()
        {
            decimal totalCost = 0m;

            if (engineOilChangeCheck.Checked)
            {
                totalCost += Service.EngOilChgCost;
            }
            if (transmissionOilChangeCheck.Checked)
            {
                totalCost += Service.TransOilChgCost;
            }
            if (airFilterChangeCheck.Checked)
            {
                totalCost += Service.AirFilterChgCost;
            }
            costOutput.Text = totalCost.ToString("C");
        }

        /// <summary>
        /// Sets the cost output field accordingly if the engine oil service is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void engineOilChangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetCostOutput();
        }

        /// <summary>
        /// Sets the cost output field accordingly if the transmission oil service is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transmissionOilChangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetCostOutput();
        }

        /// <summary>
        /// Sets the cost output field accordingly if the air filter service is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void airFilterChangeCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetCostOutput();
        }

        /// <summary>
        /// Handles the click of the 'Add' button
        /// Validates the user inputs
        /// Returns an error on invalid inputs
        /// Upon valid input, creates a new instance of the Service class
        /// Adds the new instance to a list of Service objects
        /// Adds Service object information to a ListView display for the user to see
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate user inputs
            if (!ValidateInputs(out errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Create a new instance of the Service class
                Service service = new Service(firstName, lastName, phoneNumber, make, model, year, colour, engOilChange, transOilChange, airFilterChange, price);
                serviceList.Add(service);   // Add the new Service object to the list of Service objects

                // Add the Service object information to a row for the ListView
                ListViewItem row = new ListViewItem(service.IdentificationNumber.ToString());
                row.SubItems.Add(service.FirstName);
                row.SubItems.Add(service.LastName);
                row.SubItems.Add(service.PhoneNumber.ToString());
                row.SubItems.Add(service.Make);
                row.SubItems.Add(service.Model);
                row.SubItems.Add(service.Year.ToString());
                row.SubItems.Add(service.Colour);
                row.SubItems.Add(service.EngOilChange ? "Yes" : "No");      // Change True/False value to show Yes/No instead
                row.SubItems.Add(service.TransOilChange ? "Yes" : "No");
                row.SubItems.Add(service.AirFilterChange ? "Yes" : "No");
                row.SubItems.Add(service.Price.ToString());

                // Add the row to the ListView
                carServiceSummaryList.Items.Add(row);

                // Reset the input fields
                ResetInputFields();

            }
            // Catch any errors that might occur during adding a new service entry
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click of the 'New' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
        }

        /// <summary>
        /// Handles the event in which a row in the car service summary list is double-clicked
        /// Retrieves the selected service details and populates the input fields for viewing and editting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void carServiceSummaryList_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                // Store the row that was doubled-clicked as selectedRow
                ListViewItem selectedRow = carServiceSummaryList.SelectedItems[0];

                // Store the identification number string from the row
                string idNumberString = selectedRow.SubItems[0].Text;

                // Iterate through all objects stored in the service list
                foreach (Service service in serviceList)
                {
                    // Find the object with an identification number that is the same
                    // identification number as the double-clicked row's identification number
                    if (service.IdentificationNumber.ToString() == idNumberString)
                    {
                        // Store the matching service in a variable
                        selectedServiceEntry = service;

                        // Set the form input fields to the selected service object's information
                        firstNameInput.Text = selectedServiceEntry.FirstName;
                        lastNameInput.Text = selectedServiceEntry.LastName;
                        phoneInput.Text = selectedServiceEntry.PhoneNumber.ToString();
                        makeCombo.SelectedIndex = makeCombo.FindStringExact(selectedServiceEntry.Make);
                        modelInput.Text = selectedServiceEntry.Model;
                        yearCombo.SelectedIndex = yearCombo.FindStringExact(selectedServiceEntry.Year.ToString());
                        colourInput.Text = selectedServiceEntry.Colour;
                        engineOilChangeCheck.Checked = selectedServiceEntry.EngOilChange;
                        transmissionOilChangeCheck.Checked = selectedServiceEntry.TransOilChange;
                        airFilterChangeCheck.Checked = selectedServiceEntry.AirFilterChange;
                        // costOutput.Text = selectedServiceEntry.Price.ToString("C");

                        break;  // Break out of the loop
                    }
                }
            }
            // Catch any errors that may occur during a service entry selection click
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click of the 'Update' button
        /// Checks to see if a service entry has been selected (stored in selectServiceEntry)
        /// Validates the user inputs
        /// Returns an error on invalid inputs
        /// Upon valid input, updates existing selected service entry with the new input values
        /// Updates the ListView to reflect changes made to the service entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            // If a service entry has been selected
            if (selectedServiceEntry != null)
            {
                // Validate user inputs
                if (!ValidateInputs(out errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Iterate through all objects stored in the service list
                    foreach (Service service in serviceList)
                    {
                        // Match identification number with selected service entry
                        if (service.IdentificationNumber == selectedServiceEntry.IdentificationNumber)
                        {
                            // Update service properties with user inputs
                            service.FirstName = firstName;
                            service.LastName = lastName;
                            service.PhoneNumber = phoneNumber;
                            service.Make = make;
                            service.Model = model;
                            service.Year = year;
                            service.Colour = colour;
                            service.EngOilChange = engOilChange;
                            service.TransOilChange = transOilChange;
                            service.AirFilterChange = airFilterChange;
                            service.UpdatePrice(); // Update the price 

                            // Set the selected service to reflect the changes
                            selectedServiceEntry = service;

                            break;  // Break out of the loop
                        }
                    }

                    // Iterate through the ListView to find the row that corresponds to the selected service entry
                    foreach (ListViewItem row in carServiceSummaryList.Items)
                    {
                        // Update the Service object information to the right row in the ListView
                        if (row.Text == selectedServiceEntry.IdentificationNumber.ToString())
                        {
                            row.SubItems[1].Text = selectedServiceEntry.FirstName;
                            row.SubItems[2].Text = selectedServiceEntry.LastName;
                            row.SubItems[3].Text = selectedServiceEntry.PhoneNumber.ToString();
                            row.SubItems[4].Text = selectedServiceEntry.Make;
                            row.SubItems[5].Text = selectedServiceEntry.Model;
                            row.SubItems[6].Text = selectedServiceEntry.Year.ToString();
                            row.SubItems[7].Text = selectedServiceEntry.Colour;
                            row.SubItems[8].Text = selectedServiceEntry.EngOilChange ? "Yes" : "No";
                            row.SubItems[9].Text = selectedServiceEntry.TransOilChange ? "Yes" : "No";
                            row.SubItems[10].Text = selectedServiceEntry.AirFilterChange ? "Yes" : "No";
                            row.SubItems[11].Text = selectedServiceEntry.Price.ToString();

                            break;  // Break out of the loop
                        }
                    }
                }
                // Catch any errors that might occur during updating service entry
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Catch if no service entry has been selected
            else
            {
                MessageBox.Show("You must select a service entry in the table to update.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click of the 'Remove' button
        /// Removes the currently selected service entry from the ListView and the in-memory service list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            // If a service entry has been selected
            if (selectedServiceEntry != null)
            {
                try
                {
                    // Iterate through the ListView to find the row that corresponds to the selected service entry
                    foreach (ListViewItem row in carServiceSummaryList.Items)
                    {
                        // Remove the row
                        if (row.Text == selectedServiceEntry.IdentificationNumber.ToString())
                        {
                            carServiceSummaryList.Items.Remove(row);

                            break;  // Break out of loop
                        }
                    }
                    // Iterate through objects in the service list to find the row that corresponds to the selected service entry
                    foreach (Service service in serviceList)
                    {
                        // Delete the object
                        if (service.IdentificationNumber == selectedServiceEntry.IdentificationNumber)
                        {
                            serviceList.Remove(service);

                            break;  // Break out of loop
                        }
                    }

                    // Set selected service entry to null
                    selectedServiceEntry = null;

                    // Reset the input fields
                    ResetInputFields();
                }
                // Catch any errors that might occur during removing a service entry
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Catch if no service entry has been selected
            else
            {
                MessageBox.Show("You must select a service entry in the table to remove.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the click for the 'Remove all' button
        /// Removes all service entries from the ListView
        /// Deletes all Service objects from the Service object list
        /// Resets the form input fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeAllButton_Click(object sender, EventArgs e)
        {
            selectedServiceEntry = null;            // Set selected service entry to null
            serviceList.Clear();                    // Delete all objects in list
            carServiceSummaryList.Items.Clear();    // Remove all entries from ListView
            ResetInputFields();                     // Reset the input fields
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}