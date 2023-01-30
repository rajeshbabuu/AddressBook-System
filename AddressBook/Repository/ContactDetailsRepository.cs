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
        Dictionary<string, ContactDetails> contactDetails = new Dictionary<string, ContactDetails>();

        int contact = 0;
        public void AddContactDetails(ContactDetails contactDetail)
        {
            if (contact == 0)
            {
                contactDetails.Add(contactDetail.UniqueName, contactDetail);
                contact++;
            }
            else if (contact != 0)
            {
                var objDuplicateCheck = contactDetails.Where(x => x.Value.FirstName.Equals(contactDetail.FirstName));
                if (!objDuplicateCheck.Any())
                {
                    contactDetails.Add(contactDetail.UniqueName, contactDetail);
                    contact++;
                }
                else
                {
                    Console.WriteLine($"\n{contactDetail.FirstName} {contactDetail.LastName}'s details already exists");
                }
            }
        }

        public void EditContactDetails(string uniqueName)
        {
            var obj = contactDetails[uniqueName];
            contactDetails.Remove(uniqueName);
            Console.WriteLine("\nSelect from below to edit (Enter number 1-8) \n1.First Name \n2.Last Name \n3.Mobile Number \n4.EMail \n5.Address \n6.City \n7.State \n8.Zip \n");
            int edit = Convert.ToInt32(Console.ReadLine());
            switch (edit)
            {
                case 1:
                    Console.WriteLine("\nEnter New First Name");
                    string firstName = Console.ReadLine();
                    obj.FirstName = firstName;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 2:
                    Console.WriteLine("\nEnter New Last Name");
                    string lastName = Console.ReadLine();
                    obj.LastName = lastName;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 3:
                    Console.WriteLine("\nEnter New Mobile Number");
                    long mobileNumber = Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobileNumber;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 4:
                    Console.WriteLine("\nEnter New EMail");
                    string email = Console.ReadLine();
                    obj.EMail = email;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 5:
                    Console.WriteLine("\nEnter New Address");
                    string address = Console.ReadLine();
                    obj.Address = address;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 6:
                    Console.WriteLine("\nEnter New City");
                    string city = Console.ReadLine();
                    obj.City = city;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 7:
                    Console.WriteLine("\nEnter New State");
                    string state = Console.ReadLine();
                    obj.State = state;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 8:
                    Console.WriteLine("\nEnter New Zip");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zip;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
            }
        }

        public void DeleteContact(string uniqueName)
        {
            var obj = contactDetails[uniqueName];
            contactDetails.Remove(uniqueName);
        }

        public void SearchContact()
        {
            int count = 0;
            Console.WriteLine("\nEnter 1 to Search by City \nEnter 2 to Search by State");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("\nEnter City: ");
                string city = Console.ReadLine();
                var objDuplicateCheck = contactDetails.Where(x => x.Value.City.Equals(city));
                Console.WriteLine($"\nFound Contacts ====> ");
                foreach (var item in objDuplicateCheck)
                {
                    count++;
                    Console.WriteLine($"\nUnique Name     ::{item.Value.UniqueName}");
                    Console.WriteLine($"First Name      ::{item.Value.FirstName}");
                    Console.WriteLine($"Last Name       ::{item.Value.LastName}");
                    Console.WriteLine($"Mobile Number   ::{item.Value.MobileNumber}");
                    Console.WriteLine($"EMail           ::{item.Value.EMail}");
                    Console.WriteLine($"Address         ::{item.Value.Address}");
                    Console.WriteLine($"City            ::{item.Value.City}");
                    Console.WriteLine($"State           ::{item.Value.State}");
                    Console.WriteLine($"Zip             ::{item.Value.Zip}");
                }
                Console.WriteLine($"\nTotal {count} persons in {city} region");
            }
            if (input == 2)
            {
                Console.WriteLine("\nEnter State: ");
                string state = Console.ReadLine();
                var objDuplicateCheck = contactDetails.Where(x => x.Value.State.Equals(state));
                Console.WriteLine($"\nFound Contacts ====> ");
                foreach (var item in objDuplicateCheck)
                {
                    count++;
                    Console.WriteLine($"\nUnique Name     ::{item.Value.UniqueName}");
                    Console.WriteLine($"First Name      ::{item.Value.FirstName}");
                    Console.WriteLine($"Last Name       ::{item.Value.LastName}");
                    Console.WriteLine($"Mobile Number   ::{item.Value.MobileNumber}");
                    Console.WriteLine($"EMail           ::{item.Value.EMail}");
                    Console.WriteLine($"Address         ::{item.Value.Address}");
                    Console.WriteLine($"City            ::{item.Value.City}");
                    Console.WriteLine($"State           ::{item.Value.State}");
                    Console.WriteLine($"Zip             ::{item.Value.Zip}");
                }
                Console.WriteLine($"\nTotal {count} persons in {state} region");
            }
        }

        public void DisplayContact()
        {
            foreach (var item in contactDetails)
            {
                Console.WriteLine("\n**********|| Address Book ||**********");
                Console.WriteLine($"\nUnique Name     ::{item.Value.UniqueName}");
                Console.WriteLine($"First Name      ::{item.Value.FirstName}");
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
