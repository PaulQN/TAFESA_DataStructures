using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents a subject that a student can enroll in.
    /// </summary>
    public class Subject
    {
        private const string DEF_SubjectCode = "None";
        private const string DEF_SubjectName = "None";
        private const int DEF_Cost = 0;

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Cost { get; set; }

        // No-arg constructor
        public Subject() : this(DEF_SubjectCode, DEF_SubjectName, DEF_Cost) { }

        // All-arg constructor
        public Subject(string subjectCode, string subjectName, int cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        // Override Subject details
        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + " Subject Name: " + SubjectName + " Cost: $" + Cost;
        }
    }
}
