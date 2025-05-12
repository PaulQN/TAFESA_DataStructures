using System;
using System.Linq;


namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Entry point for testing the Student class functionality.
    /// </summary>
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("----- Address Class -----");
            //Address address1 = new Address(); // No-arg constructor
            //Address address2 = new Address(100, "A St", "Adelaide", "1212", "SA"); // All-arg constructor
            //Console.WriteLine($"No-arg Address: {address1.StreetNum} {address1.StreetName}, {address1.Suburb}, {address1.State}, {address1.Postcode}");
            //Console.WriteLine($"All-arg Address: {address2.StreetNum} {address2.StreetName}, {address2.Suburb}, {address2.State}, {address2.Postcode}\n");

            //Console.WriteLine("----- Subject Class -----");
            //Subject subject1 = new Subject(); // No-arg constructor
            //Subject subject2 = new Subject("CS101", "Data Structures", 1500); // All-arg constructor
            //Console.WriteLine($"No-arg Subject: {subject1.SubjectCode}, {subject1.SubjectName}, ${subject1.Cost}");
            //Console.WriteLine($"All-arg Subject: {subject2.SubjectCode}, {subject2.SubjectName}, ${subject2.Cost}\n");

            //Console.WriteLine("----- Enrollment Class -----");
            //Enrollment enrollment1 = new Enrollment(); // No-arg constructor
            //Enrollment enrollment2 = new Enrollment(DateTime.Parse("03-05-2025"), "A", 1, subject2); // All-arg constructor
            //Console.WriteLine($"No-arg Enrollment: {enrollment1.DateEnrolled}, {enrollment1.Grade}, Semester {enrollment1.Semester}");
            //Console.WriteLine($"All-arg Enrollment: {enrollment2.DateEnrolled}, {enrollment2.Grade}, Semester {enrollment2.Semester}\n");

            //Console.WriteLine("----- Person Class -----");
            //Person person1 = new Person(); // No-arg constructor
            //Person person2 = new Person("Paul Nguyen", "paul117@gmail.com", "0412345678", address2); // All-arg constructor
            //Console.WriteLine($"No-arg Person: {person1.Name}, {person1.Email}, {person1.PhoneNumber}");
            //Console.WriteLine($"All-arg Person: {person2.Name}, {person2.Email}, {person2.PhoneNumber}\n");

            //Console.WriteLine("----- Student Class -----");
            //Student student1 = new Student(); // No-arg constructor
            //Student student2 = new Student("Bob Tran", "bob123@gmail.com", "0498765432", address2, 0, "Computer Science", DateTime.Parse("01-01-2025"), enrollment1); // All-arg constructor
            //Console.WriteLine($"No-arg Student: {student1.Name}, {student1.StudentID}, {student1.Program}");
            //Console.WriteLine($"All-arg Student: {student2.Name}, {student2.StudentID}, {student2.Program}\n");

            //Console.WriteLine("----- Full Details Student Class -----");  // Test with full details for Student, including Person and Enrollment
            //Enrollment studentEnrollment = new Enrollment(DateTime.Parse("01-01-2025"), "A", 1, subject2);
            //Address studentAddress = new Address(200, "Bao St", "Adelaide", "2000", "SA");
            //Person studentPerson = new Person("Alice Dan", "alice@gmail.com", "0423456789", studentAddress);
            //Student student3 = new Student("Alice Dan", "alice@gmail.com", "0423456789", studentAddress, 1002, "Computer Science", DateTime.Parse("02-02-2025"), studentEnrollment);

            //Console.WriteLine($"Full-arg Student: {student3}\n");

            //Console.WriteLine("----- Testing Student Hashing and Comparison -----");
            //Student student4 = new Student("Student4", "s4@gmail.com", "0411111111", address2, 1001, "IT", DateTime.Now, new Enrollment());
            //Student student5 = new Student("Student5", "s5@gmail.com", "0422222222", address2, 1002, "Business", DateTime.Now, new Enrollment());

            //Console.WriteLine($"Student3 HashCode: {student3.GetHashCode()}");
            //Console.WriteLine($"Student4 HashCode: {student4.GetHashCode()}");
            //Console.WriteLine($"Student5 HashCode: {student5.GetHashCode()}\n");

            //Console.WriteLine("Student3 == Student4: " + (student3 == student4)); // False 
            //Console.WriteLine("Student3 == Student5: " + (student3 == student5)); // True




            // create 10 students
            Student[] students = new Student[]
            {
                new Student("Ali", "a@gmail.com", "0400000001", new Address(), 1005, "IT", DateTime.Now, new Enrollment()),
                new Student("Bob", "b@gmail.com", "0400000002", new Address(), 1002, "IT", DateTime.Now, new Enrollment()),
                new Student("Char", "c@gmail.com", "0400000003", new Address(), 1010, "IT", DateTime.Now, new Enrollment()),
                new Student("Dav", "d@gmail.com", "0400000004", new Address(), 1001, "IT", DateTime.Now, new Enrollment()),
                new Student("Eve", "e@gmail.com", "0400000005", new Address(), 1003, "IT", DateTime.Now, new Enrollment()),
                new Student("Frank", "f@gmail.com", "0400000006", new Address(), 1008, "IT", DateTime.Now, new Enrollment()),
                new Student("Grace", "g@gmail.com", "0400000007", new Address(), 1006, "IT", DateTime.Now, new Enrollment()),
                new Student("Hung", "h@gmail.com", "0400000008", new Address(), 1007, "IT", DateTime.Now, new Enrollment()),
                new Student("Iy", "i@gmail.com", "0400000009", new Address(), 1004, "IT", DateTime.Now, new Enrollment()),
                new Student("Jack", "j@gmail.com", "0400000010", new Address(), 1009, "IT", DateTime.Now, new Enrollment())
            };

            Console.WriteLine("Original List:");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} - {s.StudentID}");

            // Test Sort Ascending
            SearchSortUtility.SortAsc(students);
            Console.WriteLine("\nSorted Ascending (by StudentID):");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} - {s.StudentID}");

            // Test Sort Descending
            SearchSortUtility.SortDesc(students);
            Console.WriteLine("\nSorted Descending (by StudentID):");
            foreach (var s in students)
                Console.WriteLine($"{s.Name} - {s.StudentID}");

            // Find student has ID = 1004 equal Linear Search  
            var target = new Student("", "", "", new Address(), 1004, "", DateTime.Now, new Enrollment());
            int linearIndex = SearchSortUtility.LinearSearchArray(students, target);
            Console.WriteLine($"Linear Search - Index of StudentID 1004: {linearIndex}"); //index 6

            // Before Binary Search need sort ascending
            SearchSortUtility.SortAsc(students);
            int binaryIndex = SearchSortUtility.BinarySearchArray(students, target);
            Console.WriteLine($"Binary Search - Index of StudentID 1004: {binaryIndex}"); //index 3
            // Test not found
            var notFound = new Student("", "", "", new Address(), 9999, "", DateTime.Now, new Enrollment());
            int linearNF = SearchSortUtility.LinearSearchArray(students, notFound);
            int binaryNF = SearchSortUtility.BinarySearchArray(students, notFound);
            Console.WriteLine($"Linear Search - Not Found (9999): {linearNF}");
            Console.WriteLine($"Binary Search - Not Found (9999): {binaryNF}");

            Console.ReadKey();
        }
    }
}



