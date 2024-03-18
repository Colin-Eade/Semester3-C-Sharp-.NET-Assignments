/*
 * Filename:    Student.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the Student class
 */

using System.Text.RegularExpressions;

namespace RegistrationApp
{
    /// <summary>
    /// Represents a Student
    /// </summary>
    internal class Student
    {

        // Properties
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                // Validate for empty property
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");
                _firstName = value;
            }
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                // Validate for empty property
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                _lastName = value;
            }
        }
        private string _sin;
        public string SIN
        {
            get => _sin;
            set
            {
                // Validate for empty property and proper SIN format
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9 || !value.All(char.IsDigit))
                    throw new ArgumentException("SIN must be a 9-digit number.");
                _sin = value;
            }
        }
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                // Validate for proper email format
                if (!ValidateEmail(value))
                    throw new ArgumentException("Invalid email format.");
                _email = value;
            }
        }
        private int _highSchoolGrade;
        public int HighSchoolGrade
        {
            get => _highSchoolGrade;
            set
            {
                // Validate for correct grade range
                if (value < 0 || value > 100)
                    throw new ArgumentException("High school grade must be between 0 and 100.");
                _highSchoolGrade = value;
            }
        }
        private int _admissionTestScore;
        public int AdmissionTestScore
        {
            get => _admissionTestScore;
            set
            {
                // Validate for correct test score range
                if (value < 0 || value > 100)
                    throw new ArgumentException("Admission test score must be between 0 and 100.");
                _admissionTestScore = value;
            }
        }
        public string CampusLocation { get; set; }
        public string ProgramName { get; set; }

        /// <summary>
        /// Initilizes an instance of the student class
        /// </summary>
        /// <param name="firstName">The student's first name</param>
        /// <param name="lastName">The student's last name</param>
        /// <param name="sin">The student's SIN number</param>
        /// <param name="email">The student's email address</param>
        /// <param name="highSchoolGrade">The student's high school grade</param>
        /// <param name="admissionTestScore">The student's admission test score</param>
        /// <param name="campusLocation">The student's campus location</param>
        /// <param name="programName">The student's program name</param>
        public Student(string firstName, string lastName, string sin, string email, int highSchoolGrade, int admissionTestScore,
                       string campusLocation, string programName)
        {
            FirstName = firstName;
            LastName = lastName;
            SIN = sin;
            Email = email;
            HighSchoolGrade = highSchoolGrade;
            AdmissionTestScore = admissionTestScore;
            CampusLocation = campusLocation;
            ProgramName = programName;
        }

        /// <summary>
        /// Validates an email for proper format
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True on a valid email and false on an invalid email</returns>
        private bool ValidateEmail(string email)
        {
            // String expression to define a valid email address
            string emailFormat = @"^\S+@\S+\.\S+$";

            // Check if the email passed through the function matches the expression for a valid email
            return Regex.IsMatch(email, emailFormat);
        }

        /// <summary>
        /// Overides the ToString() method to return the SIN as a string
        /// </summary>
        /// <returns>The SIN</returns>
        public override string ToString()
        {
            return SIN;
        }

    }
}
