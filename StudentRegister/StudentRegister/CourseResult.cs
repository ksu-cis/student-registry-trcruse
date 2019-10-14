using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public class CourseResult
    {
        public string Course { get; protected set; }

        public uint CreditHours { get; protected set; }

        public Grade Grade { get; protected set; }
        
        public string Semester { get; protected set; }
        
        /// <summary>
        /// Constructor builds out these properties
        /// </summary>
        /// <param name="course"></param>
        /// <param name="hours"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        public CourseResult(string course, uint hours, Grade grade, string semester)
        {
            Course = course;
            CreditHours = hours;
            Grade = grade;
            Semester = semester;
        }
    }
}
