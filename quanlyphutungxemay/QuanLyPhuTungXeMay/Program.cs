using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace QuanLyPhuTungXeMay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Process();
        }

        public static void showMenu()
        {
            Console.WriteLine("----Hệ Thống Quản Lý Shop Phụ Tùng Xe Máy ----");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Xem sản phẩm ");
            Console.WriteLine("3. Xóa sản phẩm");
            Console.WriteLine("4. Tính tiền và in bill");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }


        public static void Process()
        {
            var data = Helper<Products>.ReadFile("data.json");
            int option = 0;
            showMenu();
            Console.Write("Lua chon ");
            option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            do
            {
                switch (option)
                {
                    case 1:
                        data.add();
                        Console.WriteLine();
                        break;
                    case 2:
                        data.show();
                        Console.WriteLine();
                        break;
                    case 3:
                        data.remove();
                        Console.WriteLine();
                        break;
                    case 4:
                        data.pay();
                        Console.WriteLine();
                        Helper<Products>.WriteFile("bill.json", data);

                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        break;
                }
                if (flag == true)
                {
                    showMenu();
                    option = Convert.ToInt32(Console.ReadLine());
                }
            } while (flag == true);

        }
    }
}
