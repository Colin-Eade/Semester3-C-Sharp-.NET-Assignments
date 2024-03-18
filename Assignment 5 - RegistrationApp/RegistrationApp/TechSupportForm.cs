/*
 * Filename:    TechSupportForm.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the Tech Support contact section of the main form
 */

namespace RegistrationApp
{
    public partial class TechSupportForm : Form
    {
        public TechSupportForm()
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
