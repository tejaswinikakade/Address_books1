using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address_Book_Day9
{
    class UC1_CreatContact_Program
    {
        public static List<Person> People = new List<Person>();

        static void Main(string[] args)
        {

            UC4_DeleteContact remove = new UC4_DeleteContact();
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Address Book 1");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Commands that can be used are: 'add', 'remove', 'edit'");
                Console.WriteLine("Please enter a command :");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        UC2_AddNewContact.AddPerson();
                        break;
                    case "remove":
                        UC4_DeleteContact.RemovePerson();
                        break;
                    case "edit":
                        UC3_EditContact.EditContact();
                        break;
                   
                }
            }
        }


        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book: \n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        public static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("---------------------------------------");

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }

}