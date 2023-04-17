using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int prodCount = 0;
            Product[] prod = new Product[size];

            int choice = 0;

            while (choice != 4)
            {
                choice = choiceReturn();

                if (choice == 1)
                {
                    prod[prodCount] = addProducts();
                    prodCount++;
                }
                if (choice == 2)
                {
                    viewProducts(ref prod, ref prodCount);
                    Console.ReadKey();
                }
                if (choice == 3)
                {
                    viewStoreWorth(ref prod, ref prodCount);
                    Console.ReadKey();
                }
            }
        }

        static int choiceReturn()
        {
            Console.Clear();
            Console.WriteLine("1. Add A Product.");
            Console.WriteLine("2. View Products.");
            Console.WriteLine("3. View Store Worth.");
            Console.WriteLine("4. Exit.");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static Product addProducts()
        {
            Product product = new Product();

            Console.Clear();
            Console.Write("Enter name of Product: ");
            product.name = Console.ReadLine();
            Console.Write("Enter ID of Product: ");
            product.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of Student: ");
            product.price = float.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            product.category = Console.ReadLine();
            Console.Write("Enter Brand: ");
            product.brand = Console.ReadLine();
            Console.Write("Enter Country: ");
            product.country = Console.ReadLine();
            return product;
        }

        static void viewProducts(ref Product[] prod, ref int prodCount)
        {

            Console.Clear();
            for (int i = 0; i < prodCount; i++)
            {
                Console.WriteLine("Product Name: {0}", prod[i].name);
                Console.WriteLine("Product ID: {0}", prod[i].ID);
                Console.WriteLine("Product Price: {0}", prod[i].price);
                Console.WriteLine("Category: {0}", prod[i].category);
                Console.WriteLine("Brand: {0}", prod[i].brand);
                Console.WriteLine("Country: {0}", prod[i].country);
                Console.WriteLine();
            }
        }

        static void viewStoreWorth(ref Product[] prod, ref int prodCount)
        {
            float total = 0;
            Console.Clear();
            for(int i = 0;i < prodCount;i++)
            {
                total = total + prod[i].price;
            }
            Console.WriteLine("Total Worth: {0}", total);
        }
    }
}
