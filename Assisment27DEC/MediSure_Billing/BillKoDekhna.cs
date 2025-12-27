using System;

namespace MediSureClinic
{
    public class BillKoDekhna
    {
        public void pichhlaBillDikhao()
        {
            if (!BillKiEntry.billMojoodHai)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            PatientKaBill b = BillKiEntry.lastBill;

            Console.WriteLine("-------- Last Bill ---------");


            Console.WriteLine("BillId: " + b.billId);
            
            Console.WriteLine("Patient: " + b.patientNaam);
            
            Console.WriteLine("Insured: " + (b.insuranceHai ? "Yes" : "No"));
            
            Console.WriteLine("Consultation Fee: " + b.consultFee.ToString("0.00"));
            
            Console.WriteLine("Lab Charges: " + b.labCharge.ToString("0.00"));
            
            Console.WriteLine("Medicine Charges: " + b.medicineCharge.ToString("0.00"));
            
            Console.WriteLine("Gross Amount: " + b.grossAmount.ToString("0.00"));
            
            Console.WriteLine("Discount Amount: " + b.discountAmount.ToString("0.00"));
            
            Console.WriteLine("Final Payable: " + b.finalPayable.ToString("0.00"));
            
         
            Console.WriteLine("----------------------------------------------------");
        }
    }
}