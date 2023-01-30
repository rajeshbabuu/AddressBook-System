using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            Console.WriteLine("\nEnter X to Add Contact Details.");
            string? input = Console.ReadLine();

            ContactDetails contactDetail = null;

            while (input == "X")
            {
                Console.WriteLine("\nEnter First Name: ");
                string? firstName = Console.ReadLine();

                Console.WriteLine("\nEnter Last Name: ");
                string? lastName = Console.ReadLine();

                Console.WriteLine("\nEnter Mobile Number: ");
                long mobileNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("\nEnter EMail: ");
                string? eMail = Console.ReadLine();

                Console.WriteLine("\nEnter Address: ");
                string? address = Console.ReadLine();

                Console.WriteLine("\nEnter City: ");
                string? city = Console.ReadLine();

                Console.WriteLine("\nEnter State: ");
                string? state = Console.ReadLine();

                Console.WriteLine("\nEnter Zip: ");
                int zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter X to Add Contact Details or enter E to exit.");
                input = Console.ReadLine();

                contactDetail = new ContactDetails()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MobileNumber = mobileNumber,
                    EMail = eMail,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip
                };
                contactDetails.AddContactDetails(contactDetail);
                contactDetails.DisplayContact();
            }

            Console.WriteLine("\nEnter Y to edit Contact Details");
            string? input2 = Console.ReadLine();

            while (input2 == "Y")
            {
                Console.WriteLine("\nEnter Mobile Number");
                contactDetails.EditContactDetails(Convert.ToInt64(Console.ReadLine()));
                contactDetails.DisplayContact();

                Console.WriteLine("\nEnter Y to edit Contact Details or enter E to exit");
                input2 = Console.ReadLine();

            }

            contactDetails.DisplayContact();
            Console.ReadLine();
        }
    }
}