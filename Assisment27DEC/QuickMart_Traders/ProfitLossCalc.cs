using System;

namespace QuickMartTraders
{
    public class ProfitLossCalc
    {
        public static void Calculate(SaleTransaction t)
        {





            if (t.SellingAmount > t.PurchaseAmount)
            {
                t.ProfitOrLossStatus = "PROFIT";
                t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount; 



            }




            else if (t.SellingAmount < t.PurchaseAmount)
            {
                t.ProfitOrLossStatus = "LOSS";
                t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
            } 





            else
            {
                t.ProfitOrLossStatus = "BREAK-EVEN";
                t.ProfitOrLossAmount = 0;
            }

            t.ProfitMarginPercent =
                (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
        }


       

        public static void PrintCalculation(SaleTransaction t)
        {
            Console.WriteLine("Status: " + t.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + t.ProfitOrLossAmount.ToString("0.00"));
            Console.WriteLine("Profit Margin (%): " + t.ProfitMarginPercent.ToString("0.00"));
        }
    }
}