using System;


namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents a person's basic information.
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }// Aggregation

        // No-arg constructor
        public Person()
        {
            Name = "None";
            Email = "None";
            PhoneNumber = "None";
            Address = new Address();
        }

        // All-arg constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // Override Person details
        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {PhoneNumber}\n{Address}";
        }
    }
}

