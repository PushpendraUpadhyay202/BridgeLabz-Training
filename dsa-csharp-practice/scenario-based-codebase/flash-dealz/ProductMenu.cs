using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class ProductMenu
    {
        private IProduct utility;
        public ProductMenu()
        {
            utility = new ProductImpl();
        }
        public void ShowMenu()
        {
            Console.WriteLine("============   WELCOME TO FLASH DEALZ   ==============");

            int choice;
            do
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. List All Products");
                Console.WriteLine("3. Discounted Product List");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.Addproduct();
                        break;
                    case 2:
                        utility.ListAllProduct();
                        break;
                    case 3:
                        utility.MostDiscountedProduct();
                        break;
                    case 0:
                        Console.WriteLine("Exiting Program..........");
                        return;

                }
            }
            while (choice != 0);
        }
    }
}
