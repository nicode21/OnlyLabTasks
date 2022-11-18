using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_Delegates.Models
{
    public class Product
    {
        public delegate bool PriceChecker(double price);
        public delegate double DiscountChecker(double price);


        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        public int Id { get; set; }
        public static int SId { get; set; }

        public Product(string name,double price,bool isDeleted)
        {
            Name= name;
            Price=price;
            IsDeleted=isDeleted;
            SId++;
            Id=SId;
        }

        public static bool CheckPrice(double price)
        {
            return price>500;
        }

        public static double GetDiscount(double price)
        {
            return price*0.7;
        }

        public static void GetProduct( PriceChecker func1 , DiscountChecker func2 , List<Product> list)
        {
            foreach (var item in list)
            {
                if (item.IsDeleted==false)
                {
                    if (func1(item.Price))
                    {
                        Console.WriteLine($"{item.Id} -----{item.Name} -- {item.Price} manata YOX {func2(item.Price)} manata elde ede bilersiniz. -- Stokdan silinibmi : {item.IsDeleted}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Id} -- {item.Name} -- {item.Price} -- {item.IsDeleted}");
                    }
                }
                else
                {
                    Console.WriteLine($"{item.Id} de olan mehsul Stokda qalmayıb");
                }
            }
        }


    }
}
