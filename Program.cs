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
            cow.Set_udder(0.41, 0.42, 0.43, 0.44); //Заполнение параметров вымени внутри кода
            food.Set("Комбикорм"); food.Set("Сено");
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
