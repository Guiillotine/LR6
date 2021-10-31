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
            Cow cow = new Cow(); Food food = new Food(); List_cow list_cow1 = new List_cow();
            List_cow list_cow2 = new List_cow();//Для стада коров
            Warehouse warehouse1 = new Warehouse(), warehouse2 = new Warehouse(), warehouse3 = new Warehouse();
            cow.Set_udder(0.41, 0.42, 0.43, 0.44); //Заполнение параметров вымени внутри кода
            food.Set("Комбикорм"); food.Set("Сено"); food.Set("Свёкла"); food.Set("Солома");

            Console.Write("\n\n ДОБАВЛЕНИЕ КОРМОВ НА СКЛАД 1:");
            warehouse1.AddKorm(food); warehouse1.AddKorm(food);
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 1: "); warehouse1.print();
            Console.Write("\n\n ДОБАВЛЕНИЕ КОРМОВ НА СКЛАД 2:");
            warehouse2.AddKorm(food);
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 2: "); warehouse2.print();
            warehouse3 = warehouse1 + warehouse2;
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 3:");
            warehouse3.print();


            food.Set();
            for (int i = 0; i < 3; i++)
            {
                list_cow1.Add(food);
                list_cow1.Print_list();
            }

            list_cow2.Herd(6); //Создание стада на 6 коров
            list_cow2.Print_list();

            Console.Write("\n Объем вымени для коровы № 1 списка 1: " + list_cow1.VolumeUdderC(1));
            Console.ReadKey();
        }
    }
}








