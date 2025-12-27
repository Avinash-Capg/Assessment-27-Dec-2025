using System;

namespace MediSureClinic
{
    public class BillKiEntry
    {
        public static PatientKaBill lastBill;
        public static bool billMojoodHai = false;

        public void nayaBillBanao()
        {
            PatientKaBill b = new PatientKaBill();

            Console.Write("Enter Bill Id: ");
            b.billId = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(b.billId))
            {
                Console.WriteLine("Bill Id cannot be empty.");
                return;
            }

            Console.Write("Enter Patient Name: ");
            b.patientNaam = Console.ReadLine();

            Console.Write("Is the patient insured? (Y/N): ");
            string ins = Console.ReadLine();
            b.insuranceHai = (ins == "Y" || ins == "y");

            Console.Write("Enter Consultation Fee: ");
            decimal cFee;
            if (!decimal.TryParse(Console.ReadLine(), out cFee) || cFee <= 0)
            {
                Console.WriteLine("Consultation fee must be greater than zero.");
                return;
            }
            b.consultFee = cFee;

            Console.Write("Enter Lab Charges: ");
            decimal lab;
            if (!decimal.TryParse(Console.ReadLine(), out lab) || lab < 0)
            {
                Console.WriteLine("Lab charges cannot be negative.");
                return;
            }
            b.labCharge = lab;

            Console.Write("Enter Medicine Charges: ");
            decimal med;
            if (!decimal.TryParse(Console.ReadLine(), out med) || med < 0)
            {
                Console.WriteLine("Medicine charges cannot be negative.");
                return;
            }
            b.medicineCharge = med;

            BillCalculateKrna.billKaHisab(b);

            lastBill = b;
            billMojoodHai = true;

            Console.WriteLine("\nBill created successfully.");
            BillCalculateKrna.shortBillDikhao(b);
            Console.WriteLine("------------------------------------------------------------");
        }

        public void billHatao()
        {
            lastBill = null;
            billMojoodHai = false;

            Console.WriteLine("Last bill cleared.");
        }
    }
}