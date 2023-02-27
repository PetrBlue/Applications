using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obchudek
{
    internal class ShoppingCart
    {
        public List<Product> products = new List<Product>();
        public float totalPrice;
        public ShoppingCart()
        {

        }
        public void CalculateTotalPrice()
        {
            totalPrice = 0;
            foreach (var item in products)
            {
                totalPrice += item.price;
            }
        }
    }
}
