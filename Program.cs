using System;

namespace Address_Book
{
    public class Program
    {
        /// <summary>
        /// Address Book
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            Add_Details add_Details = new Add_Details();
            add_Details.CreateMultipleAddressBook();
        }
    }
}