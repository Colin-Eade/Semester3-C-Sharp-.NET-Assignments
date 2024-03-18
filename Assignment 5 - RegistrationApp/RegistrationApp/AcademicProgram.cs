/*
 * Filename:    AcademicProgram.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the AcademicProgram class
 */

namespace RegistrationApp
{
    /// <summary>
    /// Represents a program within a school
    /// </summary>
    internal class AcademicProgram 
    {
        // Properties
        public string ProgramName { get; private set; }
        public decimal ProgramFees { get; private set; }
        public int ProgramDuration { get; private set; }

        /// <summary>
        /// Creates an instance of the AcademicProgram class
        /// </summary>
        /// <param name="programName">The program name</param>
        /// <param name="programFees">The annual cost of the program in dollars</param>
        /// <param name="programDuration">The duration of the program in years</param>
        public AcademicProgram(string programName, decimal programFees, int programDuration)
        {
            ProgramName = programName;
            ProgramFees = programFees;
            ProgramDuration = programDuration;
        }

        /// <summary>
        /// Overides the ToString() method to return the Program Name as a string
        /// </summary>
        /// <returns>The Program Name</returns>
        public override string ToString()
        {
            return ProgramName;
        }
    }
}
