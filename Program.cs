using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeRP_DrugCalc
{
    class Program
    {
        static void Main()
        {
            Console.Title= "Life RP Drug Calculator";

            Console.WriteLine("===== LIFE RP Drug Calculator =====" + "\n" + "(c) WWTC" + "\n");
            Console.Write("What type of drugs are you making (Weed, Crystal or Snow) : ");
            string DrugType = Console.ReadLine();

            if (DrugType == "Weed")
            {
                Weed();
            }

            if (DrugType == "Crystal")
            {
                Crystal();
            }

            if (DrugType == "Snow")
            {
                Snow();
            }

            else
            {
                Console.WriteLine("Invalid Option - Restarting Calculator");
                Main();
            }

        }

        static void Weed()
        {
            Console.WriteLine("Mode is currently un-supported" + "\n");
            Main();
        }

        static void Crystal()
        {
            Console.Write("\n" + "How many tray(s) of Crystal do you want to produce: ");
            string TrayAmountS = Console.ReadLine();
            int TrayAmountN = Convert.ToInt32(TrayAmountS);

            Console.WriteLine("\n" + "To produce " + TrayAmountN + " crystal trays you will need :");

            int Chemicals = TrayAmountN * 3;
            Console.WriteLine("- Chemicals : " + Chemicals + " (" + Chemicals * 127 + "$)");

            int Cloth = TrayAmountN * 12;
            Console.WriteLine("- Cloth : " + Cloth + " (" + Cloth * 5.5f + "$)");

            float TotalExpenses = Chemicals * 127 + Cloth * 5.5f;
            Console.WriteLine("- USD : " + TotalExpenses + "$");

            int TotalGains = (TrayAmountN * 5) * 280;
            float Profits = TotalGains - TotalExpenses;
            Console.WriteLine("\n" + "Total Profits : " + Profits + "$");

            float WallLocker = 198f;
            int BagAmount = TrayAmountN * 5;
            float WallLockerAmount = BagAmount / WallLocker;
            Console.WriteLine("\n" + "This will produce " + BagAmount + " crystal bags, you will need " + WallLockerAmount.ToString("0.00") + " wall lockers for transportation");

            Console.ReadKey();
            Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) :");
            string MenuChoice = Console.ReadLine();

            if (MenuChoice == "Back")
            {
                Main();
            }
            else
            {
                Crystal();
            }
        }

        static void Snow()
        {
            Console.WriteLine("Mode is currently un-supported" + "\n");
            Main();
        }
    }
}
