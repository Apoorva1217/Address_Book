using System;
using System.Collections.Generic;
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
        /// Assign person equals null. 
        /// </summary>
        private Personal_Details person = null;

        /// <summary>
        /// Add method.
        /// </summary>
        public void Add()
        {
            
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            if (!Regex.Match(firstName, "^[A-Z][a-z]{2,}$").Success)
            Console.WriteLine("First letter should be capital \n");

            ///No Duplicate Entries are Allowed!
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("You entered the Duplicate Name...");
                    return;
                }
            }
            
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            if (!Regex.Match(lastName, "^[A-Z][a-z]{2,}$").Success)
                Console.WriteLine("First letter should be capital \n");

            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code:");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

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
        /// Edit method.
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
                                int zipCode =Convert.ToInt32(Console.ReadLine());
                                person.ZipCode = zipCode;
                                break;

                            case 5:
                                Console.WriteLine("Enter new Phone Number:");
                                long phoneNumber =Convert.ToInt64(Console.ReadLine());
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
        /// Delete method.
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
        /// Search name by City or State
        /// </summary>
        public void Search()
        {
            Console.WriteLine("Enter your choice for searching: ");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your First Name:");
                    String NameToSearchInCity = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].FirstName.Equals(NameToSearchInCity))
                            Console.WriteLine(list[i].City);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your First Name:");
                    String nameToSearchInState = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].FirstName.Equals(nameToSearchInState))
                            Console.WriteLine(list[i].State);
                    }
                    break;
            }
        }

        /// <summary>
        /// View person by City or State
        /// </summary>
        public void View()
        {
            Console.WriteLine("Enter your choice for viewing:");
            Console.WriteLine("1. City 2. State");
            String choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your city");
                    String city = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].City.Equals(city))
                            Console.WriteLine(list[i]);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your state");
                    String state = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].State.Equals(state))
                            Console.WriteLine(list[i]);
                    }
                    break;
            }
        }
    }
}