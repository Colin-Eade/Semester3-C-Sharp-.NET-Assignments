/* Colin Eade
 * Last Modified: September 28, 2023
 * Average Weekly Videogame Sales Form
 * App that takes and validates an input for each day of sales for a week, then outputs the average
 * Accessibility keys are provided in the comments for each button function
 */

namespace AverageWeeklyVideogameSalesForm
{
    public partial class averageSalesForm : Form
    {
        // Constants
        const int MAX_VALUE = int.MaxValue;    // The maximum accepted input value
        const int MIN_VALUE = 0;               // The minimum accepted input value
        const int MAX_ITERATION = 7;           // The max iteration for the count and days

        // Variables
        int day = 1;                            // dayLabel number
        int count;                              // counter for 7 days
        int salesSum;                           // Sum of the inputted sales for the week
        double salesAverage;                    // Average sales for the week

        public averageSalesForm()
        {
            InitializeComponent();

            // Set the dayLabel and output
            dayLabel.Text = $"Day #{day}";
            outputLabel.Text = $"Average Videogame Sales: ${salesAverage:F2}";
        }

        /*
         * Closes the app upon pressing the Exit button
         * Accessibility key: (ALT + X)
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Resets all fields to their default statem upon pressing the Reset Button
         * Accessibilty key: (ALT + R) or (ESC)
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset variables
            day = 1;
            count = 0;
            salesSum = 0;
            salesAverage = 0;

            // Reset Buttons and fields
            salesInput.Clear();
            salesInput.Focus();
            salesInput.ReadOnly = false;
            entryList.Items.Clear();
            enterButton.Enabled = true;
            dayLabel.Text = $"Day #{day}";
            outputLabel.Text = $"Average Videogame Sales: ${salesAverage:F2}";
        }

        /*
         * Enters the user sales input into a list
         * Calculates a running total of the average sales
         * Locks the enter button and the input field after accepting 7 valid inputs
         * Accessibility key: (ALT + E) or (ENTER)
         */
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Grab the user input
            string userInput = salesInput.Text;

            // Validate the input
            if (!int.TryParse(userInput, out int salesInteger) || salesInteger < MIN_VALUE || salesInteger > MAX_VALUE)
            {
                // If it is not valid display an error and clear the input
                MessageBox.Show($"Please enter a whole number value between {MIN_VALUE} and {MAX_VALUE}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesInput.Clear();
                salesInput.Focus();
            }
            // Input is valid
            else
            {
                // add the input to the list
                entryList.Items.Add($"${salesInteger:F2}");

                // Clear the input field
                salesInput.Clear();
                salesInput.Focus();

                // Add 1 to the counter
                count += 1;

                // Add the sales to the sum
                salesSum += salesInteger;

                // Calculate the average sales
                // Convert the salesSum and count to a double to get proper decimal values
                salesAverage = (double)salesSum / (double)count;
                salesAverage = Math.Round(salesAverage, 2);

                // Change the output text
                outputLabel.Text = $"Average Videogame Sales: ${salesAverage:F2}";

                // Count up the days until they get to 7
                if (day < MAX_ITERATION)
                {
                    day += 1;
                    dayLabel.Text = $"Day #{day}";
                }
            }
            // Once there are 7 valid entries
            if (count == MAX_ITERATION)
            {
                // Make the input ReadOnly and lock the enter button
                salesInput.ReadOnly = true;
                enterButton.Enabled = false;
            }
        }
    }
}