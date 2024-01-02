using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jo
{
    class Cart:LinkedList
    {
        public LinkedList<Product> Products { get; set; }

        public Cart()
        {
            Products = new LinkedList<Product>();
        }
        public double total()
        {
            double sum = 0;
            foreach (Product product in Products)
            {
                sum += (double)product.Price;
            }
            return sum;
        }
        public void MergethenPrintCart()
        {
            foreach (Product product in Products)
            {

                Console.WriteLine($"  * {product.Name} - ${product.Price}");

            }
        }
        public void addtoCart(Product product)
        {
            Products.AddLast(product);
        }
        public void SortProductsByPrice()
        {
            // Sort the products in the shopping cart by price 
            Products = new LinkedList<Product>(Products.OrderBy(p => p.Price));
        }

        public void removefromCart(Product product)
        {
            Products.Remove(product);
        }


    }
}