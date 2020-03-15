using System.Collections.Generic;

namespace tyler_project0
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street {get; set;}
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNum { get; set; }
        public string Email {get; set;}
        public int UID {get; set;} = 12345679;
        public Dictionary<string, double> CustOrder { get; set; } = new Dictionary<string, double>();

    }
}