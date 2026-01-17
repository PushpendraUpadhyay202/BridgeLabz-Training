using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class ProductImpl : IProduct
    {
        private Product[] products;
        private int productIndex;

        public ProductImpl()
        {
            int productSize = 10;
            products = new Product[productSize];
            productIndex = 0;

        }
        public void Addproduct()
        {
            if(productIndex >= products.Length)
            {
                ResizeProductList();
            }

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Original Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Product Discount: ");
            double discount = double.Parse(Console.ReadLine());

            Product product = new Product(name , price, discount);
            products[productIndex++] = product;

            QuickSort(0, productIndex - 1);

            Console.WriteLine("\n New Product Added Successfully\n");
        }
        public void ListAllProduct()
        {
            Console.WriteLine("=============   PRODUCTS LIST ===========\n");
            if(productIndex == 0)
            {
                Console.WriteLine("\nThere is No Product Yet Entered\n");
            }
            for(int i = 0; i < productIndex; i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine();

        }

        public void MostDiscountedProduct()
        {
            Console.WriteLine("\n============   PRODUCT WITH MOST DISCOUNT   =============\n");
            if(productIndex == 0)
            {
                Console.WriteLine("\nThere is No Product Yet Entered\n");
                return;
            }
            Console.WriteLine("\nProduct With Most Discount is");
            Console.WriteLine(products[0]);
        }

        private void QuickSort(int left , int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivotIndex = Partition(left, right);
            QuickSort(left, pivotIndex - 1);
            QuickSort(pivotIndex + 1, right);
        }

        private int Partition(int left , int right)
        {
            int boudary = left-1;
            Product pivorElement = products[right];

            for(int i=left; i < right; i++)
            {
                if (products[i].GetProductDiscount() > pivorElement.GetProductDiscount())
                {
                    ++boudary;
                    Product temp = products[i];
                    products[i] = products[boudary];
                    products[boudary] = temp;
                }
            }

            Product temp2 = products[boudary + 1];
            products[boudary + 1] = products[right];
            products[right] = temp2;

            return boudary + 1;

        }
        private void ResizeProductList()
        {
            Product[] tempList = new Product[2 * productIndex];
            for(int i = 0; i < productIndex; i++)
            {
                tempList[i] = products[i];
            }
            products = tempList;
        }
    }
}
