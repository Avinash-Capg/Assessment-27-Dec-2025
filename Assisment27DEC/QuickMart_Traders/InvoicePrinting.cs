using System;

namespace QuickMartTraders
{
    public class InvoicePrinting
    {
        public void PreviousTranx()


        {
            if (!SaleEntryPoint.HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            SaleTransaction t = SaleEntryPoint.LastTransaction;

            Console.WriteLine("---------- Last Transaction -----------");


            Console.WriteLine("InvoiceNo: " + t.InvoiceNo);

            Console.WriteLine("Customer: " + t.CustomerName);

            Console.WriteLine("Item: " + t.ItemName);

            Console.WriteLine("Quantity: " + t.Quantity);
            Console.WriteLine("Purchase Amount: " + t.PurchaseAmount.ToString("0.00"));


            Console.WriteLine("Selling Amount: " + t.SellingAmount.ToString("0.00"));


            Console.WriteLine("Status: " + t.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + t.ProfitOrLossAmount.ToString("0.00"));





            Console.WriteLine("Profit Margin (%): " + t.ProfitMarginPercent.ToString("0.00"));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("------------------------------------------");
        }
    }
}