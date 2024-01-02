using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSJ;

    public class LinkedList
    {
        public Node head { get; set; }

        // Node structure
        public class Node
        {
            public int Data { get; set; } // Adjust data type as needed
            public Node Next { get; set; }
        }

        // Add a new node to the end of the list
        public void Add(int data)
        {
            Node newNode = new Node() { Data = data };

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        // Remove a node with the specified data
        public void Remove(int data)
        {
            if (head == null)
            {
                return; // List is empty
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return; // Node not found
            }

            current.Next = current.Next.Next;
        }

        // Update the data of a node with the specified data
        public void Update(int dataToUpdate, int newData)
        {
            if (head == null)
            {
                return; // List is empty
            }

            Node current = head;
            while (current != null && current.Data != dataToUpdate)
            {
                current = current.Next;
            }

            if (current == null)
            {
                return; // Node not found
            }

            current.Data = newData;
        }

        // Print the elements of the linked list
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }


    }
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

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }

    class Cart : LinkedList
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
    class Supermarket : LinkedList
    {
        public LinkedList<Category> Categories { get; set; }
        public void Loaddata()
        {
            AddCategory("1- Bakery");
            AddCategory("2- Beverages");
            AddCategory("3- Dairy");
            AddCategory("4- Canned Food");
            AddCategory("5- Frozen Food");
            AddCategory("6- Meat");
            AddCategory("7- Poultry");
            AddCategory("8- Seafood");
            AddCategory("9- Vegetables");
            AddCategory("10- Fruit");
            AddCategory("11- Groceries");
            AddCategory("12- Snacks");
            AddCategory("13- Sweets");
            AddCategory("14- Beauty Products");
            AddCategory("15- Detergents");

            AddProduct("1- Bakery", "Bread", 1.99);
            AddProduct("1- Bakery", "Cake", 49.99);
            AddProduct("1- Bakery", "Pizza", 79.99);
            AddProduct("1- Bakery", "Cookies", 7.99);
            AddProduct("1- Bakery", "Biscuits", 6.99);
            AddProduct("1- Bakery", "Rich Bake Toast With Milk", 34.99);
            AddProduct("1- Bakery", "Rich Bake Oat Toast", 34.99);
            AddProduct("2- Beverages", "Water 1 L", 8.99);
            AddProduct("2- Beverages", "Pepsi 250 ml", 4.99);
            AddProduct("2- Beverages", "Pepsi 1 L", 13.99);
            AddProduct("2- Beverages", "Merinda 250 ml", 4.99);
            AddProduct("2- Beverages", "Merinda 1 L", 13.99);
            AddProduct("2- Beverages", "7 Up 250 ml", 4.99);
            AddProduct("2- Beverages", "7 Up 1 L", 13.99);
            AddProduct("2- Beverages", "Schweppes 1 L", 12.99);
            AddProduct("2- Beverages", "Fairouz 1 L", 13.99);
            AddProduct("2- Beverages", "Redbull 250 ml", 24.99);
            AddProduct("2- Beverages", "Beyti Apple Juice 1 L", 18.99);
            AddProduct("2- Beverages", "Beyti Guava Juice 1 L", 18.99);
            AddProduct("2- Beverages", "Beyti Pineapple Juice 1 L", 18.99);
            AddProduct("2- Beverages", "Beyti Cocktail Juice 1 L", 18.99);
            AddProduct("2- Beverages", "Beyti Mango Juice 1 L", 18.99);
            AddProduct("2- Beverages", "Beyti Apple Juice 250 ml", 6.99);
            AddProduct("2- Beverages", "Beyti  Guava Juice 250 ml", 6.99);
            AddProduct("2- Beverages", "Beyti  Pineapple Juice 250 ml", 6.99);
            AddProduct("2- Beverages", "Beyti  Cocktail Juice 250 ml", 6.99);
            AddProduct("2- Beverages", "Beyti  Mango Juice 250 ml", 6.99);
            AddProduct("2- Beverages", "Juhaina Red Grapes Juice 1 L", 24.99);
            AddProduct("2- Beverages", "Juhaina Red Grapes Juice 250 ml", 11.99);
            AddProduct("3- Dairy", "Lamar Milk 1 L", 34.99);
            AddProduct("3- Dairy", "Juhaina Milk 1 L", 39.99);
            AddProduct("3- Dairy", "Roumy Cheese 250 gm", 54.99);
            AddProduct("3- Dairy", "Chedder Cheese 250 gm", 79.99);
            AddProduct("3- Dairy", "Gouda Cheese 250 gm", 69.99);
            AddProduct("3- Dairy", "Falamnk Cheese 250 gm", 95.99);
            AddProduct("3- Dairy", "Blue Cheese 250 gm", 96.99);
            AddProduct("3- Dairy", "Roumy Cheese 250 gm", 54.99);
            AddProduct("3- Dairy", "Panda Mozarella Cheese 250 gm", 69.99);
            AddProduct("3- Dairy", "President Cheese 16 Pieces", 79.99);
            AddProduct("3- Dairy", "President Cheese 48 Pieces", 129.99);
            AddProduct("3- Dairy", "Al Marai Yogurt", 6.99);
            AddProduct("3- Dairy", "Juhaina Yogurt", 7.99);
            AddProduct("4- Canned Food", "California Sweet Corn", 29.99);
            AddProduct("4- Canned Food", " El Tahia Sweet Corn", 19.99);
            AddProduct("4- Canned Food", "California Fava Beans", 24.99);
            AddProduct("4- Canned Food", "Harvest Fava Beans", 19.99);
            AddProduct("4- Canned Food", "Rio Tuna", 79.99);
            AddProduct("4- Canned Food", "California Tuna", 59.99);
            AddProduct("4- Canned Food", "El Bawady Tahina", 99.99);
            AddProduct("4- Canned Food", "El Bawady Molasses(Molasses)", 79.99);
            AddProduct("4- Canned Food", "Emtenan 3asal Abiad", 149.99);
            AddProduct("4- Canned Food", "Vitrac Strawberry Jam 250 ml", 44.99);
            AddProduct("4- Canned Food", "Vitrac Blue Berry Jam 250 ml", 44.99);
            AddProduct("4- Canned Food", "Vitrac Cherry Jam 250 ml", 44.99);
            AddProduct("4- Canned Food", "Vitrac Appricot Jam 250 ml", 44.99);
            AddProduct("4- Canned Food", "Heinz Ketchup 350 gm", 29.99);
            AddProduct("4- Canned Food", "Foody Ketchup 350 gm", 22.99);
            AddProduct("4- Canned Food", "Heinz Mustard 350 gm", 24.99);
            AddProduct("4- Canned Food", "Heinz Mayonnaise 350 gm", 39.99);
            AddProduct("4- Canned Food", "Heinz Soy Sauce 350 ml", 69.99);
            AddProduct("4- Canned Food", "Good France Ranch Sauce 250 gm", 44.99);
            AddProduct("4- Canned Food", "Good France Barbeque Sauce 250 gm", 49.99);
            AddProduct("4- Canned Food", "Heinz Tomato Sauce 250 gm", 24.99);
            AddProduct("4- Canned Food", "Foody Tomato Sauce 250 gm", 19.99);
            AddProduct("4- Canned Food", "Rashidi El Mizan Halawa 500 gm", 59.99);
            AddProduct("4- Canned Food", " Ahmed Tea 100 Tea Bag", 159.99);
            AddProduct("4- Canned Food", " Ahmed Tea Green Tea 100 Tea Bags", 144.99);
            AddProduct("4- Canned Food", "El Aroussa Tea 100 Tea bag", 139.99);
            AddProduct("4- Canned Food", "Nescafe Classic 250 ml", 59.99);
            AddProduct("4- Canned Food", "Nescafe Gold 250 ml", 79.99);
            AddProduct("4- Canned Food", "Masr Cafe 250 ml", 49.99);
            AddProduct("4- Canned Food", "Nescafe Arabiana 20 sachets", 99.99);
            AddProduct("4- Canned Food", "Abu Auf Arabiana 20 sachets", 99.99);
            AddProduct("4- Canned Food", "Nesquik Chocolate Powder 250 gm", 69.99);
            AddProduct("4- Canned Food", "Corona Chocolate Powder 250 gm", 49.99);
            AddProduct("4- Canned Food", "Royal Anise 20 Bags", 34.99);
            AddProduct("4- Canned Food", "Royal Tillia 20 Bags", 34.99);
            AddProduct("4- Canned Food", "Royal Peppermint 20 Bags", 34.99);
            AddProduct("4- Canned Food", "Nutella 350 gm", 149.99);
            AddProduct("4- Canned Food", "Lotus 350 gm", 179.99);

            AddProduct("5- Frozen Food", "Al Marai Burger Jumbo 1.5 Kg", 219.99);
            AddProduct("5- Frozen Food", "Al Marai Burger Jumbo 2 Kg", 289.99);
            AddProduct("5- Frozen Food", "Halwany Burger Jumbo 1.5 Kg", 249.99);
            AddProduct("5- Frozen Food", "Halwany Burger Jumbo 2 Kg", 309.99);
            AddProduct("5- Frozen Food", "Atyab Fried Chicken Fillet 1 Kg", 219.99);
            AddProduct("5- Frozen Food", "Atyab Fried Nuggets 1 Kg", 169.99);
            AddProduct("5- Frozen Food", "Atyab Fried Chicken strips 1 Kg", 239.99);
            AddProduct("5- Frozen Food", "Halwany Sausage", 79.99);
            AddProduct("5- Frozen Food", "Halwany Hot Dog", 149.99);
            AddProduct("5- Frozen Food", "Basma Frozen Green Peas 400 gm", 41.99);
            AddProduct("5- Frozen Food", "Montana Frozen Bamia", 34.99);
            AddProduct("5- Frozen Food", "Givrex Molo5eia", 31.99);
            AddProduct("5- Frozen Food", "Basma Frozen Strawberry", 34.99);
            AddProduct("5- Frozen Food", "Farm Frites 2 Kg", 119.99);
            AddProduct("5- Frozen Food", "El Sombola Golash ", 64.99);
            AddProduct("5- Frozen Food", "El Sombola Sambousa", 84.99);
            AddProduct("6- Meat", "Steak Meat 500 gm", 199.99);
            AddProduct("6- Meat", "Minced Meat 500 gm", 159.99);
            AddProduct("6- Meat", "Meat Cubes 500 gm", 159.99);
            AddProduct("6- Meat", "Meat Shawerma 500 gm", 159.99);
            AddProduct("7- Poultry", "Fillet 500 gm", 99.99);
            AddProduct("7- Poultry", "Shish 500 gm", 109.99);
            AddProduct("7- Poultry", "Thighs 500 gm", 79.99);
            AddProduct("7- Poultry", "Chicken Shawerma 500 gm", 109.99);

            AddProduct("8- Seafood", "Bolty 1 Kg", 89.99);
            AddProduct("8- Seafood", "Boury 1 Kg", 199.99);
            AddProduct("8- Seafood", "Shrimps 1 Kg", 349.99);
            AddProduct("8- Seafood", "Crab 1 Kg", 249.99);
            AddProduct("8- Seafood", "Calimary 1 Kg", 159.99);
            AddProduct("9- Vegetables", "Cucumber 1 Kg", 19.99);
            AddProduct("9- Vegetables", "Tomato 1 Kg", 9.99);
            AddProduct("9- Vegetables", "Carrot 1 Kg", 19.99);
            AddProduct("9- Vegetables", "Green Pepper 1 Kg", 19.99);
            AddProduct("9- Vegetables", "Yellow And Red Pepper 1 Kg", 39.99);
            AddProduct("9- Vegetables", "Potato 1 Kg", 19.99);
            AddProduct("9- Vegetables", "Lettuce 1 Kg", 6.99);
            AddProduct("9- Vegetables", "Zucchini 1 Kg", 19.99);
            AddProduct("9- Vegetables", "Onions 1 Kg", 26.99);
            AddProduct("10- Fruit", "Apple 1 Kg", 69.99);
            AddProduct("10- Fruit", "Banana 1 Kg", 16.99);
            AddProduct("10- Fruit", "Orange 1 Kg", 19.99);
            AddProduct("10- Fruit", "Kiwi 1 Kg", 59.99);
            AddProduct("10- Fruit", "Pomegranate 1 Kg", 14.99);
            AddProduct("10- Fruit", "Mango 1 Kg", 29.99);
            AddProduct("10- Fruit", "Guava 1 Kg", 19.99);
            AddProduct("10- Fruit", "Grapes 1 Kg", 25.99);
            AddProduct("10- Fruit", "Pear 1 Kg", 29.99);
            AddProduct("10- Fruit", "Pineapple 1 Kg", 99.99);
            AddProduct("11- Groceries", "Fasolia 500 gm", 39.99);
            AddProduct("11- Groceries", "Hummus 500 gm", 69.99);
            AddProduct("11- Groceries", "Lentils 500 gm", 49.99);
            AddProduct("11- Groceries", "Lobia 500 gm", 39.99);
            AddProduct("11- Groceries", "Wheat 500 gm", 34.99);
            AddProduct("11- Groceries", "Salt 500 gm", 9.99);
            AddProduct("11- Groceries", "Black Pepper 500 gm", 79.99);
            AddProduct("11- Groceries", "Paprika 500 gm", 49.99);
            AddProduct("11- Groceries", "Curry 500 gm", 69.99);
            AddProduct("11- Groceries", "Korkom 500 gm", 49.99);
            AddProduct("11- Groceries", "Cinammon 500 gm", 39.99);
            AddProduct("11- Groceries", "Italiano Pasta Penne 500 gm", 16.99);
            AddProduct("11- Groceries", "Italiano Pata Spaghetti 500 gm", 14.99);
            AddProduct("11- Groceries", "Lino Penne Pasta With Oats 500 gm", 69.99);
            AddProduct("11- Groceries", "El Doha Rice 1 Kg", 31.99);
            AddProduct("11- Groceries", "El Doha Rice 5 Kg", 169.99);
            AddProduct("11- Groceries", "El Doha Rice Basmaty 1 Kg", 54.99);
            AddProduct("11- Groceries", "El Doha Flour 1 Kg", 29.99);
            AddProduct("11- Groceries", "Dobella Oats Flour 1 Kg", 99.99);
            AddProduct("11- Groceries", "El Doha Corn Flour 1 Kg", 24.99);
            AddProduct("11- Groceries", "El Doha Sugar 1 Kg", 44.99);
            AddProduct("11- Groceries", "Crystal Sunflower Oil  1.5 L", 61.99);
            AddProduct("11- Groceries", "Crystal Corn Oil 1.5 Kg", 139.99);
            AddProduct("11- Groceries", "Virginia Olive Oil 1 L", 179.99);
            AddProduct("11- Groceries", "Maggy Chicken Broth 12 Pieces", 21.99);
            AddProduct("12- Snacks", "Chipsy Salt Jumbo", 9.99);
            AddProduct("12- Snacks", "Chipsy Tomato Jumbo", 9.99);
            AddProduct("12- Snacks", "Chipsy Cheese Jumbo", 9.99);
            AddProduct("12- Snacks", "Doritos Sweet Pepper Jumbo", 11.99);
            AddProduct("12- Snacks", "Cheetos Cheese Jumbo", 11.99);
            AddProduct("12- Snacks", "Sun Bites Olive oil And Thyme Jumbo", 4.99);
            AddProduct("12- Snacks", "Tiger Seasoned Cheese Jumbo", 9.99);
            AddProduct("12- Snacks", "Tiger Tomato Jumbo", 9.99);
            AddProduct("12- Snacks", "Raw Salt Jumbo", 11.99);
            AddProduct("12- Snacks", "Raw Paprika Jumbo", 11.99);
            AddProduct("12- Snacks", "Spuds Salt Jumbo", 9.99);
            AddProduct("12- Snacks", "Salted Almonds 250 gm", 79.99);
            AddProduct("12- Snacks", "Pistachio 250 gm", 119.99);
            AddProduct("12- Snacks", "Kajo 250 gm", 124.99);
            AddProduct("12- Snacks", "Hazelnut 250 gm", 89.99);
            AddProduct("12- Snacks", "3en Gamal 250 gm", 99.99);
            AddProduct("12- Snacks", "Raisins 250 gm", 64.99);
            AddProduct("13- Sweets", "Galaxy Salted Caramel Chocolate", 24.99);
            AddProduct("13- Sweets", "Galaxy Hazelnut Chocolate", 24.99);
            AddProduct("13- Sweets", "Galaxy Plain Chocolate", 24.99);
            AddProduct("13- Sweets", "Cadbuary Plain Chocolate", 29.99);
            AddProduct("13- Sweets", "Cadbuary Caramel Chocolate", 29.99);
            AddProduct("13- Sweets", "Cadbuary Hazelnut Chocolate", 29.99);
            AddProduct("13- Sweets", "Cadbuary Marvelous Creation Chocolate", 29.99);
            AddProduct("13- Sweets", "Moro Chocolate", 19.99);
            AddProduct("13- Sweets", "Corona Plain Chocolate", 24.99);
            AddProduct("13- Sweets", "Corona Mint Chocolate", 24.99);
            AddProduct("13- Sweets", "Corona Hazelnut Chocolate", 24.99);
            AddProduct("13- Sweets", "Milka Plain Chocolate", 34.99);
            AddProduct("13- Sweets", "Milka Oreo Chocolate", 35.99);
            AddProduct("13- Sweets", "Milka Salted Caramel Chocolate", 35.99);
            AddProduct("13- Sweets", "Ulker Biscuit 12 Packets", 35.99);
            AddProduct("13- Sweets", "Chatto Chocolate Biscuit", 19.99);
            AddProduct("13- Sweets", "Biskrem Chocolate Biscuit", 9.99);
            AddProduct("13- Sweets", "Nawaem Biscuit", 5.99);
            AddProduct("13- Sweets", "Halley Marshmellow Biscuit", 9.99);
            AddProduct("13- Sweets", "Trident Peppermint Gum", 9.99);
            AddProduct("13- Sweets", "Trident Cinammon Gum", 29.99);
            AddProduct("13- Sweets", "Trident Watermelon Gum", 9.99);
            AddProduct("13- Sweets", "Chicklets Peppermint Gum", 7.99);
            AddProduct("13- Sweets", "Chicklets Tutti Fruity Gum", 7.99);
            AddProduct("13- Sweets", "Lollipop with Gum", 9.99);
            AddProduct("13- Sweets", "Maltesers", 39.99);
            AddProduct("13- Sweets", "M&M's", 39.99);
            AddProduct("13- Sweets", "Skittles", 29.99);
            AddProduct("14- Beauty Products", "Gliss Shampoo 600 ml", 99.99);
            AddProduct("14- Beauty Products", "Tresemme Curls Moisturuzing Shampoo 600 ml", 99.99);
            AddProduct("14- Beauty Products", "Herbal Essences Shampoo 600 ml", 89.99);
            AddProduct("14- Beauty Products", "Dove Shampoo 600 ml", 79.99);
            AddProduct("14- Beauty Products", "Palmolive Shampoo 600 ml", 84.99);
            AddProduct("14- Beauty Products", "Pantene Shampoo 600 ml", 119.99);
            AddProduct("14- Beauty Products", "Head & Shoulder Shampoo 600 ml", 94.99);
            AddProduct("14- Beauty Products", "Mink Shampoo 600 ml", 94.99);
            AddProduct("14- Beauty Products", "Clear 2 In 1 Shampoo + Conditioner 600 ml", 99.99);
            AddProduct("14- Beauty Products", "Gliss Conditioner 600 ml", 99.99);
            AddProduct("14- Beauty Products", "Tresemme Curls Moisturuzing Conditioner 600 ml", 99.99);
            AddProduct("14- Beauty Products", "Herbal Essences Conditioner 600 ml", 89.99);
            AddProduct("14- Beauty Products", "Dove Conditioner 600 ml", 79.99);
            AddProduct("14- Beauty Products", "Palmolive Conditioner 600 ml", 84.99);
            AddProduct("14- Beauty Products", "Pantene Conditioner 600 ml", 119.99);
            AddProduct("14- Beauty Products", "Mink Conditioner 600 ml", 94.99);
            AddProduct("14- Beauty Products", "Mink Hair Mask 600 ml", 79.99);
            AddProduct("14- Beauty Products", "Vatika Hair Mask 600 ml", 69.99);
            AddProduct("14- Beauty Products", "Eco Gel  5 Max Hold 600 ml", 89.99);
            AddProduct("14- Beauty Products", "Enliven Gel 5 Max Hold 600 ml", 89.99);
            AddProduct("14- Beauty Products", "Lady Speed Stick Women Deodrant", 199.99);
            AddProduct("14- Beauty Products", "Secret Women Deodrant", 184.99);
            AddProduct("14- Beauty Products", "Nivea Women Deodrant", 189.99);
            AddProduct("14- Beauty Products", "She Women Spray", 94.99);
            AddProduct("14- Beauty Products", "Old Spice Men Deodrant", 249.99);
            AddProduct("14- Beauty Products", "Gilette Men Deodrant", 219.99);
            AddProduct("14- Beauty Products", "Nivea Men Deodrant", 189.99);
            AddProduct("14- Beauty Products", "Axe Men Spray", 74.99);
            AddProduct("14- Beauty Products", "Ear Cotton Buds 50 Buds", 89.99);
            AddProduct("14- Beauty Products", "Close Up Toothpaste", 59.99);
            AddProduct("14- Beauty Products", "Signal Toothpaste", 54.99);
            AddProduct("14- Beauty Products", "Sensodyne Toothpaste", 74.99);
            AddProduct("14- Beauty Products", "Gilette Men Shavers Pack of 12", 149.99);
            AddProduct("14- Beauty Products", "Gilette Men After Shave", 189.99);
            AddProduct("14- Beauty Products", "Nivea Men After Shave", 174.99);
            AddProduct("14- Beauty Products", "Eva Hand Cream", 84.99);
            AddProduct("14- Beauty Products", "Kamill Hand Cream", 84.99);
            AddProduct("14- Beauty Products", "Garnier Makeup Remover", 109.99);
            AddProduct("14- Beauty Products", "Loreal Moisturizer Face Serum", 189.99);
            AddProduct("14- Beauty Products", "Kamena Shower Foam", 119.99);
            AddProduct("14- Beauty Products", "Chi Hair serum Anti Hair Fall", 199.99);
            AddProduct("14- Beauty Products", "Amla Hair Serum", 199.99);
            AddProduct("14- Beauty Products", "Dove Soap", 39.99);
            AddProduct("14- Beauty Products", "Pearl Soap", 99.99);
            AddProduct("14- Beauty Products", "Duru Soap", 19.99);
            AddProduct("14- Beauty Products", "Palmolive Soap", 21.99);
            AddProduct("14- Beauty Products", "Baby Johnson Wipes 100 Wipes", 99.99);
            AddProduct("14- Beauty Products", "Baby Johnson Baby Oil Lavender", 39.99);
            AddProduct("14- Beauty Products", "Vaseline Cream", 119.99);
            AddProduct("14- Beauty Products", "Vaseline Lip Balm", 39.99);
            AddProduct("15- Detergents", "Persil Gel 8 L", 239.99);
            AddProduct("15- Detergents", "Oxi Powder", 219.99);
            AddProduct("15- Detergents", "Fairy Dish Washer", 99.99);
            AddProduct("15- Detergents", "Prill Dish Washer", 89.99);
            AddProduct("15- Detergents", "Gif Dish Washer", 119.99);
            AddProduct("15- Detergents", "Clorox", 89.99);
            AddProduct("15- Detergents", "Clorel", 74.99);
            AddProduct("15- Detergents", "Frida Air Freshener", 39.99);
            AddProduct("15- Detergents", "Pledge", 69.99);
            AddProduct("15- Detergents", "Mr.Muscles Glass Cleaner", 59.99);
            AddProduct("15- Detergents", "Trash Bags Pack Of 30 Bags", 69.99);
            AddProduct("15- Detergents", "Fine Tissue 550 Tissues", 39.99);
            AddProduct("15- Detergents", "Zeina Tissue 550 Tissues", 34.99);
            AddProduct("15- Detergents", "Dettol Antiseptic", 187.99);
            AddProduct("15- Detergents", "Renol Antiseptic", 165.99);
            AddProduct("15- Detergents", "Comfort Laundry Freshener", 189.99);
            AddProduct("15- Detergents", "Downy Laundry Freshener", 179.99);
            AddProduct("15- Detergents", "Raid", 66.99);
            AddProduct("15- Detergents", "Baigon", 74.99);
            AddProduct("15- Detergents", "Byrosol", 34.99);


        }
        public Supermarket()
        {
            Categories = new LinkedList<Category>();
            Loaddata();
        }

        public void AddCategory(string name)
        {
            Categories.AddLast(new Category(name));
        }

        public void AddProduct(string categoryName, string productName, double price)
        {
            Category category = FindCategory(categoryName);
            if (category != null)
            {
                category.Products.AddLast(new Product(productName, price));
            }
            else
            {
                Console.WriteLine("Category " + categoryName + " does not exist");
            }
        }

        public Category FindCategory(string name)
        {
            foreach (Category category in Categories)
            {
                if (category.Name == name)
                {
                    return category;
                }
            }
            return null;
        }
        //Search method
        public Product FindProduct(int id, Category id2)
        {
            int i = 1;
            foreach (Product product in id2.Products)
            {
                if (i == id)
                    return product;
                else
                    i++;
            }
            return null;
        }


        public void PrintCategories()
        {
            foreach (Category category in Categories)
            {
                Console.WriteLine(category.Name);
            }
        }
        public int PrintProducts(string k)
        {
            int koko = 0;
            foreach (Category category in Categories)
            {
                //   Console.WriteLine(category.Name);
                if (category.Name == k)
                    foreach (Product product in category.Products)
                    {
                        koko++;
                        Console.Write(koko);
                        Console.WriteLine("  " + product.Name + " - " + product.Price + "LE");
                    }
            }
            return koko;
        } 
        public void PrintCart()
        {
            foreach (Category category in Categories)
            {
                Console.WriteLine("Your shopping cart:");
                foreach (Product product in category.Products)
                {
                    Console.WriteLine($"  * {product.Name} - ${product.Price}");
                }
            }
        }
    }
class UserData
{
   public string nm;
    public string pn;
    public string ad;
    public string pm;

    public UserData(string nm,string pn,string ad,string pm)
    {
        this.nm = nm;
        this.pn = pn;
        this.ad = ad;
        this.pm = pm;
    }
    public string UserName( string nm)
    {
      
            Console.WriteLine("Please Enter Your Name : ");
            nm = Console.ReadLine();
        
        return nm;
    }
    public string UserPhoneNumber(string pn)
    {
        
            Console.WriteLine("Please Enter Your Phone Number : ");
            pn = Console.ReadLine();
           
        return pn;
    }
    public string UserAddress(string ad)
    {

        
            Console.WriteLine("Please Enter Your Address : ");

            ad = Console.ReadLine();
         
        return ad;
    }
    public string UserPayment(string pm)
    {
        
        int vvv;
        Console.WriteLine("Please Enter The Payment Method Cash / Visa : ");
        do
        {

            vvv = 1;
            pm = Console.ReadLine();
            if ((pm != "cash" && pm != "Cash" && pm != "visa" && pm != "Visa"))
            {
                Console.WriteLine("Is not valid ");
                Console.WriteLine("Please Enter The Payment Method Cash / Visa : ");
                vvv = 0;
            }

        } while (vvv == 0);
        return pm;
    }

}
    class Program
    {

    [STAThread]

    static void Main(string[] args)
        {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        Supermarket supermarket = new Supermarket();
            LinkedList<Category> Categories = new LinkedList<Category>();
            LinkedList<Product> products = new LinkedList<Product>();
            Cart cart = new Cart();
            Console.WriteLine("Welcome TO DJS SuperMarket ! ");
            Console.WriteLine("");
            int kiko;
            string nm;
            do
            {
                kiko = 1;
                Console.WriteLine("Please Enter Your Name : ");
                nm = Console.ReadLine();
                if (nm.Length == 0) kiko = 0;
                else if (((nm[0] < 'A') || (nm[0] > 'Z')) && ((nm[0] < 'a') || (nm[0] > 'z')))
                { kiko = 0; Console.WriteLine("Ínvalid name: Name must start by a letter"); }
            } while (kiko == 0);

            int mimo, nana;
            string pn;
            do
            {
                Console.WriteLine("Please Enter Your Phone Number : ");
                pn = Console.ReadLine();
                mimo = pn.Length;
                if (mimo != 11) Console.WriteLine("Invalid phone number, phone number must be 11 digit");
                else
                {
                    for (nana = 0; nana < mimo; nana++)
                    {
                        if ((pn[nana] < '0') || (pn[nana] > '9'))
                        {
                            Console.WriteLine("Invalid phone number, phone number must be only digits");
                            // Console.WriteLine(pn[nana]);
                            mimo = 0;
                        }
                    }
                }
            } while (mimo != 11);
            int r;
            string ad;

            do
            {
                r = 1;
                Console.WriteLine("Please Enter Your Address : ");

                ad = Console.ReadLine();
                if (ad.Length == 0)
                {
                    r = 0;
                }

            } while (r == 0);


            string pm;
            int vvv;
            Console.WriteLine("Please Enter The Payment Method Cash / Visa : ");
            do
            {

                vvv = 1;
                pm = Console.ReadLine();
                if ((pm != "cash" && pm != "Cash" && pm != "visa" && pm != "Visa"))
                {
                    Console.WriteLine("Is not valid ");
                    Console.WriteLine("Please Enter The Payment Method Cash / Visa : ");
                    vvv = 0;
                }

            } while (vvv == 0);
            string ans = " ";
            int cartnum = 0;
            Console.WriteLine("Here Are Our Categories :  ");
            Console.WriteLine("");



            while (ans != "no")
            {
                int x;
                do
                {
                    supermarket.PrintCategories();
                    Console.WriteLine("Please choose a category:");
                    x = int.Parse(Console.ReadLine());
                    if ((x < 1) || (x > 15)) Console.WriteLine("Your selection is not a valid category number. Please try again:");
                } while ((x < 1) || (x > 15));
                int y = 1;
                string z = "  ";
                if (x == 1)
                    z = "1- Bakery";

                else if (x == 2)

                    z = "2- Beverages";


                else if (x == 3)


                    z = "3- Dairy";

                else if (x == 4)


                    z = "4- Canned Food";

                else if (x == 5)

                    z = "5- Frozen Food";

                else if (x == 6)

                    z = "6- Meat";



                else if (x == 7)

                    z = "7- Poultry";



                else if (x == 8)


                    z = "8- Seafood";

                else if (x == 9)

                    z = "9- Vegetables";

                else if (x == 10)


                    z = "10- Fruit";

                else if (x == 11)
                    z = "11- Groceries";

                else if (x == 12)
                    z = "12- Snacks";

                else if (x == 13)
                    z = "13- Sweets";

                else if (x == 14)
                    z = "14- Beauty Products";

                else if (x == 15)
                    z = "15- Detergents";

                else
                    Console.WriteLine("Category Not Found");


                int number_of_products = supermarket.PrintProducts(z);
                do
                {
                    Console.WriteLine("Please choose a product:");
                    y = int.Parse(Console.ReadLine());
                } while ((y < 1) || (y > number_of_products));
                Console.WriteLine("Please enter number of items you need:");
                int koki = int.Parse(Console.ReadLine());
                for (; koki > 0; koki--)
                    cart.addtoCart(supermarket.FindProduct(y, supermarket.FindCategory(z)));
                Console.WriteLine("Do you want to continue shopping? yes/no");
                ans = Console.ReadLine();
            }
            while (cartnum != 3)
            {
                Console.WriteLine("What do you want to do next?\n1- View Cart\n2- Remove from Cart\n3- Checkout");
                cartnum = int.Parse(Console.ReadLine());
                if (cartnum == 1)
                {
                    cart.SortProductsByPrice();
                    cart.MergethenPrintCart();
                    Console.WriteLine("your total is " + cart.total() + "LE");
                }
                else if (cartnum == 2)
                {
                    Console.WriteLine("Please choose a product from your cart that you wish to remove:");
                    cart.MergethenPrintCart();

                    int i = int.Parse(Console.ReadLine());
                    int j = 1;
                    foreach (Product product in cart.Products)
                    {
                        if (j == i)
                        {
                            cart.removefromCart(product);
                            break;
                        }
                        else
                            j++;
                    }

                }

            }
            Console.WriteLine("Your order has been placed successfully!");
            Console.WriteLine("Your total is " + cart.total() + "LE");
            Console.WriteLine("Your order will be delivered to you in 30 minutes.");
            Console.WriteLine("Thank you for shopping with us!");

            Console.ReadLine();
        }


    }


