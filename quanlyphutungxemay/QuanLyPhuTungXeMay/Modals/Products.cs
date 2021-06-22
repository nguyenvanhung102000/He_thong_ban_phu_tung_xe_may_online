using System.Collections;
using System.Collections.Generic;
using System;
namespace QuanLyPhuTungXeMay
{
    class Products
    {
        public List<Product> products { get; set; }

        public void add()
        {
            int id_, amount_;
            string name_;
            float price_;

            Console.Write("Id ");
            id_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name ");
            name_ = Console.ReadLine();
            Console.Write("amount: ");
            amount_ = Convert.ToInt32(Console.ReadLine());
            Console.Write("price ");
            price_ = float.Parse(Console.ReadLine());
         
            bool exist = false;
            foreach (Product p in products)
            {
                if (p.id == id_)
                {
                    p.setName(name_);
                    p.setamount(amount_);
                    p.setprice(price_);
                }
                exist = true;
                break;
            }

            if (exist == false)
            {
                products.Add(new Product()
                {
                    id = id_,
                    name = name_,
                    amount = amount_,
                    price = price_
                });
            }



        }


        public void show()
        {
            foreach (Product p in products)
            {
                p.show();
            }
        }

        public void remove()
        {
            int id_;
            Console.Write("Id product need remove ");
            id_ = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            foreach (Product p in products)
            {
                if (p.id == id_)
                {
                    products.RemoveAt(i);
                    break;
                }
                i++;
            }
        }

        public void find()
        {
            int id_;
            Console.Write("Id product need find ");
            id_ = Convert.ToInt32(Console.ReadLine());
            foreach (Product p in products)
            {
                if (p.id == id_)
                {
                    p.show();
                    break;
                }
            }
        }

        public void pay()
        {
            float total = 0;
            foreach (Product p in products)
            {
                total += p.amount * p.price;
            }

            Console.WriteLine($"Total {total}");
        }
    }
}
