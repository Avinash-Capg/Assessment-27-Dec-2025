using System;

namespace QuickMartTraders
{
    public class SaleEntryPoint
    {



        public static SaleTransaction LastTransaction;




        public static bool HasLastTransaction = false;




        public void StartSale()
        {




            SaleTransaction t = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            t.InvoiceNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(t.InvoiceNo))
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return;
            }





            Console.Write("Enter Customer Name: ");
            t.CustomerName = Console.ReadLine();





            Console.Write("Enter Item Name: ");
            t.ItemName = Console.ReadLine();





            Console.Write("Enter Quantity: ");
            t.Quantity = Convert.ToInt32(Console.ReadLine());




            if (t.Quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero.");
                return;
            }





            Console.Write("Enter Purchase Amount (total): ");
            t.PurchaseAmount = Convert.ToDecimal(Console.ReadLine());

            if (t.PurchaseAmount <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than zero.");
                return;
            }




            

            Console.Write("Enter Selling Amount (total): ");
            t.SellingAmount = Convert.ToDecimal(Console.ReadLine());






            if (t.SellingAmount < 0)
            {
                Console.WriteLine("Selling Amount cannot be negative.");
                return;
            }

            ProfitLossCalc.Calculate(t);





            LastTransaction = t;
            HasLastTransaction = true;
            





            Console.WriteLine("\nTransaction saved successfully.");
            ProfitLossCalc.PrintCalculation(t);
            Console.WriteLine("------------------------------------------------------");
        }
    }
}