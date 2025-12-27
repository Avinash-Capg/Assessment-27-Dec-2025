using System;

namespace QuickMartTraders
{
    class Program
    {
        static void Main()
        {
            SaleEntryPoint creator = new SaleEntryPoint();

            
            InvoicePrinting viewer = new InvoicePrinting();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("_____________QuickMart Traders __________________");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                int optionToChoose;
                bool isValid = int.TryParse(Console.ReadLine(), out optionToChoose);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (optionToChoose)
                {
                    case 1:
                        creator.StartSale();
                        break;

                    case 2:
                        viewer.PreviousTranx();
                        break;

                    case 3:
                        if (!SaleEntryPoint.HasLastTransaction)
                        {
                            Console.WriteLine("No transaction available. Please create a new transaction first.");
                        }
                        else
                        {
                            ProfitLossCalc.Calculate(SaleEntryPoint.LastTransaction);
                            ProfitLossCalc.PrintCalculation(SaleEntryPoint.LastTransaction);
                            Console.WriteLine("------------------------------------------------------");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you. Application closed normally.");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid menu option. Please try again.");
                        break;
                }
            }
        }
    }
}