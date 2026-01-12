using System;
using System.Collections.Generic;
using System.Text;

namespace MetalFactoryPipeCutting
{
    internal class MetalFactoryPipeCutting
    {
        private static int rodlength = 8;
        private static int[] prices;

        private static int optimalCuttingPrice;
        private static string optimalCuttingSequence;

        private static int customCuttingPrice;
        private static string customCuttingSequence;

        static MetalFactoryPipeCutting()
        {
            prices = new int[] { 0, 1, 4, 5, 7, 9, 13, 15, 19 };

        }

        public static void Main(string[] args)
        {
            MetalFactoryPipeCutting pipeCutting = new MetalFactoryPipeCutting();
            pipeCutting.Menu();
        }

        void Menu()
        {
            Console.WriteLine("=============  Metal Factory Pipe Cutting  =================");
            while (true)
            {
                Console.WriteLine("1.Cut rod using Optimal Sequence");
                Console.WriteLine("2.Cut rod using User Sequence");
                Console.WriteLine("3.Compare the results");
                Console.WriteLine("4.Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FindOptimalCutting();
                        break;
                    case 2:
                        FindCustomCutting();
                        break;
                    case 3:
                        FindOptimalCutting();
                        FindCustomCutting();
                        CompareResults();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Program ................");
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Enter the option from 1 to 4 only");
                        break;
                }
            }
        }

        void FindOptimalCutting()
        {
            optimalCuttingPrice = 0;
            optimalCuttingSequence = "";

            FindOptimalCutting(rodlength, 0, "");

            Console.WriteLine("/n============   Optimal Cutting:   ============");
            Console.WriteLine("Cut Sequence "+ optimalCuttingSequence);
            Console.WriteLine("Total Price "+ optimalCuttingPrice+"\n");
        }

        void FindOptimalCutting(int remainingLength, int currentPrice ,  string currentSequence)
        {
            if(remainingLength == 0)
            {
                if (currentPrice > optimalCuttingPrice)
                {
                    optimalCuttingPrice = currentPrice;
                    optimalCuttingSequence = currentSequence;
                }
                return;
            }

            for(int i=1; i<=remainingLength; i++)
            {
                FindOptimalCutting(remainingLength - i, currentPrice + prices[i], currentSequence + i);
            }
        }

        void FindCustomCutting()
        {
            Console.WriteLine("\nEnter the custom cutting sequence like 2222");
            customCuttingSequence = Console.ReadLine();

            int totallength = 0;

            customCuttingPrice = 0;

            foreach (char c in customCuttingSequence)
            {
                int cut = c - '0';
                totallength += cut;
                customCuttingPrice += prices[cut];
            }

            if(totallength != rodlength)
            {
                Console.WriteLine("\nInvalid Cutting Sequence. Length Mismatch!");
                customCuttingPrice = 0;
                return;
            }

            Console.WriteLine("\n==========  Custom Cutting  ============");
            Console.WriteLine("Custom Cutting Price "+ customCuttingPrice);
            Console.WriteLine("Custom Cutting Sequence " + customCuttingSequence+"\n");

        }

        void CompareResults()
        {
            Console.WriteLine("\n===== Comparison Results =====\n");
            Console.WriteLine("Optimal Price " + optimalCuttingPrice);
            Console.WriteLine("Custom Price "+ customCuttingPrice+ "\n");

            if(customCuttingPrice > optimalCuttingPrice)
            {
                Console.WriteLine("Custom Cutting Beats Optimal Cutting");
            }
            else
            {
                Console.WriteLine("Optimal Cutting Beats Custom Cutting");
            }
        }
    }
}
