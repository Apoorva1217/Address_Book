using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Address_Book
{
    public class Add_Details : Details
    {
        /// <summary>
        /// Created a list.
        /// </summary>
        private readonly List<Personal_Details> list = new List<Personal_Details>();

        /// <summary>
        /// Created a Dictionary.
        /// </summary>
        Dictionary<string, Add_Details> dictionary = new Dictionary<string, Add_Details>();

        /// <summary>
        /// Assign person equals null. 
        /// </summary>
        private Personal_Details person = null;

        /// <summary>
        /// Ability to create Multiple Address Books
        /// </summary>
        public void CreateMultipleAddressBook()
        {
            while (true)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Exit");

                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Enter the Name of Address Book");
                        string name = Console.ReadLine();
                        if (dictionary.ContainsKey(name))
                        {
                            Console.WriteLine("Already exists...");
                        }
                        else
                        {
                            Add_Details addressBook = new Add_Details();
                            dictionary.Add(name, addressBook);
                            Console.WriteLine("Address Book is Created...");
                            addressBook.Menu();
                        }
                        break;
                    case 2:
                        return;
                }
            }
        }

        /// <summary>
        /// Address Book Menu
        /// </summary>
        public void Menu()
        {
            Details details = new Add_Details();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("\n---Welcome to Address Book Program!---\n");
                Console.WriteLine("*Enter Your Choice*");
                Console.WriteLine("1.Add Details");
                Console.WriteLine("2.Display Details");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Details");

                string choice = Console.ReadLine();
                int ch = Convert.ToInt32(choice);

                switch (ch)
                {
                    case 1:
                        details.Add();
                        break;
                    case 2:
                        details.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name:");
                        string name = Console.ReadLine();
                        details.Edit(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name:");
                        string nameForDeletion = Console.ReadLine();
                        details.Delete(nameForDeletion);
                        break;
                }
            }
        }

        /// <summary>
        /// Ability to Add new Contact in Address Book
        /// </summary>
        public void Add()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            if (!Regex.Match(firstName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("First letter should be capital and minimum 3 characters are required\n");

            ///Ability to ensure there is no Duplicate Entry of the same Person
            foreach (Personal_Details personal_Details in list.FindAll(e => e.FirstName == firstName))
            {
                Console.WriteLine("You entered Duplicate Name...");
                return;
            }

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("First letter should be capital\n");

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();
            if (!Regex.Match(zipCode, "^[1-9]{3}[0-9]{3}$").Success)
                Console.WriteLine("Zip Code contains 6 digits\n");

            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();
            if (!Regex.Match(phoneNumber, "^[0-9]{10}").Success)
                Console.WriteLine("Invalid Phone Number\n");

            ///Duplicate Entries like Phone Number are not Allowed.
            foreach (Personal_Details personal_Details in list.FindAll(e => e.PhoneNumber == phoneNumber))
            {
                Console.WriteLine("You entered Duplicate Phone Number...");
                return;
            }

            Console.WriteLine("Enter EmailID");
            string emailID = Console.ReadLine();
            if (!Regex.Match(emailID, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+[.]+([a-zA-Z]{2,4})+[.]*([a-zA-Z]{2})*$").Success)
                Console.WriteLine("Invalid Email ID \n");

            Console.WriteLine("Your details are Added Successfully...");

            this.person = new Personal_Details(firstName, lastName, address, city, state, zipCode, phoneNumber, emailID);
            this.list.Add(this.person);
        }

        /// <summary>
        /// Display method.
        /// </summary>
        public void Display()
        {
            foreach (Personal_Details entry in this.list)
            {
                Console.WriteLine(entry);
            }
        }

        /// <summary>
        /// Ability to Edit existing contact using Person's first name
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Edit(string firstName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
                    {
                        Personal_Details person = this.list[i];
                        Console.WriteLine(person);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.Zip Code 5.Phone Number 6.Email ID 7.Exit");
                        string choice = Console.ReadLine();
                        int ch = Convert.ToInt32(choice);
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("Enter new Address:");
                                string address = Console.ReadLine();
                                person.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("Enter new City:");
                                string city = Console.ReadLine();
                                person.City = city;
                                break;
                            case 3:
                                Console.WriteLine("Enter new State:");
                                string state = Console.ReadLine();
                                person.State = state;
                                break;
                            case 4:
                                Console.WriteLine("Enter new ZipCode:");
                                string zipCode = Console.ReadLine();
                                person.ZipCode = zipCode;
                                break;
                            case 5:
                                Console.WriteLine("Enter new Phone Number:");
                                string phoneNumber = Console.ReadLine();
                                person.PhoneNumber = phoneNumber;
                                break;
                            case 6:
                                Console.WriteLine("Enter new Email ID:");
                                string emailID = Console.ReadLine();
                                person.EmailID = emailID;
                                break;
                            case 7:
                                check = 1;
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Ability to Delete contact using Person's first name
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Delete(string firstName)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    this.list[i] = null;
                }
            }
            Console.WriteLine("Your expected entry is deleted from records!");
        }

        /// <summary>
        /// Ability to Search person in City or State
        /// </summary>
        public void Search()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your First Name:");
                    String NameToSearchInCity = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(e => e.FirstName == NameToSearchInCity))
                    {
                        Console.WriteLine("City of " + NameToSearchInCity + " is : " + personal_Details.City);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your First Name:");
                    String nameToSearchInState = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(e => e.FirstName == nameToSearchInState))
                    {
                        Console.WriteLine("City of " + nameToSearchInState + " is : " + personal_Details.State);
                    }
                    break;
            }
        }

        /// <summary>
        /// Ability to View person by City or State
        /// </summary>
        public void View()
        {
            Console.WriteLine("Enter your Choice for Viewing a Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(e => e.City == city))
                    {
                        Console.WriteLine(personal_Details);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(e => e.State == state))
                    {
                        Console.WriteLine(personal_Details);
                    }
                    break;
            }
        }

        /// <summary>
        /// Ability to Count person in a City or State
        /// </summary>
        public void Count()
        {
            int count = 0;
            Console.WriteLine("Enter your Choice for Count Person by:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your City");
                    String city = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(c => c.City == city))
                    {
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
                case 2:
                    Console.WriteLine("Enter your State");
                    String state = Console.ReadLine();
                    foreach (Personal_Details personal_Details in list.FindAll(c => c.State == state))
                    {
                        count = list.Count();
                    }
                    Console.WriteLine(count);
                    break;
            }
        }
    }
}