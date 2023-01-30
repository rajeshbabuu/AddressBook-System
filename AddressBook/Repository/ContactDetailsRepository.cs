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

        public void AddContactDetails(ContactDetails contactDetail) //using mobileNumber because it is unique.
        {
            contactDetails.Add(contactDetail.MobileNumber, contactDetail);
        }

        public void EditContactDetails(long mobileNumber)
        {
            var obj = contactDetails[mobileNumber];
            contactDetails.Remove(mobileNumber);
            Console.WriteLine("\nSelect from below to edit (Enter number 1-8) \n1.First Name \n2.Last Name \n3.Mobile Number \n4.EMail \n5.Address \n6.City \n7.State \n8.Zip \n");
            int edit = Convert.ToInt32(Console.ReadLine());
            switch (edit)
            {
                case 1:
                    Console.WriteLine("\nEnter New First Name");
                    string firstName = Console.ReadLine();
                    obj.FirstName = firstName;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 2:
                    Console.WriteLine("\nEnter New Last Name");
                    string lastName = Console.ReadLine();
                    obj.LastName = lastName;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 3:
                    Console.WriteLine("\nEnter New Mobile Number");
                    mobileNumber = Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobileNumber;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 4:
                    Console.WriteLine("\nEnter New EMail");
                    string email = Console.ReadLine();
                    obj.EMail = email;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 5:
                    Console.WriteLine("\nEnter New Address");
                    string address = Console.ReadLine();
                    obj.Address = address;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 6:
                    Console.WriteLine("\nEnter New City");
                    string city = Console.ReadLine();
                    obj.City = city;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 7:
                    Console.WriteLine("\nEnter New State");
                    string state = Console.ReadLine();
                    obj.State = state;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
                case 8:
                    Console.WriteLine("\nEnter New Zip");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zip;
                    contactDetails.Add(obj.MobileNumber, obj);
                    break;
            }
        }

        public void DeleteContact(long mobileNumber)
        {
            var obj = contactDetails[mobileNumber];
            contactDetails.Remove(mobileNumber);
        }

        public void DisplayContact()
        {
            foreach (var item in contactDetails)
            {
                Console.WriteLine($"\nFirst Name      ::{item.Value.FirstName}");
                Console.WriteLine($"Last Name       ::{item.Value.LastName}");
                Console.WriteLine($"Mobile Number   ::{item.Value.MobileNumber}");
                Console.WriteLine($"EMail           ::{item.Value.EMail}");
                Console.WriteLine($"Address         ::{item.Value.Address}");
                Console.WriteLine($"City            ::{item.Value.City}");
                Console.WriteLine($"State           ::{item.Value.State}");
                Console.WriteLine($"Zip             ::{item.Value.Zip}");
            }
        }
    }
}
