/*
 * Filename:    AboutForm.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the About section of the main form
 */

namespace RegistrationApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Handler for all exit buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Close();
        }
    }
}
