using System;

namespace MediSureClinicBilling
{
    class Program
    {
        static void Main()
        {
            BillingService service = new BillingService();
            bool exitRequested = false;

            while (!exitRequested)
            {
                Console.WriteLine("\n================== MediSure Clinic Billing ==================");
                Console.WriteLine("1. Create New Bill (Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        service.CreateNewBill();
                        break;

                    case "2":
                        service.ViewLastBill();
                        break;

                    case "3":
                        service.ClearLastBill();
                        break;

                    case "4":
                        exitRequested = true;
                        Console.WriteLine("Thank you. Application closed normally.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu choice.");
                        break;
                }
            }
        }
    }
}