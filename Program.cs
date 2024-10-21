using System;

namespace LifeRP_DrugCalc
{
    class Program
    {

        static void Main()
        {
            Console.Title = "Life RP Drug Calculator - v3";
            Console.WriteLine($"============================== LIFE RP Calculator ==============================");
            StartMenu();
        }

        static void StartMenu()
        {
            Console.Write($"\nChoose calculator type (Legal or Illegal) : ");
            string calcType = Console.ReadLine();

            switch (calcType.ToLower())
            {
                case "legal":
                    LegalMenu();
                    break;
                case "illegal":
                    DrugMenu();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again." + "\n");
                    StartMenu();
                    break;
            }

        }
        static void DrugMenu()
        {

            Console.Write($"\nWhat type of drugs are you making (Weed, Crystal, Snow or BChem) : ");
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
                case "bchem":
                    BChem_Selector();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Drug Type, try again." + "\n");
                    DrugMenu();
                    break;
            }

        }
        static void LegalMenu()
        {
            Console.Write($"\nWhat are you producing (Tobacco) : ");
            string legalType = Console.ReadLine();

            switch (legalType.ToLower())
            {
                case "tobacco":
                    Tobacco_Selector();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Product Type, try again." + "\n");
                    LegalMenu();
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

        static void BChem_Selector()
        {
            Console.Write("\n" + "Enter calculator type (Budget, Shipment, Refined) : ");
            string weedType = Console.ReadLine();

            switch (weedType.ToLower())
            {
                case "budget":
                    BChem_Budget();
                    break;
                case "shipment":
                    BChem_Shipment();
                    break;
                case "refined":
                    BChem_Refined();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again");
                    BChem_Selector();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
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
                Snow_Bag();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                Snow_Selector();
            }
        }

        static void Tobacco_Selector()
        {
            Console.Write("\n" + "Enter calculator type (Budget, Plant, Cigar, Profit) : ");
            string tobaccoType = Console.ReadLine();

            switch (tobaccoType.ToLower())
            {
                case "budget":
                    Tobacco_Budget();
                    break;
                case "plant":
                    Tobacco_Batch();
                    break;
                case "profit":
                    Tobacco_Profit();
                    break;
                case "cigar":
                    Tobacco_Cigar();
                    break;
                default:
                    Console.WriteLine("\n" + "Invalid Calculator Type, try again");
                    Tobacco_Selector();
                    break;
            }
        }

        // Tobacco Budget
        static void Tobacco_Budget()
        {
            Console.Write($"\nEnter your budget (minimum of 33$) : ");
            string budgetS = Console.ReadLine();

            bool success = int.TryParse(budgetS, out int budget);
            if (success && budget >= 33)
            {
                float batchesF = budget / 33f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 6;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 615}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 582}$");
                Console.WriteLine($"\n-Cigars Produced : {batches * 3}\n-Plants Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Tobacco_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                Tobacco_Selector();
            }
        }

        // Tobacco Batch
        static void Tobacco_Batch()
        {
            Console.Write($"\nHow many plants do you have produced : ");
            string batchesS = Console.ReadLine();

            bool success = int.TryParse(batchesS, out int batches);
            if (success && batches >= 1)
            {
                //Material List
                int cloth = batches * 6;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 615}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 582}$");
                Console.WriteLine($"\n-Cigars Produced : {batches * 3}\n-Plants Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Tobacco_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                Tobacco_Selector();
            }
        }

        // Tobacco Profit
        static void Tobacco_Profit()
        {
            Console.Write($"\nHow much do you want to make (minimum of 582$) : ");
            string profitS = Console.ReadLine();

            bool success = int.TryParse(profitS, out int profit);
            if (success && profit >= 582)
            {
                float batchesF = profit / 582f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 6;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 615}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 582}$");
                Console.WriteLine($"\n-Cigars Produced : {batches * 3}\n-Plants Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Tobacco_Profit();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                Tobacco_Selector();
            }
        }

        // Tobacco Cigar
        static void Tobacco_Cigar()
        {
            Console.Write($"\nHow many bags do you want to make (minimum of 3) : ");
            string bagsInputS = Console.ReadLine();

            bool success = int.TryParse(bagsInputS, out int bagsInput);
            if (success && bagsInput >= 3)
            {
                float batchesF = bagsInput / 3f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 6;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 615}$\n-Production Costs : {cloth * 5.5f}$\n=========================\n-Net Profits : {batches * 582}$");
                Console.WriteLine($"\n-Cigars Produced : {batches * 3}\n-Plants Produced : {batches}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                Tobacco_Cigar();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                Tobacco_Selector();
            }
        }

        // BChem Budget
        static void BChem_Budget()
        {
            Console.Write($"\nEnter your budget (minimum of 777$) : ");
            string budgetS = Console.ReadLine();

            bool success = int.TryParse(budgetS, out int budget);
            if (success && budget >= 777)
            {
                float batchesF = budget / 777f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 2;
                int berries = batches * 2;
                int chemicals = batches * 6;
                int water = batches * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]\n-Indigo Berries : {berries/2}\n-Amber Berries : {berries}\n-Mauve Berries : {berries}\n-Water : {water} [{water * 1}$]\n-Chemicals : {chemicals} [{chemicals * 127}$]");

                //Misc Stats
                float shipmentF = batches / 250f;
                int shipment = (int)shipmentF;
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 4354.396f}$\n-Production Costs : {batches * 777}$\n=========================\n-Net Profits : {batches * 3577.396f}$");
                Console.WriteLine($"\n-Refined Berry Chemicals Produced : {batches * 2}\n-Shipments Ready : {shipment}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                BChem_Budget();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                BChem_Selector();
            }
        }

        //BChem Shipment
        static void BChem_Shipment()
        {
            Console.Write($"\nHow many shipments do you want to make : ");
            string shipmentS = Console.ReadLine();

            bool success = int.TryParse(shipmentS, out int shipment);
            if (success && shipment >= 1)
            {
                //Material List
                int batches = shipment * 250;
                int cloth = batches * 2;
                int berries = batches * 2;
                int chemicals = batches * 6;
                int water = batches * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]\n-Indigo Berries : {berries / 2}\n-Amber Berries : {berries}\n-Mauve Berries : {berries}\n-Water : {water} [{water * 1}$]\n-Chemicals : {chemicals} [{chemicals * 127}$]");

                //Misc Stats
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 4354.396f}$\n-Production Costs : {batches * 777}$\n=========================\n-Net Profits : {batches * 3577.396f}$");
                Console.WriteLine($"\n-Refined Berry Chemicals Produced : {batches * 2}\n-Shipments Ready : {shipment}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                BChem_Shipment();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                BChem_Selector();
            }
        }

        // BChem Refined
        static void BChem_Refined()
        {
            Console.Write($"\nHow many refined berry chemicals do you want to make (minimum of 2) : ");
            string bagsInputS = Console.ReadLine();

            bool success = int.TryParse(bagsInputS, out int bagsInput);
            if (success && bagsInput >= 2)
            {
                float batchesF = bagsInput / 2f;
                int batches = (int)batchesF;

                //Material List
                int cloth = batches * 2;
                int berries = batches * 2;
                int chemicals = batches * 6;
                int water = batches * 4;
                Console.WriteLine($"\n===========================================\nMATERIAL LIST : \n-Cloth : {cloth} [{cloth * 5.5f}$]\n-Indigo Berries : {berries / 2}\n-Amber Berries : {berries}\n-Mauve Berries : {berries}\n-Water : {water} [{water * 1}$]\n-Chemicals : {chemicals} [{chemicals * 127}$]");

                //Misc Stats
                float shipmentF = batches / 250f;
                int shipment = (int)shipmentF;
                Console.WriteLine($"\nMONEY STATISTICS :\n-Gross Profits : {batches * 4354.396f}$\n-Production Costs : {batches * 777}$\n=========================\n-Net Profits : {batches * 3577.396f}$");
                Console.WriteLine($"\n-Refined Berry Chemicals Produced : {batches * 2}\n-Shipments Ready : {shipment}\n===========================================");
            }
            else
            {
                Console.WriteLine($"\nInvalid Characters, try again");
                BChem_Refined();
            }

            //End Menu
            Console.ReadKey();
            Console.WriteLine($"\nType 'Back' to return to Calculator Selection, or press any key to go back to Mode Selection");
            string endMenu = Console.ReadLine();

            if (endMenu.ToLower() == "back")
            {
                StartMenu();
            }
            else
            {
                BChem_Selector();
            }
        }
    }
}

// Weed : 125x - 44x
// Crystal : 1400x - 447x
// Snow : 820x - 44x
// Berry Chems : 4354.396x - 777x

// Tobacco : 615x - 33x