using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Furniture_Manufacturing
{
    internal class CustomFurnitureManufacturing
    {
        private static int rodLength = 12;
        private static int[] prices;

        private static int optimalPrice;
        private static string optimalSequence;

        private static int wasteAwarePrice;
        private static string wasteAwareSequence;

        private static int bestWaste;


        static CustomFurnitureManufacturing()
        {
            prices = new int[] { 0, 2, 5, 7, 9, 13, 15, 18, 22, 27, 30, 35, 40 };
            optimalPrice = 0;
            optimalSequence = "";
            wasteAwarePrice = 0;
            wasteAwareSequence = "";
            bestWaste = int.MaxValue;
        }

        public static void Main(string[] args)
        {
            CustomFurnitureManufacturing  woodCutting  = new CustomFurnitureManufacturing();
            woodCutting.Menu();
        }

        void Menu()
        {
            Console.WriteLine("=============   Custom Furniture Manufacturing   ====================");

            while (true)
            {
                Console.WriteLine("1. Scenario A: Maximize earnings (no waste concern)");
                Console.WriteLine("2. Scenario B: Maximize earnings with fixed waste constraint");
                Console.WriteLine("3. Scenario C: Maximize earnings + minimize waste");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FindCuttingWithNoWaste();
                        break;
                    case 2:
                        FindCuttingWithFixedWaste();
                        break;
                    case 3:
                        FindCuttingWithMinimizeWaste();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Program.............");
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Enter Option from 1 to 4 Only");
                        break;
                }
            }
        }

        void FindCuttingWithNoWaste()
        {
            FindCuttingWithNoWasteRecursively(rodLength, 0, "");
            Console.WriteLine("\n=========  Best Cut With Max Revenue  =========");
            Console.WriteLine("Optimal Price "+ optimalPrice);
            Console.WriteLine("Optimal Sequence "+ optimalSequence);
        }

        void FindCuttingWithNoWasteRecursively(int remaining , int currentPrice , string currectSequence)
        {
            if(remaining == 0)
            {
                if(currentPrice > optimalPrice)
                {
                    optimalPrice = currentPrice;
                    optimalSequence = currectSequence;
                }
                return;
            }

            for(int i=1; i<= remaining; i++)
            {
                FindCuttingWithNoWasteRecursively (remaining - i, currentPrice + prices[i], currectSequence + i);
            }
        }

        void FindCuttingWithFixedWaste()
        {
            Console.WriteLine("Enter max allowed waste:");
            int maxWaste = int.Parse(Console.ReadLine());

            FindCuttingWithFixedWasteConstraint(0, 0, "", maxWaste);

            Console.WriteLine("\n[Scenario B] Best Cut (With Waste Constraint)");
            Console.WriteLine("Cut Sequence: " + wasteAwareSequence);
            Console.WriteLine("Total Price: " + wasteAwarePrice);
            Console.WriteLine("Waste: " + bestWaste + " ft");


        }

        void FindCuttingWithFixedWasteConstraint(int usedLength, int price, string sequence, int maxWaste)
        {
            int waste = rodLength - usedLength;

            if (waste < 0) return;

            if (waste <= maxWaste)
            {
                if (price > wasteAwarePrice)
                {
                    wasteAwarePrice = price;
                    wasteAwareSequence = sequence;
                    bestWaste = waste;
                }
            }

            for (int i = 1; i <= rodLength; i++)
            {
                FindCuttingWithFixedWasteConstraint(usedLength + i, price + prices[i], sequence + i, maxWaste);
            }
        }

        void FindCuttingWithMinimizeWaste()
        {
            FindRevenueWithMinimizeWaste(0, 0, "");

            Console.WriteLine("\n[Scenario C] Best Cut (Max Revenue + Min Waste)");
            Console.WriteLine("Cut Sequence: " + wasteAwareSequence);
            Console.WriteLine("Total Price: " + wasteAwarePrice);
            Console.WriteLine("Waste: " + bestWaste + " ft");

        }

        void FindRevenueWithMinimizeWaste(int usedLength, int price, string sequence)
        {
            int waste = rodLength - usedLength;

            if (waste < 0) return;

            if (price > wasteAwarePrice || (price == wasteAwarePrice && waste < bestWaste))
            {
                wasteAwarePrice = price;
                wasteAwareSequence = sequence;
                bestWaste = waste;
            }

            for (int i = 1; i <= rodLength; i++)
            {
                FindRevenueWithMinimizeWaste(usedLength + i, price + prices[i], sequence + i);
            }
        }
    }
}
