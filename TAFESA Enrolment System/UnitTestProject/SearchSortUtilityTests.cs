using NUnit.Framework;
using System;
using TAFESA_Enrolment_System;

namespace UnitTestProject_SearchSort
{
    public class SearchSortUtilityTests
    {
        private Student[] students;

        [SetUp]
        public void Setup()
        {
            students = new Student[]
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
        }

        [Test]
        public void LinearSearch_ShouldFindExistingStudent()
        {
            var target = new Student("", "", "", new Address(), 1004, "", DateTime.Now, new Enrollment());
            int index = SearchSortUtility.LinearSearchArray(students, target);
            Assert.That(students[index].StudentID, Is.EqualTo(1004));
        }

        [Test]
        public void LinearSearch_ShouldReturnMinusOneIfNotFound()
        {
            var notFound = new Student("", "", "", new Address(), 9999, "", DateTime.Now, new Enrollment());
            int index = SearchSortUtility.LinearSearchArray(students, notFound);
            Assert.That(index, Is.EqualTo(-1));
        }

        [Test]
        public void BinarySearch_ShouldFindExistingStudent()
        {
            Array.Sort(students);
            var target = new Student("", "", "", new Address(), 1004, "", DateTime.Now, new Enrollment());
            int index = SearchSortUtility.BinarySearchArray(students, target);
            Assert.That(index, Is.Not.EqualTo(-1));
            Assert.That(students[index].StudentID, Is.EqualTo(1004));
        }

        [Test]
        public void BinarySearch_ShouldReturnMinusOneIfNotFound()
        {
            Array.Sort(students);
            var notFound = new Student("", "", "", new Address(), 9999, "", DateTime.Now, new Enrollment());
            int index = SearchSortUtility.BinarySearchArray(students, notFound);
            Assert.That(index, Is.EqualTo(-1));
        }

        [Test]
        public void SortAsc_ShouldSortStudentsByIDAscending()
        {
            SearchSortUtility.SortAsc(students);
            for (int i = 0; i < students.Length - 1; i++)
            {
                Assert.That(students[i].StudentID, Is.LessThanOrEqualTo(students[i + 1].StudentID));
            }
        }

        [Test]
        public void SortDesc_ShouldSortStudentsByIDDescending()
        {
            SearchSortUtility.SortDesc(students);
            for (int i = 0; i < students.Length - 1; i++)
            {
                Assert.That(students[i].StudentID, Is.GreaterThanOrEqualTo(students[i + 1].StudentID));
            }
        }
    }
}

