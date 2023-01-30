using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            while (true)
            {
                ContactDetailsRepository contactDetailsRepository = new ContactDetailsRepository();
                Console.WriteLine("\nWelcome to Address Book");

                Console.WriteLine("\nEnter 1 to Add Contact Details. \nEnter 2 to Edit Contact Details. \nEnter 3 to Delete Contact Details. \nEnter 4 to Search Contact. \nEnter 5 to Display all contacts");
                int choice = Convert.ToInt32(Console.ReadLine());

                ContactDetails contactDetail = null;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter X to Add Details");
                        string input = Console.ReadLine();
                        while (input == "X")
                        {
                            Console.WriteLine("\nEnter a Unique Name for Address Book");
                            string? uniqueName = Console.ReadLine();

                            Console.WriteLine("\nEnter First Name: ");
                            string? firstName = Console.ReadLine();

                            Console.WriteLine("\nEnter Last Name: ");
                            string? lastName = Console.ReadLine();

                            Console.WriteLine("\nEnter 10 Digit Mobile Number: ");
                            long mobileNumber = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("\nEnter EMail: ");
                            string? eMail = Console.ReadLine();

                            Console.WriteLine("\nEnter Address: ");
                            string? address = Console.ReadLine();

                            Console.WriteLine("\nEnter City: ");
                            string? city = Console.ReadLine();

                            Console.WriteLine("\nEnter State: ");
                            string? state = Console.ReadLine();

                            Console.WriteLine("\nEnter 6 Digit Zip: ");
                            int zip = Convert.ToInt32(Console.ReadLine());

                            contactDetail = new ContactDetails()
                            {
                                UniqueName = uniqueName,
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

                            Console.WriteLine("\nEnter X to Add Contact Details or enter E to exit.");
                            input = Console.ReadLine();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("\nEnter Y to edit Contact Details");
                            string? input2 = Console.ReadLine();

                            while (input2 == "Y")
                            {
                                Console.WriteLine("\nEnter Unique Address Book Name");
                                contactDetails.EditContactDetails(Console.ReadLine());

                                contactDetails.DisplayContact();
                                Console.WriteLine("\nEnter Y to edit Contact Details or enter E to exit");
                                input2 = Console.ReadLine();
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("\nEnter Z to Delete a Contact");
                            string? input3 = Console.ReadLine();

                            while (input3 == "Z")
                            {
                                Console.WriteLine("\nEnter Unique Addess Book Name");
                                contactDetails.DeleteContact(Console.ReadLine());
                                Console.WriteLine("Contact Deleted");

                                contactDetails.DisplayContact();
                                Console.WriteLine("\nEnter Z to Delete a Contact or enter E to exit");
                                input3 = Console.ReadLine();
                            }
                            break;
                        }

                    case 4:
                        {
                            contactDetails.SearchContact();
                            break;
                        }
                    case 5:
                        {
                            contactDetails.DisplayContact();
                            break;
                        }
                }
            }
        }
    }
}