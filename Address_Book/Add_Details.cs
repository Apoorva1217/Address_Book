using System;
using System.Collections.Generic;
using System.Text;

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
        /// Ability to Add new Contact in Address Book
        /// </summary>
        public void Add()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
           
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();

            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter EmailID");
            string emailID = Console.ReadLine();

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

    }
}