using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents an address with multiple attributes.
    /// </summary>
    public class Address
    {
        private const int DEF_StreetNum = 0;
        private const string DEF_StreetName = "None";
        private const string DEF_Suburb = "None";
        private const string DEF_Postcode = "0000";
        private const string DEF_State = "None";

        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // No-arg constructor
        public Address() : this(DEF_StreetNum, DEF_StreetName, DEF_Suburb, DEF_Postcode, DEF_State) { }

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
            return "Address: " + StreetNum + " " + StreetName + ", " + Suburb + ", " + State + ", " + Postcode;
        }
    }
}
