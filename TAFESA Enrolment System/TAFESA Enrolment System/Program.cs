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
            Console.WriteLine("----- Testing Address Class -----");
            Address address1 = new Address();
            Address address2 = new Address(100, "A St", "Adelaide", "1212", "SA");
            Console.WriteLine($"No-arg Address: {address1.StreetNum} {address1.StreetName}, {address1.Suburb}, {address1.State}, {address1.Postcode}");
            Console.WriteLine($"All-arg Address: {address2.StreetNum} {address2.StreetName}, {address2.Suburb}, {address2.State}, {address2.Postcode}\n");

            Console.WriteLine("----- Testing Person Class -----");
            Person person1 = new Person();
            Person person2 = new Person("Paul Nguyen", "paul117@gmail.com", "0412345678", address2);
            Console.WriteLine($"No-arg Person: {person1.Name}, {person1.Email}, {person1.PhoneNumber}");
            Console.WriteLine($"All-arg Person: {person2.Name}, {person2.Email}, {person2.PhoneNumber}\n");

            Console.WriteLine("----- Testing Student Class -----");
            Student student1 = new Student();
            Student student2 = new Student("Bob Tran", "bob123@gmail.com", "0498765432", address2, 0, "Computer Science", DateTime.Parse("01-01-2025"));
            Console.WriteLine($"No-arg Student: {student1.Name}, {student1.StudentID}, {student1.Program}");
            Console.WriteLine($"All-arg Student: {student2.Name}, {student2.StudentID}, {student2.Program}\n");

            Console.WriteLine("----- Testing Subject Class -----");
            Subject subject1 = new Subject();
            Subject subject2 = new Subject("CS101", "Data Structures", 1500);
            Console.WriteLine($"No-arg Subject: {subject1.SubjectCode}, {subject1.SubjectName}, ${subject1.Cost}");
            Console.WriteLine($"All-arg Subject: {subject2.SubjectCode}, {subject2.SubjectName}, ${subject2.Cost}\n");

            Console.WriteLine("----- Testing Enrollment Class -----");
            Enrollment enrollment1 = new Enrollment();
            Enrollment enrollment2 = new Enrollment(DateTime.Parse("03-05-2025"), "A", 1, subject2);
            Console.WriteLine($"No-arg Enrollment: {enrollment1.DateEnrolled}, {enrollment1.Grade}, Semester {enrollment1.Semester}");
            Console.WriteLine($"All-arg Enrollment: {enrollment2.DateEnrolled}, {enrollment2.Grade}, Semester {enrollment2.Semester}\n");

            Console.WriteLine("----- Testing Student Hashing and Comparison -----");
            Student student3 = new Student("Student3", "s3@gmail.com", "0412345678", address2, 1001, "IT", DateTime.Now);
            Student student4 = new Student("Student4", "s4@gmail.com", "0411111111", address2, 1001, "IT", DateTime.Now);
            Student student5 = new Student("Student5", "s5@gmail.com", "0422222222", address2, 2002, "Business", DateTime.Now);

            Console.WriteLine($"Student3 HashCode: {student3.GetHashCode()}");
            Console.WriteLine($"Student4 HashCode: {student4.GetHashCode()}");
            Console.WriteLine($"Student5 HashCode: {student5.GetHashCode()}\n");

            Console.WriteLine("Student3 == Student4: " + (student3 == student4)); // True 
            Console.WriteLine("Student3 == Student5: " + (student3 == student5)); // False
            Console.WriteLine("Student3 Equals Student4: " + student3.Equals(student4)); // True 

        }
    }
}
