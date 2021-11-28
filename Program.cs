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
            Food food = new Food();
            food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
            Garage a = new Garage(20, 10, 4, 1, 25);
            Garage b = new Garage(15, 15, 4, 1, 20);
            Console.Write("\n\n ГАРАЖ 1:"); a.Print();
            Console.Write("\n\n ГАРАЖ 2:"); b.Print();
            b = (Garage)a.Clone();
            b.Set(19, 9, 4, 1, 25);
            Console.Write("\n\n\n ГАРАЖ 1:"); a.Print();
            Console.Write("\n\n ГАРАЖ 2:"); b.Print();


            /*Cleaner cleaner = new Cleaner("Иванов", "Иван", 60, 'М', 20000);
            cleaner.Print();
            Console.Write("\n\n Зарплата уборщика: {0} р.\n\n", cleaner.ZarPlat());

            Admin admin = new Admin("Сидорова", "Ольга", 42, 'Ж', 25000);
            admin.Print();
            Console.Write("\n\n Зарплата администратора: {0} р.\n\n", admin.ZarPlat());

            Director director = new Director("Бучнев", "Алексей", 42, 'М', 60000, 60);
            director.Print();
            Console.Write("\n\n Зарплата директора: {0} р.\n\n", director.ZarPlat());

            Console.Write("\n");*/
            Console.ReadKey();
        }
    }
}




