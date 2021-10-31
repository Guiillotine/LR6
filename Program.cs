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
            Food food = new Food(); List_cow list_cow1 = new List_cow(), list_cow2 = new List_cow();
            Warehouse warehouse1 = new Warehouse(), warehouse2 = new Warehouse(), warehouse3 = new Warehouse();
            Cowshed cowshed1 = new Cowshed(), cowshed2 = new Cowshed();
            int a, b, c;
            int n1 = 0, n2 = 0;

            cowshed2.Set(100,24,6);
            cowshed1 = cowshed2;
            Console.Write("\n КОРОВНИК 1:");
            cowshed1.Print();
            Console.Write("\n\n КОРОВНИК 2:");
            cowshed2.Print();
            cowshed2.Length = 150;
            Console.Write("\n\n*Длина коровника 2 изменена*\n\n КОРОВНИК 1:");
            cowshed1.Print();
            Console.Write("\n\n КОРОВНИК 2:");
            cowshed2.Print();


            list_cow1.CountIllCow(ref n1); Console.Write("\n Количество больных коров в списке 1 = {0}", n1);
            list_cow1.CountMeatCow(out n2); Console.Write("\n\n Количество мясных коров в списке 1 = {0}", n2);

            food.Set("Комбикорм"); food.Set("Сено"); food.Set("Свёкла"); food.Set("Солома");
            food.Set();
            for (int i = 0; i < 2; i++) list_cow1.Add(food);
            list_cow1.Print_list();


            list_cow2.Herd(6); //Создание стада на 6 коров
            list_cow2.Print_list();

            Console.Write("\n Объем вымени для коровы № 1 списка 1: " + list_cow1.VolumeUdderC(1));
            Console.ReadKey();

            //Демонстрация свойств
            /*cowshed1.Length = 100; cowshed1.Width = 24; cowshed1.Height = 6;
            Console.Write("\n Параметры коровника:\n");
            cowshed1.Print();
            a = cowshed1.Length; b = cowshed1.Width; c = cowshed1.Height;
            Console.Write("\n\n a = {0}\n b = {1}\n c = {2}", a, b, c);*/

            //Демонстрация перегрузки оператора '+'
            /*Console.Write("\n\n ДОБАВЛЕНИЕ КОРМОВ НА СКЛАД 1:");
            warehouse1.AddKorm(food); warehouse1.AddKorm(food);
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 1: "); warehouse1.print();
            Console.Write("\n\n ДОБАВЛЕНИЕ КОРМОВ НА СКЛАД 2:");
            warehouse2.AddKorm(food);
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 2: "); warehouse2.print();
            warehouse3 = warehouse1 + warehouse2;
            Console.Write("\n\n СОДЕРЖИМОЕ СКЛАДА 3:");
            warehouse3.print();*/

            //Демонстрация перегрузки оператора '++'
            /*Console.Write("\n\n Коровник 1 до префиксного инкремента: "); cowshed1.Print();
            cowshed2 = ++cowshed1;
            Console.Write("\n\n Коровник 1 после префиксного инкремента: "); cowshed1.Print();
            Console.Write("\n\n Коровник 2: "); cowshed2.Print();

            Console.Write("\n\n Коровник 1 до постфиксного инкремента: "); cowshed1.Print();
            cowshed2 = cowshed1++;
            Console.Write("\n\n Коровник 1 после постфиксного инкремента: "); cowshed1.Print();
            Console.Write("\n\n Коровник 2: "); cowshed2.Print();*/


        }
    }
}








