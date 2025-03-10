using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Entry point for testing the Student class functionality.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Creating student instances
            Student student1 = new Student { StudentID = 101, Program = "IT", DateRegister = DateTime.Parse("2025-01-01") };
            Student student2 = new Student { StudentID = 102, Program = "Business", DateRegister = DateTime.Parse("2025-02-01") };
            Student student3 = new Student { StudentID = 101, Program = "IT", DateRegister = DateTime.Parse("2025-01-01") };

            // Test Equals() method
            Console.WriteLine("student1 == student3: " + (student1 == student3)); // True
            Console.WriteLine("student1 != student2: " + (student1 != student2)); // True

            // Test GetHashCode()
            Console.WriteLine($"Hash code of student1: {student1.GetHashCode()}");
            Console.WriteLine($"Hash code of student3: {student3.GetHashCode()}"); // Should be the same as student1
            Console.WriteLine($"Hash code of student2: {student2.GetHashCode()}"); // Should be different
        }
    }
}
