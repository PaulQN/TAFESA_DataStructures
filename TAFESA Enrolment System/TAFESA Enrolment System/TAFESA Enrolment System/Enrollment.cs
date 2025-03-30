using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents an enrollment record for a student.
    /// </summary>
    public class Enrollment
    {
        private const string DEF_Grade = "None";
        private const int DEF_Semester = 0;

        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }
        public Subject Subject { get; set; }

        // No-arg constructor
        public Enrollment() : this(DateTime.MinValue, DEF_Grade, DEF_Semester, new Subject()) { }

        // All-arg constructor
        public Enrollment(DateTime dateEnrolled, string grade, int semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // Override Enrollment details
        public override string ToString()
        {
            return "Enrolled on: " + DateEnrolled.ToShortDateString() + " Grade: " + Grade + " Semester: " + Semester + "\n" + Subject;
        }
    }
}
