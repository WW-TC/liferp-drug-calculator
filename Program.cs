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
            Console.Title = "Life RP Drug Calculator";

            Console.WriteLine("============================== LIFE RP Drug Calculator ==============================" + "\n" + "(c) WWTC - v1.3" + "\n");
            Console.Write("What type of drugs are you making (Weed, Crystal or Snow) : ");
            string DrugType = Console.ReadLine();

            if (DrugType.ToUpper() == "WEED")
            {
                Weed();
            }

            if (DrugType.ToUpper() == "CRYSTAL")
            {
                Crystal();
            }

            if (DrugType.ToUpper() == "SNOW")
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
            Console.Write("\n" + "How many joints do you want to make : ");
            string JointsS = Console.ReadLine();
            int JointsN = Convert.ToInt32(JointsS);

            int Cloth = JointsN * 8;
            Console.WriteLine("\n" + "To make " + JointsN + " joints, you will need " + Cloth + " cloth (" + Cloth * 5.5f + "$)");
            float Profits = JointsN * 125 - (Cloth * 5.5f);

            float WallLocker = 198f;
            float WallLockerAmount = JointsN / WallLocker;
            Console.WriteLine("\n" + "You will make " + Profits + "$, you will need " + WallLockerAmount.ToString("0.00") + " wall lockers for transportation");

            //End
            Console.ReadKey();
            Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
            string MenuChoice = Console.ReadLine();

            if (MenuChoice == "Back")
            {
                Main();
            }
            else
            {
                Weed();
            }
        }

        static void Crystal()
        {
            Console.Write("\n" + "What mode do you want to use (Budget, Trays or Profits) : ");
            string modeCrystal = Console.ReadLine();

            if (modeCrystal.ToUpper() == "TRAYS")
            {
                Console.Write("\n" + "How many tray(s) of Crystal do you want to produce : ");
                string TrayAmountS = Console.ReadLine();
                int TrayAmountN = Convert.ToInt32(TrayAmountS);

                Console.WriteLine("\n" + "To produce " + TrayAmountN + " crystal trays you will need :");

                int Chemicals = TrayAmountN * 3;
                Console.WriteLine("- Chemicals : " + Chemicals + " (" + Chemicals * 127 + "$)");

                int Cloth = TrayAmountN * 3;
                Console.WriteLine("- Fertilizers : " + Cloth + " (" + Cloth * 30f + "$)");

                float TotalExpenses = Chemicals * 127 + Cloth * 30f;
                Console.WriteLine("- USD : " + TotalExpenses + "$");

                int TotalGains = (TrayAmountN * 5) * 280;
                float Profits = TotalGains - TotalExpenses;
                Console.WriteLine("\n" + "Total Profits : " + Profits + "$");

                float WallLocker = 198f;
                int BagAmount = TrayAmountN * 5;
                float WallLockerAmount = BagAmount / WallLocker;
                Console.WriteLine("\n" + "This will produce " + BagAmount + " crystal bags, you will need " + WallLockerAmount.ToString("0.00") + " wall lockers for transportation");

                //End
                Console.ReadKey();
                Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
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

            if (modeCrystal.ToUpper() == "BUDGET")
            {
                Console.Write("\n" + "What is your budget : ");
                string BudgetS = Console.ReadLine();
                int BudgetN = Convert.ToInt32(BudgetS);

                float TraysF = BudgetN / (381f + 90f);
                int TraysI = ((int)TraysF);

                if (TraysI <= 0)
                {
                    Console.WriteLine("\n" + "Your budget is too low to produce any meth");
                    Crystal();
                }
                else
                {
                    Console.WriteLine("\n" + "With a budget of " + BudgetN + "$, you can produce " + TraysI + " tray(s)");
                    Console.WriteLine("\n" + "You will need the following materials : ");

                    int Chemicals = TraysI * 3;
                    int Cloth = TraysI * 3;

                    Console.WriteLine("- Chemicals : " + Chemicals + " (" + Chemicals * 127 + "$)");
                    Console.WriteLine("- Cloth (Fertilizer) : " + Cloth + " (" + Cloth * 30f + "$)");

                    int TotalExpenses = Chemicals * 127 + Cloth * 30;
                    int TotalGains = (TraysI * 5) * 280;
                    int Profits = TotalGains - TotalExpenses;

                    Console.WriteLine("- USD : " + TotalExpenses + "$");

                    float WallLocker = 198f;
                    int Bags = TraysI * 5;
                    float WallLockerAmount = Bags / WallLocker;
                    Console.WriteLine("\n" + "You will make a total of " + Profits + " $, and need " + WallLockerAmount.ToString("0.00") + " wall lockers to carry all " + Bags + " crystal bags");

                    //End
                    Console.ReadKey();
                    Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
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

            }

            if (modeCrystal.ToUpper() == "PROFITS")
            {
                Console.Write("\n" + "How much do you want to make (minimum : 929$) : ");
                string ProfitsS = Console.ReadLine();
                int ProfitsN = Convert.ToInt32(ProfitsS);

                if (ProfitsN < 929)
                {
                    Console.WriteLine("\n" + "Profits aren't high enough to make at least 1 tray");
                    Crystal();
                }
                else
                {
                    float TraysF = ProfitsN / 929f;
                    int TraysI = ((int)TraysF);

                    int Chemicals = TraysI * 3;
                    int Cloth = TraysI * 3;
                    float TotalExpenses = Chemicals * 127 + Cloth * 30f;
                    Console.WriteLine("\n" + "To make " + ProfitsN + "$, you will need to make " + TraysI + " tray(s) costing you " + TotalExpenses + "$");

                    Console.WriteLine("\n" + "You will need the following materials :" + "\n" + "- Chemicals : " + Chemicals + " (" + Chemicals * 127 + "$)" + "\n" + "- Fertilizers : " + Cloth + " (" + Cloth * 30f + "$)");

                    float EProfits = ((TraysI * 5) * 280) - TotalExpenses;

                    float WallLocker = 198f;
                    int Bags = TraysI * 5;
                    float WallLockerAmount = Bags / WallLocker;
                    Console.WriteLine("\n" + "This will make you exactly " + EProfits + "$ and will need " + WallLockerAmount.ToString("0.00") + " wall lockers to carry all " + Bags + " crystal bags");

                    //End
                    Console.ReadKey();
                    Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
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
            }

            else
            {
                Console.WriteLine("Invalid Mode");
                Crystal();
            }
        }

        static void Snow()
        {
            Console.WriteLine("\n" + "What mode do you want to use (Budget, Batches or Profits) : ");
            string modeSnow = Console.ReadLine();

            //Snow Budget
            if (modeSnow.ToUpper() == "BUDGET")
            {
                Console.WriteLine("\n" + "Enter your budget : ");
                string BudgetS = Console.ReadLine();
                int BudgetN = Convert.ToInt32(BudgetS);

                float BagsF = BudgetN / 88f;
                int BagsI = ((int)BagsF);

                if (BagsI <= 3)
                {
                    Console.WriteLine("\n" + "Your budget is too low to produce any snow");
                    Snow();
                }
                else
                {
                    Console.WriteLine("\n" + "With a budget of " + BudgetN + "$, you can produce " + BagsI + " bags(s)");
                    Console.WriteLine("\n" + "You will need the following materials : ");

                    int Cloth = BagsI * 4;

                    Console.WriteLine("- Cloth (Fertilizer) : " + Cloth + " (" + Cloth * 22 + "$)");

                    int TotalExpenses = Cloth * 22;
                    int TotalGains = (BagsI) * 205;
                    int Profits = TotalGains - TotalExpenses;

                    float WallLocker = 198f;
                    float WallLockerAmount = BagsI / WallLocker;
                    Console.WriteLine("\n" + "You will make a total of " + Profits + " $, and need " + WallLockerAmount.ToString("0.00") + " wall lockers to carry all " + BagsI + " snow bags");

                    //End
                    Console.ReadKey();
                    Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
                    string MenuChoice = Console.ReadLine();

                    if (MenuChoice == "Back")
                    {
                        Main();
                    }
                    else
                    {
                        Snow();
                    }
                }

            }

            //Snow Profits
            if (modeSnow.ToUpper() == "PROFITS")
            {
                Console.Write("\n" + "How much do you want to make (minimum : 820$) : ");
                string ProfitsS = Console.ReadLine();
                int ProfitsN = Convert.ToInt32(ProfitsS);

                if (ProfitsN < 820)
                {
                    Console.WriteLine("\n" + "Profits aren't high enough to make at least 1 tray");
                    Snow();
                }
                else
                {
                    float batchF = ProfitsN / 820f;
                    int batchI = ((int)batchF);

                    int bagsI = batchI * 4;
                    int Cloth = bagsI * 4;
                    float TotalExpenses = Cloth * 22f;

                    Console.WriteLine("\n" + "You will need the following materials :" + "\n" + "- Cloth (Fertilizer) : " + Cloth + " (" + Cloth * 22 + "$)");

                    float Profits = (bagsI * 205) - TotalExpenses;

                    float WallLocker = 198f;
                    float WallLockerAmount = bagsI / WallLocker;
                    Console.WriteLine("\n" + "This will make you exactly " + Profits + "$ and will need " + WallLockerAmount.ToString("0.00") + " wall lockers to carry all " + bagsI + " snow bags");

                    //End
                    Console.ReadKey();
                    Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
                    string MenuChoice = Console.ReadLine();

                    if (MenuChoice == "Back")
                    {
                        Main();
                    }
                    else
                    {
                        Snow();
                    }
                }
            }

            //Snow Batches
            if (modeSnow.ToUpper() == "BATCHES")
            {
                Console.Write("\n" + "How many batches do you want to make (1 Batch = 4 Bags) : ");
                string batchS = Console.ReadLine();
                int batchI = Convert.ToInt32(batchS);

                int bagsI = batchI * 4;
                int cloth = bagsI * 4;

                float cost = cloth * 22f;

                Console.WriteLine("\n" + "You will need the following materials :" + "\n" + "- Cloth (Fertilizer) : " + cloth + " (" + cost + "$)");

                float Profits = (bagsI * 205) - cost;

                float WallLocker = 198f;
                float WallLockerAmount = bagsI / WallLocker;
                Console.WriteLine("\n" + "This will make you exactly " + Profits + "$ and will need " + WallLockerAmount.ToString("0.00") + " wall lockers to carry all " + bagsI + " snow bags");

                //End
                Console.ReadKey();
                Console.Write("\n" + "Do you want to restart or go back to main menu (Back or *type anything*) : ");
                string MenuChoice = Console.ReadLine();

                if (MenuChoice == "Back")
                {
                    Main();
                }
                else
                {
                    Snow();
                }
            }

            else
            {
                    Console.WriteLine("Invalid Mode");
                    Snow();
            }
        }
    }
}
