using System;
using System.Collections.Generic;
using ListaDeProdutos.Entities;

namespace ListaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> listProduct = new List<Product>();

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used ou imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(typeOfProduct == 'c' || typeOfProduct == 'C')
                {
                    listProduct.Add(new Product(name, price));
                }

                else if(typeOfProduct == 'u' || typeOfProduct == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manDate = DateTime.Parse(Console.ReadLine());

                    listProduct.Add(new UsedProduct(name, price, manDate));
                }

                else if (typeOfProduct == 'i' || typeOfProduct == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());

                    listProduct.Add(new ImportedProduct(name, price, customFee));
                }
            }

            Console.WriteLine();
            foreach(Product p in listProduct)
            {
                Console.WriteLine(p);
            }
        }
    }
}
