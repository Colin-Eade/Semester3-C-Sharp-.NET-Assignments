/*
 * Filename:    Form1.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023
 * Description: The Registration Application is a tool designed to streamline the student registration process. It 
 *              manages student data, evaluates eligibility for different programs, and maintains admission records. 
 */

namespace RegistrationApp
{
    // JSON Package
    using Newtonsoft.Json;

    public partial class Form1 : Form
    {
        /// <summary>
        /// Variables to grab form inputs
        /// Campus list that holds all campus and programs data
        /// </summary>
        string firstName;
        string lastName;
        string sin;
        string email;
        int admissionScore;
        int highSchoolGrade;
        string campusLocation;
        string programName;
        Student student;
        List<Student> students = new List<Student>();
        List<Campus> campuses = CollegeData.campuses;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks the eligibility of a student for admission based on the input from the form
        /// Evaluates the student's admission test score and high school grade against campus requirements
        /// Populates campus location combo if eligible
        /// informs the user of rejection if a student is ineligible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException">Thrown when the admission test score or high school grade is missing or invalid</exception>
        private void CheckEligibility(object sender, EventArgs e)
        {
            // List of eligible campuses for a student
            List<Campus> eligibleCampuses = new List<Campus>();

            // Grab the form inputs and try to make a new student object
            try
            {
                firstName = firstNameInput.Text;
                lastName = lastNameInput.Text;

                sin = sinInput.Text;
                CheckForUniqueSIN(sin);

                email = emailInput.Text;

                if (!int.TryParse(admissionTestCombo.Text, out admissionScore))
                    throw new ArgumentException("Admission test score is missing.");
                if (!int.TryParse(gradeCombo.Text, out highSchoolGrade))
                    throw new ArgumentException("High school grade is missing.");

                student = new Student(firstName, lastName, sin, email, admissionScore, highSchoolGrade, campusLocation, programName);

            }
            // Catch any invalid inputs
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ex.Message.Contains("First name"))
                {
                    firstNameInput.Clear();
                    firstNameInput.Focus();
                    firstNameInput.BackColor = Color.Red;
                }
                else if (ex.Message.Contains("Last name"))
                {
                    lastNameInput.Clear();
                    lastNameInput.Focus();
                    lastNameInput.BackColor = Color.Red;
                }
                else if (ex.Message.Contains("SIN"))
                {
                    sinInput.Clear();
                    sinInput.Focus();
                    sinInput.BackColor = Color.Red;
                }
                else if (ex.Message.Contains("Invalid email"))
                {
                    emailInput.Clear();
                    emailInput.Focus();
                    emailInput.BackColor = Color.Red;
                }
                else if (ex.Message.Contains("High school grade"))
                {
                    gradeCombo.Focus();
                    gradeCombo.BackColor = Color.Red;
                }
                else if (ex.Message.Contains("Admission test score"))
                {
                    admissionTestCombo.Focus();
                    admissionTestCombo.BackColor = Color.Red;
                }

                return;
            }

            // Check if the student is eligible for any campuses and add the campus to the list
            foreach (Campus campus in campuses)
            {
                if (student.AdmissionTestScore >= campus.AdmissionTSReq && student.HighSchoolGrade >= campus.HSGradeReq)
                    eligibleCampuses.Add(campus);
            }

            // Reject the application if the student is not eligible for any campus
            if (eligibleCampuses.Count == 0)
            {
                string message = "Application has been rejected.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form inputs
                ResetStudentInfoInputs();
                firstNameInput.Focus();

                ResetProgramInputs();

                // Disable the Program Availibility section
                availableProgramsGroup.Enabled = false;

                return;
            }

            // Student is eligible for at least one campus
            // Enable the Program Availibility section
            availableProgramsGroup.Enabled = true;

            // Refresh and populate the campus combo with the eligible campuses
            campusLocationCombo.Items.Clear();
            foreach (Campus campus in eligibleCampuses)
            {
                campusLocationCombo.Items.Add(campus);
            }
        }

        /// <summary>
        /// Refreshes and populates the programCombo with programs available from a selected campus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void campusLocationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh the items in the combo
            programsCombo.Items.Clear();

            // Check what campus is selected
            if (campusLocationCombo.SelectedItem is Campus selectedCampus)
            {
                // Populate the combo from the list of programs in the selected campus
                foreach (AcademicProgram program in selectedCampus.ListPrograms)
                {
                    programsCombo.Items.Add(program);
                }

                // Reset duration and cost fields
                studyPeriodOutput.Text = "0.00";
                totalCostOutput.Text = "$0.00";
            }
        }

        /// <summary>
        /// Calculates the total cost and displays the program length when a program is selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void programsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Grab the cost and duration information from the selected program and display it
            if (programsCombo.SelectedItem is AcademicProgram selectedProgram)
            {
                decimal totalCost = selectedProgram.ProgramDuration * selectedProgram.ProgramFees;
                studyPeriodOutput.Text = $"{selectedProgram.ProgramDuration:F2}";
                totalCostOutput.Text = $"${totalCost:F2}";
            }
        }

        /// <summary>
        /// Validates that a campus and program are selected for a student
        /// Registers a student if fields are valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterStudent(object sender, EventArgs e)
        {
            // Check if student information is filled out first
            if (availableProgramsGroup.Enabled == false)
            {
                string message = "Please check for eligibility before registering.";
                MessageBox.Show(message, "Form Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that a campus and program are selected
            try
            {
                if (campusLocationCombo.SelectedItem is null)
                    throw new Exception("Campus location is missing.");
                if (programsCombo.SelectedItem is null)
                    throw new Exception("Academic program is missing.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valid
            // Add campus location and program to the student object
            student.CampusLocation = campusLocationCombo.Text;
            student.ProgramName = programsCombo.Text;

            // Add student to the students list
            students.Add(student);

            // Refresh the datagrid and sin combo
            RefreshUI();

            // Reset the form inputs
            ResetStudentInfoInputs();
            firstNameInput.Focus();

            ResetProgramInputs();

            // Disable the Program Availibility section
            availableProgramsGroup.Enabled = false;

        }

        /// <summary>
        /// Populates the Student Information input fields with selected student data from the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            // If there is a selected row
            if (studentDataGrid.SelectedRows.Count > 0)
            {
                // Grab the selected row
                DataGridViewRow selectedRow = studentDataGrid.SelectedRows[0];

                // Match the SIN of the selected row to the SIN of a student in the students list
                foreach (Student student in students)
                {
                    if (selectedRow.Cells["sinColumn"].Value.ToString() == student.SIN)
                    {
                        // Populate the Student Information inputs with the data
                        firstNameInput.Text = student.FirstName;
                        lastNameInput.Text = student.LastName;
                        emailInput.Text = student.Email;
                        sinInput.Text = student.SIN;

                        // Set the admission test combo to the correct index
                        foreach (var item in admissionTestCombo.Items)
                        {
                            if (item.ToString() == student.AdmissionTestScore.ToString())
                            {
                                admissionTestCombo.SelectedItem = item;
                                break;
                            }
                        }
                        // Set the high school grade combo to the correct index
                        foreach (var item in gradeCombo.Items)
                        {
                            if (item.ToString() == student.HighSchoolGrade.ToString())
                            {
                                gradeCombo.SelectedItem = item;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the informationm of a student in the students list
        /// Refreshes the SIN combo and datagrid to reflect the updated info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateRecord(object sender, EventArgs e)
        {
            // If there is no SIN selected then inform the user
            if (sinCombo.SelectedIndex == -1)
            {
                string message = "Please select a SIN from the list.";
                MessageBox.Show(message, "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find the student in the student list with the same SIN 
            foreach (Student selectedStudent in students)
            {
                if (selectedStudent.SIN == sinCombo.SelectedItem.ToString())
                {
                    // Try to grab the Student Information fields and update the selected student's info
                    try
                    {
                        // Parse the admission test score selection
                        if (!int.TryParse(admissionTestCombo.Text, out admissionScore))
                            throw new ArgumentException("Admission test score is missing.");

                        // Parse the high school grade selection
                        if (!int.TryParse(gradeCombo.Text, out highSchoolGrade))
                            throw new ArgumentException("High school grade is missing.");

                        // Check if the grade adjustments are still within the required range of the student's selected campus
                        foreach (Campus campus in campuses)
                        {
                            if (selectedStudent.CampusLocation == campus.Location)
                            {
                                // Throw an exception if the chosen scores are below the eligible range
                                if (admissionScore < campus.AdmissionTSReq || highSchoolGrade < campus.HSGradeReq)
                                    throw new ArgumentException($"Admission test score and high school grade must be at least " +
                                                                $"{campus.AdmissionTSReq} and {campus.HSGradeReq} for a student to " +
                                                                $"remain eligible for the {campus.Location} campus. Please delete " +
                                                                $"this student and re-enter their new admission score and high " +
                                                                $"school grade data to check eligibility for the campus locations.");
                                break;
                            }
                        }

                        // Check to make sure the SIN is still unique
                        foreach (Student student in students)
                        {
                            if (sinInput.Text.Equals(student.SIN.ToString()) && student != selectedStudent)
                                throw new ArgumentException("Another student with this SIN already exists.");
                            break;
                        }

                        selectedStudent.FirstName = firstNameInput.Text;
                        selectedStudent.LastName = lastNameInput.Text;
                        selectedStudent.SIN = sinInput.Text;
                        selectedStudent.Email = emailInput.Text;
                        selectedStudent.AdmissionTestScore = admissionScore;
                        selectedStudent.HighSchoolGrade = highSchoolGrade;

                        break;
                    }

                    // Catch any invalid inputs
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Refresh the SIN combo and datagrid
            RefreshUI();

        }

        /// <summary>
        /// Deletes the record of a student in the student's list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRecord(object sender, EventArgs e)
        {
            // If there is no SIN selected then inform the user
            if (sinCombo.SelectedIndex == -1)
            {
                string message = "Please select a SIN from the list.";
                MessageBox.Show(message, "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Find the student in the student list with the same SIN 
            foreach (Student student in students)
            {
                if (student.SIN == sinCombo.SelectedItem.ToString())
                {
                    // Delete the student
                    students.Remove(student);
                    break;
                }
            }

            // Refresh the SIN combo and datagrid
            RefreshUI();

        }

        /// <summary>
        /// Clears all records and resets the form to its default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveAllRecords(object sender, EventArgs e)
        {
            // Clear the students list, SIN combo, and datagrid
            students.Clear();
            studentDataGrid.Rows.Clear();
            sinCombo.Items.Clear();

            // Reset the Student Information, and Available Programs sections
            ResetStudentInfoInputs();
            ResetProgramInputs();

            // Disable the Available programs section
            availableProgramsGroup.Enabled = false;
            firstNameInput.Focus();
        }

        /// <summary>
        /// Uploads the student list to an external JSON file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadRecordsToServer(object sender, EventArgs e)
        {
            // Check if there are any records
            if (students.Count == 0)
            {
                string message = "No records to upload.";
                MessageBox.Show(message, "No records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to append the students list to a JSON
            try
            {
                // List for exiting students in the JSON
                List<Student> existingStudents = new List<Student>();

                // Path to JSON
                string filePath = Environment.CurrentDirectory + @"\StudentRecords.json";

                // Ensure all SINs are unique
                CheckForUniqueSINJson(students);

                // If the JSON already exists
                if (File.Exists(filePath))
                {
                    // Deserialize it and grab the existing students from it
                    // Return an empty list if there are no values in it
                    string existingJson = File.ReadAllText(filePath);
                    existingStudents = JsonConvert.DeserializeObject<List<Student>>(existingJson) ?? new List<Student>(); ;
                }

                // Add the list of current students on the form to the existing students in the JSON
                existingStudents.AddRange(students);

                // Serialize the students list
                string json = JsonConvert.SerializeObject(existingStudents, Formatting.Indented);

                // Append to the JSON file
                // Deserializing and overwriting the JSON ensures format stays correct
                File.WriteAllText(filePath, json);

                // Reset the form
                RemoveAllRecords(sender, e);

                // Display a success message
                MessageBox.Show("Data uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            // Catch if invalid and infrom the user
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Checks that all students being uploaded to the JSON have unique SINs
        /// </summary>
        /// <param name="studentsToBeUploaded"></param>
        /// <returns>True when valid. Exception when invalid</returns>
        private bool CheckForUniqueSINJson(List<Student> studentsToBeUploaded)
        {
            // Path to JSON
            string filePath = Environment.CurrentDirectory + @"\StudentRecords.json";

            // Duplicate SINs list
            List<string> duplicateSINs = new List<string>();

            // Check if file exists
            if (!File.Exists(filePath))
            {
                return true; // Return true if it doesn't
            }

            // Deserialize the JSON into a list of student objects or create an empty list if null
            string json = File.ReadAllText(filePath);
            List<Student> existingStudents = JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();

            // No student objects found
            if (existingStudents.Count == 0)
            {
                return true; // Return true
            }

            // Check each student on the the form list
            foreach (Student student in studentsToBeUploaded)
            {
                // Check each student in the JSON
                foreach (Student existingStudent in existingStudents)
                {
                    // If there are duplicate sins then add them to a duplicate SIN list
                    if (student.SIN == existingStudent.SIN)
                    {
                        duplicateSINs.Add(student.SIN);
                    }
                }
            }

            // If there are any duplicate SINS
            if (duplicateSINs.Count > 0)
            {
                // Inform the user that they must modify their entries on the form before proceeding
                string errorMessage = "Students with these SINs already exist in the JSON file:\n\n" +
                             string.Join(", ", duplicateSINs) +
                             "\n\nPlease delete or modify the entries with these SINs before uploading.";
                throw new Exception(errorMessage);
            }

            // Return true if all is valid
            return true;

        }


        /// <summary>
        /// Refreshes the data in the SIN combo and datagrid
        /// </summary>
        private void RefreshUI()
        {
            // Refresh DataGridView
            studentDataGrid.Rows.Clear();
            foreach (Student student in students)
            {
                studentDataGrid.Rows.Add(student.FirstName, student.LastName, student.SIN, student.Email,
                                         student.HighSchoolGrade, student.AdmissionTestScore, student.CampusLocation,
                                         student.ProgramName);
            }

            // Refresh SIN Combo
            sinCombo.Items.Clear();
            foreach (Student student in students)
            {
                sinCombo.Items.Add(student.SIN);
            }

            // Prevent a row being selected by default
            studentDataGrid.ClearSelection();
            studentDataGrid.CurrentCell = null;
        }

        /// <summary>
        /// Resets the fields in the Student Information section
        /// </summary>
        private void ResetStudentInfoInputs()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            sinInput.Clear();
            emailInput.Clear();
            gradeCombo.SelectedIndex = -1;
            admissionTestCombo.SelectedIndex = -1;
        }

        /// <summary>
        /// Resets the fields in the Avaiable Programs section
        /// </summary>
        private void ResetProgramInputs()
        {
            campusLocationCombo.Items.Clear();
            programsCombo.Items.Clear();
            studyPeriodOutput.Text = "0.00";
            totalCostOutput.Text = "$0.00";
        }

        /// <summary>
        /// Checks if an inputted SIN is unique
        /// </summary>
        /// <returns></returns>
        private bool CheckForUniqueSIN(string sin)
        {
            // Check each student in the students list
            foreach (Student student in students)
            {
                // If the SIN already exists then throw an exception
                if (student.SIN == sin)
                    throw new ArgumentException("Student with this SIN already registered in the system for a program.");
            }

            // SIN is unique
            return true;
        }

        /// <summary>
        /// Opens the Help Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenHelpForm(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        /// <summary>
        /// Opens the Technical Support Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTechSupportForm(object sender, EventArgs e)
        {
            TechSupportForm techSupportForm = new TechSupportForm();
            techSupportForm.ShowDialog();
        }

        /// <summary>
        /// Opens the About Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAboutForm(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Resets the background colour for a form control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetControlBackColor(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = SystemColors.Window;
            }
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