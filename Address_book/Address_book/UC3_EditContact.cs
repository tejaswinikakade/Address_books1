using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book_Day9
{
    class UC3_EditContact
    {
        public static void EditContact()
        {
            Console.WriteLine("Enter the first name of the contact you want to edit");
            string initial = Console.ReadLine();
            Person person = UC1_CreatContact_Program.People.FirstOrDefault(x => x.FirstName.ToLower() == initial.ToLower());

            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue. ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to edit this person from the address book? (Y/N)");
            UC1_CreatContact_Program.PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                UC1_CreatContact_Program.People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue");
                Console.ReadKey();
            }

            UC2_AddNewContact.AddPerson();

            Console.WriteLine("Your contact is edited succesfully");
        }
    }
}
