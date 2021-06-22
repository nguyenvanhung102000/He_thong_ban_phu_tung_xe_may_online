using System;
using System.Collections.Generic;
namespace QuanLyPhuTungXeMay
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public float price { get; set; }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setamount(int amount)
        {
            this.amount = amount;
        }
        public void setprice(float price)
        {
            this.price = price;
        }
        public void show()
        {
            Console.WriteLine($"Id\t{id}");
            Console.WriteLine($"Name\t{name}");
            Console.WriteLine($"Amount\t{amount}");
            Console.WriteLine($"Price\t{price}");
            Console.WriteLine();
        }

    }
}
