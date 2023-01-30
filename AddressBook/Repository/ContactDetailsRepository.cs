using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        Dictionary<long, ContactDetails> contactDetails = new Dictionary<long, ContactDetails>();

        public void AddContactDetails(string firstName, string lastName, long mobileNumber, string eMail, string address, string city, string state, int zip)
        {
            ContactDetails contactDetail = new ContactDetails();
            contactDetail.FirstName = firstName;
            contactDetail.LastName = lastName;
            contactDetail.MobileNumber = mobileNumber;
            contactDetail.EMail = eMail;
            contactDetail.Address = address;
            contactDetail.City = city;
            contactDetail.State = state;
            contactDetail.Zip = zip;
            contactDetails.Add(contactDetail.MobileNumber, contactDetail);
        }

        public void DisplayContact()
        {
            foreach (var item in contactDetails)
            {
                Console.WriteLine($"\nFirst Name::{item.Value.FirstName}");
                Console.WriteLine($"Last Name::{item.Value.LastName}");
                Console.WriteLine($"Mobile Number::{item.Value.MobileNumber}");
                Console.WriteLine($"EMail::{item.Value.EMail}");
                Console.WriteLine($"Address::{item.Value.Address}");
                Console.WriteLine($"City::{item.Value.City}");
                Console.WriteLine($"State::{item.Value.State}");
                Console.WriteLine($"Zip::{item.Value.Zip}");
            }
        }
    }
}
