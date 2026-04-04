using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Web;

namespace Rank_Sheet_Generator
{
    internal class RankSheetGenertorMenu
    {
        private IGenerator utility;

        public RankSheetGenertorMenu()
        {
            utility = new GeneratorUtility();
        }
        public void ShowMenu()
        {
            Console.WriteLine("\n==============    WELCOME TO RANK SHEET GENERATOR   ================\n");
            int choice;
            do
            {
                Console.WriteLine("1. Add District");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Get Ranked Students");
                Console.WriteLine("0. Exit\n");

                Console.Write("Enter Option : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddDistrict();
                        break;
                    case 2:
                        utility.AddStudent();
                        break;
                    case 3:
                        utility.DisplayStudentsOfAllDistricts();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Program..............");
                        return;
                }
            } while (choice != 0);
        }
    }
}
