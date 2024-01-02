using System;
using System.Collections.Generic;
using System.Text;

namespace jo
{
    class Category : LinkedList
    {
        public string Name { get; set; }
        public LinkedList<Product> Products { get; set; }

        public Category(string name)
        {
            Name = name;
            Products = new LinkedList<Product>();
        }

    }
}