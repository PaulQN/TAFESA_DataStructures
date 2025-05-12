using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents a Student with an ID, program, and registration date.
    /// Implements hashing and equality comparison.
    /// </summary>
    public class Student : Person, IComparable<Student>
    //inherit, enable CompareTo(), sort(), binary()

    {
        private const int DEF_STUDENTID = 0;
        private const string DEF_PROGRAM = "None";

        public int StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Enrollment Enrollment { get; set; }

        // No-arg constructor
        public Student() : this(DEF_NAME, DEF_EMAIL, DEF_PHONENUMBER, new Address(), DEF_STUDENTID, DEF_PROGRAM, DateTime.Now, new Enrollment()) { }

        // All-arg constructor (including Person data)
        public Student(string name, string email, string phoneNumber, Address address, int studentID, string program, DateTime dateRegistered, Enrollment enrollment)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        /// <summary>
        /// Overrides the Equals method to compare Student objects based on StudentID.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
                return this.StudentID == otherStudent.StudentID;
            return false;
        }

        /// <summary>
        /// Overrides the GetHashCode method using StudentID.
        /// </summary>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

        /// <summary>
        /// Overloads the == operator to compare Student objects by StudentID.
        /// </summary>
        public static bool operator ==(Student s1, Student s2)
        {
            if (ReferenceEquals(s1, s2)) return true;
            if (s1 is null || s2 is null) return false;
            return s1.StudentID == s2.StudentID;
        }

        /// <summary>
        /// Overloads the != operator to compare Student objects.
        /// </summary>
        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1 == s2);
        }

        // Override Student details
        public override string ToString()
        {
            return base.ToString() + "\nStudent ID: " + StudentID + " Program: " + Program + " Registered On: " + DateRegistered.ToShortDateString() + "\n" + Enrollment;
        }

        /// <summary>
        /// Compares this student to another student based on StudentID.
        /// </summary>
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return this.StudentID.CompareTo(other.StudentID);
        }

    }
}
