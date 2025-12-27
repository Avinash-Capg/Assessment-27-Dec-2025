using System;

namespace MediSureClinic
{
    public class PatientKaBill
    {
        public string billId { get; set; }
        public string patientNaam { get; set; }
        public bool insuranceHai { get; set; }

        public decimal consultFee { get; set; }
        public decimal labCharge { get; set; }
        public decimal medicineCharge { get; set; }

        public decimal grossAmount { get; set; }
        public decimal discountAmount { get; set; }
        public decimal finalPayable { get; set; }
    }
}