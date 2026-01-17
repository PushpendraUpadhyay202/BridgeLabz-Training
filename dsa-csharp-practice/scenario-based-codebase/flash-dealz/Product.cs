using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class Product
    {
        private string productName;
        private double productOriginalPrice;
        private double productDiscount;

        public Product(string productName, double productOriginalPrice, double productDiscount)
        {
            this.productName = productName;
            this.productOriginalPrice = productOriginalPrice;
            this.productDiscount = productDiscount;
        }

        public double GetProductDiscount()
        {
            return productDiscount; 
        }

        public override string? ToString()
        {
            return "Product Name : "+ productName + 
                    "\nProduct Original Price : "+productOriginalPrice +
                    "\nProduct Discount : "+productDiscount;
        }
    }
}
