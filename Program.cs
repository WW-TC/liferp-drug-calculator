using System;

namespace LifeRP_DrugCalc
{
    class Program
    {

        static void Main()
        {
            Console.Title = "Life RP Drug Calculator - v2";
            Console.WriteLine($"============================== LIFE RP Drug Calculator ==============================");
            DrugMenu();
        }
        static void DrugMenu()
        {

            Console.Write($"\nWhat type of drugs are you making (Weed, Crystal or Snow) : ");
            string drugType = Console.ReadLine();

            switch (drugType.ToLower())
            {
                case "weed":
                    Weed_Selector();
                    break;
                case "crystal":
                    Crystal_Selector();
                    break;
                case "snow":
                    Snow_Selector();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Drug Type, try again." + "\n");
                    DrugMenu();
                    break;
            }

        }

        // Weed Selector
        static void Weed_Selector()
        {
            Console.Write("\n" + "Enter calculator type (Budget, Joint, Profit) : ");
            string weedType = Console.ReadLine();

            switch (weedType.ToLower())
            {
                case "budget":
                    Weed_Budget();
                    break;
                case "joint":
                    Weed_Joint();
                    break;
                case "profit":
                    Weed_Profit();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again");
                    Weed_Selector();
                    break;
            }
        }

        // Crystal Selector
        static void Crystal_Selector()
        {
            Console.Write("\n" + "Enter calculator type (Budget, Tray, Bag, Profit) : ");
            string crystalType = Console.ReadLine();

            switch (crystalType.ToLower())
            {
                case "budget":
                    Crystal_Budget();
                    break;
                case "tray":
                    Crystal_Tray();
                    break;
                case "profit":
                    Crystal_Profit();
                    break;
                case "bag":
                    Crystal_Bag();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again");
                    Crystal_Selector();
                    break;
            }
        }

        // Snow Selector
        static void Snow_Selector()
        {
            Console.Write("\n" + "Enter calculator type (Budget, Batch, Bag, Profit) : ");
            string weedType = Console.ReadLine();

            switch (weedType.ToLower())
            {
                case "budget":
                    Snow_Budget();
                    break;
                case "batch":
                    Snow_Batch();
                    break;
                case "profit":
                    Snow_Profit();
                    break;
                case "bag":
                    Snow_Bag();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again");
                    Snow_Selector();
                    break;
            }
        }

        //Weed Budget v2
        static void Weed_Budget()
        {
            Console.Write($"\nEnter your budget (minimum of 44$) : ");
            string budgetS = Console.ReadLine();

            bool success = int.TryParse(budgetS, out int budget);

            if (success && budget >= 44)
            {
                float jointsF = budget / 44f;
                int joints = (int)jointsF;

                //Material List
                int clothJoint = joints * 4;
                int clothFertilizer = joints * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n- Cloth (Joint) : {clothJoint} [{clothJoint * 5.5f}$]\n-Cloth (Fertilizers) : {clothFertilizer} ({clothFertilizer / 4}) [{clothFertilizer * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {joints * 125}$\n-Production Costs : {clothJoint * 2 * 5.5f}$\n=========================\n-Net Profits : {joints * 81}$");
                Console.WriteLine($"\n-Joints Produced : {joints}\n===========================================");

            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Weed_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Weed_Selector();
            }
        }

        //Weed Joint v2
        static void Weed_Joint()
        {
            Console.Write($"\nHow many joints do you want to make : ");
            string jointsS = Console.ReadLine();

            bool success = int.TryParse(jointsS, out int joints);

            if (success && joints >= 1)
            {
                //Material List
                int clothJoint = joints * 4;
                int clothFertilizer = joints * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n- Cloth (Joint) : {clothJoint} [{clothJoint * 5.5f}$]\n-Cloth (Fertilizers) : {clothFertilizer} ({clothFertilizer / 4}) [{clothFertilizer * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {joints * 125}$\n-Production Costs : {clothJoint * 2 * 5.5f}$\n=========================\n-Net Profits : {joints * 81}$");
                Console.WriteLine($"\n-Joints Produced : {joints}\n===========================================");

            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Weed_Joint();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Weed_Selector();
            }
        }

        // Weed Profit v2
        static void Weed_Profit()
        {
            Console.Write($"How much profits do you want to make (minimum of 81$) : ");
            string profitS = Console.ReadLine();

            bool success = int.TryParse(profitS, out int profit);

            if (success && profit >= 81)
            {
                float jointsF = profit / 81f;
                int joints = (int)jointsF;

                //Material List
                int clothJoint = joints * 4;
                int clothFertilizer = joints * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n- Cloth (Joint) : {clothJoint} [{clothJoint * 5.5f}$]\n-Cloth (Fertilizers) : {clothFertilizer} ({clothFertilizer/4}) [{clothFertilizer * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {joints * 125}$\n-Production Costs : {clothJoint * 2 * 5.5f}$\n=========================\n-Net Profits : {joints * 81}$");
                Console.WriteLine($"\n-Joints Produced : {joints}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Weed_Profit();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Weed_Selector();
            }
        }

        //Crystal Budget v2
        static void Crystal_Budget()
        {
            Console.Write($"\nEnter your budget (minimum of 447$) : ");
            string budgetS = Console.ReadLine();

            bool success = int.TryParse(budgetS, out int budget);
            if (success && budget >= 447)
            {
                float traysF = budget / 447f;
                int trays = (int)traysF;

                //Material List
                int cloth = trays * 12;
                int chemical = trays * 3;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]\n-Chemicals : {chemical} [{chemical * 127}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {trays * 1400}$\n-Production Costs : {cloth * 5.5f + chemical * 127}$\n=========================\n-Net Profits : {trays * 953}$");
                Console.WriteLine($"\n-Crystal Bags Produced : {trays * 5}\n-Trays Produced : {trays}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Crystal_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Crystal_Selector();
            }
        }

        //Crystal Tray v2
        static void Crystal_Tray()
        {
            Console.Write($"\nHow many trays do you want to make : ");
            string traysS = Console.ReadLine();

            bool success = int.TryParse(traysS, out int trays);
            if (success && trays >= 1)
            {
                //Material List
                int cloth = trays * 12;
                int chemical = trays * 3;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]\n-Chemicals : {chemical} [{chemical * 127}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {trays * 1400}$\n-Production Costs : {cloth * 5.5f + chemical * 127}$\n=========================\n-Net Profits : {trays * 953}$");
                Console.WriteLine($"\n-Crystal Bags Produced : {trays * 5}\n-Trays Produced : {trays}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Crystal_Tray();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Crystal_Selector();
            }
        }

        //Crystal Bags v2
        static void Crystal_Bag()
        {
            Console.Write($"\nHow many bags do you want to make (minimum of 5) : ");
            string bagsS = Console.ReadLine();

            bool success = int.TryParse(bagsS, out int bags);
            if (success && bags >= 5)
            {
                float traysF = bags / 5f;
                int trays = (int)traysF;

                //Material List
                int cloth = trays * 12;
                int chemical = trays * 3;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]\n-Chemicals : {chemical} [{chemical * 127}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {trays * 1400}$\n-Production Costs : {cloth * 5.5f + chemical * 127}$\n=========================\n-Net Profits : {trays * 953}$");
                Console.WriteLine($"\n-Crystal Bags Produced : {trays * 5}\n-Trays Produced : {trays}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Crystal_Bag();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Crystal_Selector();
            }
        }

        //Crystal Profit v2
        static void Crystal_Profit()
        {
            Console.Write($"\nHow much do you want to make (minimum of 953$) : ");
            string profitS = Console.ReadLine();

            bool success = int.TryParse(profitS, out int profit);
            if (success && profit >= 953)
            {
                float traysF = profit / 953f;
                int trays = (int)traysF;

                //Material List
                int cloth = trays * 12;
                int chemical = trays * 3;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]\n-Chemicals : {chemical} [{chemical * 127}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {trays * 1400}$\n-Production Costs : {cloth * 5.5f + chemical * 127}$\n=========================\n-Net Profits : {trays * 953}$");
                Console.WriteLine($"\n-Crystal Bags Produced : {trays * 5}\n-Trays Produced : {trays}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Crystal_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Crystal_Selector();
            }
        }

        //Snow Budget v2
        static void Snow_Budget()
        {
            Console.Write($"\nEnter your budget (minimum of 44$) : ");
            string budgetS = Console.ReadLine();

            bool success = int.TryParse(budgetS, out int budget);
            if (success && budget >= 44)
            {
                float batchesF = budget / 44f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 8;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth/4}) [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 820}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 776}$");
                Console.WriteLine($"\n-Snow Bags Produced : {batches * 4}\n-Batches Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Snow_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Snow_Selector();
            }
        }

        //Snow Batch v2
        static void Snow_Batch()
        {
            Console.Write($"\nHow many batches do you want to make : ");
            string batchesS = Console.ReadLine();

            bool success = int.TryParse(batchesS, out int batches);
            if (success && batches >= 1)
            {
                //Material List
                int cloth = batches * 8;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 820}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 776}$");
                Console.WriteLine($"\n-Snow Bags Produced : {batches * 4}\n-Batches Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Snow_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Snow_Selector();
            }
        }

        //Snow Profit v2
        static void Snow_Profit()
        {
            Console.Write($"\nHow much do you want to make (minimum of 776$) : ");
            string profitS = Console.ReadLine();

            bool success = int.TryParse(profitS, out int profit);
            if (success && profit >= 776)
            {
                float batchesF = profit / 776f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 8;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 820}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 776}$");
                Console.WriteLine($"\n-Snow Bags Produced : {batches * 4}\n-Batches Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Snow_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Snow_Selector();
            }
        }

        //Snow Bags v2
        static void Snow_Bag()
        {
            Console.Write($"\nHow many bags do you want to make (minimum of 4) : ");
            string bagsInputS = Console.ReadLine();

            bool success = int.TryParse(bagsInputS, out int bagsInput);
            if (success && bagsInput >= 4)
            {
                float batchesF = bagsInput / 4f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 8;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth (Fertilizers) : {cloth} ({cloth / 4}) [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 820}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 776}$");
                Console.WriteLine($"\n-Snow Bags Produced : {batches * 4}\n-Batches Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Snow_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Drug Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                DrugMenu();
            }
            else
            {
                Snow_Selector();
            }
        }
    }
}

// Weed : 125x - 44x
// Crystal : 1400x - 447x
// Snow : 820x - 44x