using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Food food = new Food(); List_cow list_cow1 = new List_cow(), list_cow2 = new List_cow();
            //Warehouse warehouse1 = new Warehouse(), warehouse2 = new Warehouse(), warehouse3 = new Warehouse();

            List_cow list_cow1 = new List_cow();
            List_cow list_cow2 = new List_cow(7);
            Console.Write("\n Количество больных коров на ферме = {0}", list_cow2.GetIllCow());
            Console.Write("\n");
            List_cow list_cow3 = new List_cow(1, "Бурёнка", "Черно-пёстрая", 6, 450, 6);
            list_cow3.Print_list();

            /*Cowshed cowshed1 = new Cowshed();
            Console.Write("\n Количество коровников на ферме: {0}\n", Cowshed.GetKolVo());

            Cowshed cowshed2 = new Cowshed(), cowshed3 = new Cowshed();
            Console.Write("\n *Добавлено два коровника*\n");
            Console.Write("\n Количество коровников на ферме: {0}\n", Cowshed.GetKolVo());

            food.Set("Комбикорм"); food.Set("Сено"); food.Set("Свёкла"); food.Set("Солома");
            for (int i = 0; i < 2; i++) list_cow1.Add(food);
            list_cow1.Print_list();*/

            Console.ReadKey();
        }
    }
}

