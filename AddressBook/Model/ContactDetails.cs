using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model
{
    internal class ContactDetails
    {
        public string? UniqueName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long MobileNumber { get; set; }
        public string? EMail { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Zip { get; set; }
    }
}
