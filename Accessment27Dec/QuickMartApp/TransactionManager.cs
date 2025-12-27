using System;

namespace QuickMartApp
{
    public class TransactionManager
    {
        public static SaleTransaction LastTransaction;
        public static bool HasLastTransaction = false;

        public void CreateTransaction()
        {
            SaleTransaction transaction = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            transaction.InvoiceNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(transaction.InvoiceNo))
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return;
            }

            Console.Write("Enter Customer Name: ");
            transaction.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            transaction.ItemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out int qty) || qty <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero.");
                return;
            }
            transaction.Quantity = qty;

            Console.Write("Enter Purchase Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal purchaseAmt) || purchaseAmt <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than zero.");
                return;
            }
            transaction.PurchaseAmount = purchaseAmt;

            Console.Write("Enter Selling Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal sellingAmt) || sellingAmt < 0)
            {
                Console.WriteLine("Selling Amount cannot be negative.");
                return;
            }
            transaction.SellingAmount = sellingAmt;

            Calculate(transaction);

            LastTransaction = transaction;
            HasLastTransaction = true;

            Console.WriteLine("\nTransaction saved successfully.");
            PrintCalculation(transaction);
        }

        public void ViewTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("\n-------------- Last Transaction --------------");
            Console.WriteLine("InvoiceNo: " + LastTransaction.InvoiceNo);
            Console.WriteLine("Customer: " + LastTransaction.CustomerName);
            Console.WriteLine("Item: " + LastTransaction.ItemName);
            Console.WriteLine("Quantity: " + LastTransaction.Quantity);
            Console.WriteLine("Purchase Amount: " + LastTransaction.PurchaseAmount.ToString("F2"));
            Console.WriteLine("Selling Amount: " + LastTransaction.SellingAmount.ToString("F2"));
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent.ToString("F2"));
            Console.WriteLine("--------------------------------------------");
        }

        public void Recalculate()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Calculate(LastTransaction);
            PrintCalculation(LastTransaction);
        }

        private void Calculate(SaleTransaction transaction)
        {
            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "PROFIT";
                transaction.ProfitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "LOSS";
                transaction.ProfitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                transaction.ProfitOrLossStatus = "BREAK-EVEN";
                transaction.ProfitOrLossAmount = 0;
            }

            transaction.ProfitMarginPercent =
                (transaction.ProfitOrLossAmount / transaction.PurchaseAmount) * 100;
        }

        private void PrintCalculation(SaleTransaction transaction)
        {
            Console.WriteLine("Status: " + transaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + transaction.ProfitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + transaction.ProfitMarginPercent.ToString("F2"));
            Console.WriteLine("------------------------------------------------------");
        }
    }
}