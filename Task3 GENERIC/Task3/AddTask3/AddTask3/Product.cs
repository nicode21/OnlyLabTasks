using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask3
{
    public class Product
    {
        public int Id { get; set; }
        public static int SId { get; set; }
        public string Name { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public bool IsDeleted { get; set; }


        public Product(string name,int count,double price,bool isDeleted)
        {
            Name = name;
            Count = count;
            Price =price;
            IsDeleted=isDeleted;
            Id++;

            SId++;
            Id = SId;
        }

    }
}
