using System;

namespace MediSureClinic
{
    class Program
    {
        static void Main()
        {
            BillKiEntry entry = new BillKiEntry();
            BillKoDekhna view = new BillKoDekhna();

            bool bandKarniHai = false;

            while (!bandKarniHai)
            {
                Console.WriteLine("================== MediSure Clinic Billing ==================");

                Console.WriteLine("1. Create New Bill (Enter Patient Details)");

                Console.WriteLine("2. View Last Bill");

                Console.WriteLine("3. Clear Last Bill");

                Console.WriteLine("4. Exit");

                
                Console.Write("Enter your option: ");

                int ch;
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Please enter a valid menu number.");
                    continue;
                }

                switch (ch)
                {
                    case 1:
                        entry.nayaBillBanao();
                        break;

                    case 2:
                        view.pichhlaBillDikhao();
                        break;

                    case 3:
                        entry.billHatao();
                        break;

                    case 4:
                        Console.WriteLine("Thank you. Application closed normally.");
                        bandKarniHai = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}