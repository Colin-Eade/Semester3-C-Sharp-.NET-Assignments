/*
 * Filename:    Campus.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the Campus class
 */

namespace RegistrationApp
{
    /// <summary>
    /// Represents a school campus that a student applies to
    /// </summary>
    internal class Campus
    {

        // Properties
        public string Location { get; private set; }
        public int HSGradeReq { get; private set; }
        public int AdmissionTSReq { get; private set; }
        public decimal RegFees { get; private set; }
        public List<AcademicProgram> ListPrograms { get; private set; }

        /// <summary>
        /// Creates an instance of the Campus class
        /// </summary>
        /// <param name="hsGradeReq">The requirement High School Grade to be admitted</param>
        /// <param name="admissionTSReq">The required admission test score to be admitted</param>
        /// <param name="regFees">The registration fees for the campus</param>
        /// <param name="listPrograms">The list of programs the campus offers</param>
        public Campus(string location, int hSGradeReq, int admissionTSReq, decimal regFees, List<AcademicProgram> listPrograms)
        {
            Location = location;
            HSGradeReq = hSGradeReq;
            AdmissionTSReq = admissionTSReq;
            RegFees = regFees;
            ListPrograms = listPrograms;
        }

        /// <summary>
        /// Overides the ToString() method to return the Campus Location as a string
        /// </summary>
        /// <returns>The Campus Location</returns>
        public override string ToString()
        {
            return Location;
        }
    }
}
