using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Address_Book
{
    public class Personal_Details
    {
        /// <summary>
        /// Ability to Create Contacts in Address Book
        /// </summary>
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNumber;
        private string emailID;

        public Personal_Details(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string emailID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.emailID = emailID;
        }

        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string Address { get => this.address; set => this.address = value; }
        public string City { get => this.city; set => this.city = value; }
        public string State { get => this.state; set => this.state = value; }
        public string ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public string PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
        public string EmailID { get => this.emailID; set => this.emailID = value; }
        public int Count { get; internal set; }

        public override string ToString()
        {
            return "\n  FirstName    : " + this.firstName
                 + "\n  LastName     : " + this.lastName
                 + "\n  Address      : " + this.address
                 + "\n  City         : " + this.city
                 + "\n  State        : " + this.state
                 + "\n  ZipCode      : " + this.zipCode
                 + "\n  PhoneNumber  : " + this.phoneNumber
                 + "\n  EmailID      : " + this.emailID + "\n" +
                   "/*************************/";
        }
    }
}