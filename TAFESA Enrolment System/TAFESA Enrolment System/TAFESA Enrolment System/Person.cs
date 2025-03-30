using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents a person's basic information.
    /// </summary>
    public class Person
    {
        public const string DEF_Name = "None";
        public const string DEF_Email = "None";
        public const string DEF_PhoneNumber = "None";

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        // No-arg constructor
        public Person() : this(DEF_Name, DEF_Email, DEF_PhoneNumber, new Address()) { }

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
            return "Name: " + Name + " Email: " + Email + " Phone: " + PhoneNumber + "\n" + Address;
        }
    }
}
