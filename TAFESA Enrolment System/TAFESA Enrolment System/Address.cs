using System;

namespace TAFESA_Enrolment_System
{
    /// <summary>
    /// Represents an address with multiple attributes.
    /// </summary>
    public class Address
    {
        private const int DEF_STREETNUM = 0;
        private const string DEF_STREETNAME = "None";
        private const string DEF_SUBURB = "None";
        private const string DEF_POSTCODE = "0000";
        private const string DEF_STATE = "None";

        public int StreetNum { get; set; }          //Auto implement property
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // No-arg constructor
        public Address() : this(DEF_STREETNUM, DEF_STREETNAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) { }

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
