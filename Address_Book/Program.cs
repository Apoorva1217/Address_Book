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
            Details details = new Add_Details();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("---Welcome to Address Book Program!---");
                Console.WriteLine("***Enter Your Choice***");
                Console.WriteLine("1.Add Details");
                Console.WriteLine("2.Display Details");
                Console.WriteLine("3.Edit Details");
                Console.WriteLine("4.Delete Details");
                Console.WriteLine("5.Search Details using City or State");
                Console.WriteLine("6.Exit");

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
                    case 5:
                        details.Search();
                        break;
                    case 6:
                        return;
                }
            }
        }
    }
}