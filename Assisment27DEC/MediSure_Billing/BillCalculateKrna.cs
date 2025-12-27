using System;

namespace MediSureClinic
{
    public class BillCalculateKrna
    {
        public static void billKaHisab(PatientKaBill b)
        {
            b.grossAmount =
                b.consultFee +
                b.labCharge +
                b.medicineCharge;

            if (b.insuranceHai)
                b.discountAmount = b.grossAmount * 0.10m;
            else
                b.discountAmount = 0;

            b.finalPayable = b.grossAmount - b.discountAmount;
        }

        public static void shortBillDikhao(PatientKaBill b)
        {
            Console.WriteLine("Gross Amount: " + b.grossAmount.ToString("0.00"));
            Console.WriteLine("Discount Amount: " + b.discountAmount.ToString("0.00"));
            Console.WriteLine("Final Payable: " + b.finalPayable.ToString("0.00"));
        }
    }
}