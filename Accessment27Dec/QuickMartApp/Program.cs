using System;
using QuickMartApp;

class Program
{
    static void Main()
    {
        TransactionManager manager = new TransactionManager();
        bool exitApp = false;

        while (!exitApp)
        {
            Console.WriteLine("\n================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.CreateTransaction();
                    break;

                case "2":
                    manager.ViewTransaction();
                    break;

                case "3":
                    manager.Recalculate();
                    break;

                case "4":
                    Console.WriteLine("Thank you. Application closed normally.");
                    exitApp = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                    break;
            }
        }
    }
}