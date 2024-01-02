
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace jo
{
    class Program
    {
        
        static void Main(string[] args)
        {
          
            // Change the background color to blue
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear(); // Clear the console to apply the new background color
            Console.ResetColor();
            Console.Write("current date and time is :");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

          
            // Keep the console window open

            Supermarket supermarket = new Supermarket();
            LinkedList<Category> Categories = new LinkedList<Category>();
            LinkedList<Product> products = new LinkedList<Product>();
            Cart cart = new Cart();
            Console.WriteLine("Welcome TO DJS Market ! ");
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

}