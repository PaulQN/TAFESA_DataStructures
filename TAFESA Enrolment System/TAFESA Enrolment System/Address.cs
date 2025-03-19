using System;


namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents an address with multiple attributes.
    /// </summary>
    public class Address
    {
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // No-arg constructor
        public Address()
        {
            StreetNum = 0;
            StreetName = "None";
            Suburb = "None";
            Postcode = "0000";
            State = "None";
        }

        // All-arg constructor
        public Address(int streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // Override Address 
        public override string ToString()
        {
            return $"Address: {StreetNum} {StreetName}, {Suburb}, {State}, {Postcode}";
        }
    }

}

