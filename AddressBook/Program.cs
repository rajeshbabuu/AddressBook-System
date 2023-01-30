using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            contactDetails.AddContactDetails("Rajesh", "Kumar", 9006549870, "rajesh@gmail.com", "AwasvikasColony", "Agra", "Uttarpradesh", 445068);
            contactDetails.DisplayContact();
            Console.ReadLine();
        }
    }
}