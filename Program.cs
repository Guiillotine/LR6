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
            //Food food = new Food();
            //food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
            Cleaner cleaner1 = new Cleaner("Иванов", "Иван", 60, 'М', 22000);
            Console.Write("\n РАБОТНИК 1:\n");
            cleaner1.Print(); Console.Write("\n");
            Cleaner cleaner2 = new Cleaner("Бучнев", "Алексей", 42, 'М', 20000);
            Console.Write("\n РАБОТНИК 2:\n");
            cleaner2.Print(); Console.Write("\n");

            Compare<Cleaner> A = new Compare<Cleaner>();
            Console.Write("\n Работник с наибольшим окладом:\n");
            if (A.Max(cleaner1, cleaner2)) cleaner1.Print(); else cleaner2.Print();
            Console.Write("\n\n Работник с наименьшим окладом:\n");
            //if (A.Min(cleaner1, cleaner2)) cleaner1.Print(); else cleaner2.Print();

            Garage garage1 = new Garage(20, 15, 3, 1, 15);
            Console.Write("\n\n\n ГАРАЖ 1:\n");
            garage1.Print();
            Garage garage2 = new Garage(25, 20, 3, 1, 20);
            Console.Write("\n\n ГАРАЖ 2:\n");
            garage2.Print(); Console.Write("\n");
            //Compare<Garage> B;
            Console.Write("\n Гараж с наибольшей площадью:\n");
            //B.Max(garage1, garage2).Print();
            Console.Write("\n\n Гараж с наименьшей площадью:\n");
            //B.Min(garage1, garage2).Print();
            Console.Write("\n");




            /*Garage a = new Garage(20, 10, 4, 1, 25);
            Garage b = new Garage(15, 15, 4, 1, 20);
            Console.Write("\n\n ГАРАЖ 1:"); a.Print();
            Console.Write("\n\n ГАРАЖ 2:"); b.Print();
            b = (Garage)a.Clone();
            b.Set(19, 9, 4, 1, 25);
            Console.Write("\n\n\n ГАРАЖ 1:"); a.Print();
            Console.Write("\n\n ГАРАЖ 2:"); b.Print();*/

            Console.ReadKey();
        }
    }
}




