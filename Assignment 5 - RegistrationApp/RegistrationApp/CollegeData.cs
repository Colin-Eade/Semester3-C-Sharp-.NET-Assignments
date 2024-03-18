/*
 * Filename:    CollegeData.cs
 * Author:      Colin Eade
 * Date:        December 3, 2023, 2023
 * Description: Handles the CollegeData class
 */

namespace RegistrationApp
{
    /// <summary>
    /// Creates a list of Programs and a list of campuses populated with Program data
    /// </summary>
    internal class CollegeData
    {
        // Programs List
        private static List<AcademicProgram> academicPrograms = new List<AcademicProgram>
        {
            new AcademicProgram("Architectural", 3000m, 3),
            new AcademicProgram("Engineering", 4500m, 3),
            new AcademicProgram("Science and Art", 3200m, 2),
            new AcademicProgram("Music", 2700m, 2),
            new AcademicProgram("Law", 4800m, 3),
            new AcademicProgram("Business", 4000m, 2),
            new AcademicProgram("Health", 3500m, 3)
        };

        // Campuses List
        public static List<Campus> campuses = new List<Campus>
        {
            new Campus("ON", 90, 80, 650m, academicPrograms),
            new Campus("QC", 90, 80, 500m, academicPrograms),
            new Campus("NS", 80, 70, 450m, new List<AcademicProgram> { academicPrograms[2], academicPrograms[3] }),
            new Campus("NB", 70, 70, 400m, new List<AcademicProgram> { academicPrograms[1], academicPrograms[4], academicPrograms[5] }),
            new Campus("MB", 80, 80, 500m, new List<AcademicProgram> { academicPrograms[0], academicPrograms[3] }), 
            new Campus("BC", 90, 90, 700m, academicPrograms),
            new Campus("PE", 80, 60, 300m, new List<AcademicProgram> { academicPrograms[2], academicPrograms[6] }),
            new Campus("SK", 80, 80, 450m, new List<AcademicProgram> { academicPrograms[1], academicPrograms[2], academicPrograms[6] }),
            new Campus("AB", 90, 80, 550m, academicPrograms),
            new Campus("NL", 80, 70, 450m, new List<AcademicProgram> { academicPrograms[0], academicPrograms[1], academicPrograms[5] })
        };
    }
}
