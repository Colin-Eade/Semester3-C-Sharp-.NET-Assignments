/*
 * Filename:    MainForm.cs
 * Author:      Colin Eade
 * Date:        December 11, 2023
 * Description: Simple form that takes a text input and uses Azure AI Text Analytics to output a summary
 */

namespace AzureAbstractSummaryTest
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Summarizes the user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void summarizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Loading wheel
                Cursor = Cursors.WaitCursor;

                // Summarize the input and return a string
                string summarizedText = await AzureFunctions.SummarizeText(userInput.Text);

                // Output the summary
                summaryOutput.Text = summarizedText;

            }
            // Catch any errors and inform the user
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset the cursor
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Clears the default text when a user clicks on the input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userInput_Click(object sender, EventArgs e)
        {
            if (userInput.Text == "Enter text to summarize")
                userInput.Clear();
        }

        /// <summary>
        /// Copies the summary output to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(summaryOutput.Text);
        }

        /// <summary>
        /// Resets the form to its default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            userInput.Text = "Enter text to summarize";
            summaryOutput.Text = "Summary";
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
