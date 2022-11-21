using System;
using System.Collections.Generic;
using Task4_Delegates.Models;
using static Task4_Delegates.Models.Product;
using static Task4_Delegates.Services.ListController;

namespace Task4_Delegates
{
    class Program
    {
        public static List<Product> list = new List<Product>();
        static void Main(string[] args)
        {
            Product prod1 = new Product("iphone", 2000,false);
            Product prod2 = new Product("Asus", 3000,true);
            Product prod3 = new Product("Samsung", 1800,false);
            Product prod4 = new Product("Monster", 4000,true);
            Product prod5 = new Product("Nokia", 200,false);
            Product prod6 = new Product("Mercedes", 100000,false);


            list.Add(prod1);
            list.Add(prod2);
            list.Add(prod3);
            list.Add(prod4);
            list.Add(prod5);
            list.Add(prod6);

            
                Console.WriteLine("Melumatlari gormek isteyirsinizse  -- 1");
                Console.WriteLine("Product elave etmek isteyirsinizse  -- 2");
                Console.WriteLine("Productu silmek isteyirsinizse  -- 3   Duymesine basin)");

                int option = int.Parse(Console.ReadLine());

            
                if (option <= 3)
                {
                    if (option == 1)
                    {
                        ShowAllProducts();
                    }
                    if (option == 2)
                    {
                        Add();
                    }
                    if (option == 3)
                    {
                        Remove();
                    }
                }
                else
                {
                    Console.WriteLine("Elimizde 3 secim var.Zehmet olmasa seciminizi duzgun edin.");
                }
            
                
            
                
            
        }
        public static void ShowAllProducts()
        {
            GetProduct(CheckPrice, GetDiscount, list);
        }

        public static void Add()
        {
            Console.WriteLine("Productun adini yazin :");
            string name = Console.ReadLine();

            Console.WriteLine("Productunuzun qiymetini yazin : ");
            double price = double.Parse(Console.ReadLine());


            Product product = new Product(name, price, false);

            list.Add(product);

        }

        public static void Remove()
        {

            Console.WriteLine("Silmek istediyiniz productun ID sini yazin");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in list)
            {
                if (item.Id == id)
                {

                    list.Remove(item);
                    item.IsDeleted = true;
                    break;
                }
            }
        }
    }
}
