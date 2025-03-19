using System;


namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents a subject that a student can enroll in.
    /// </summary>
    public class Subject
    {
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        // No-arg constructor
        public Subject()
        {
            SubjectCode = "None";
            SubjectName = "None";
            Cost = 0.0;
        }

        // All-arg constructor
        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        // Override Subject details
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: ${Cost}";
        }
    }
}

