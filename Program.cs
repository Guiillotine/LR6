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
            Worker worker1 = new Worker("Иванов", "Иван", 60, 'М', 22000);
            Console.Write("\n РАБОТНИК 1:\n");
            worker1.Print(); Console.Write("\n");
            Worker worker2 = new Worker("Бучнев", "Алексей", 42, 'М', 20000);
            Console.Write("\n РАБОТНИК 2:\n");
            worker2.Print(); Console.Write("\n"); 

            Compare<Worker> A = new Compare<Worker>();
            Console.Write("\n Работник с большим окладом:\n");
            if (A.Max(worker1, worker2)) worker1.Print(); else worker2.Print();
            Console.Write("\n\n Работник с меньшим окладом:\n");
            if (A.Min(worker1, worker2)) worker1.Print(); else worker2.Print();

            Director director1 = new Director("Борисов", "Борис", 65, 'М', 90000, 40);
            Console.Write("\n\n ДИРЕКТОР ПРЕДПРИЯТИЯ 1:\n"); director1.Print(); Console.Write("\n");
            Director director2 = new Director("Сидоров", "Сергей", 40, 'М', 60000, 20);
            Console.Write("\n ДИРЕКТОР ПРЕДПРИЯТИЯ 2:\n"); director2.Print(); Console.Write("\n");

            Compare<Director> B = new Compare<Director>();
            Console.Write("\n Директор с большим окладом:\n");
            if (A.Max(director1, director2)) director1.Print(); else director2.Print();
            Console.Write("\n\n Директор с меньшим окладом:\n");
            if (A.Min(director1, director2)) director1.Print(); else director2.Print();

            Console.ReadKey();
        }
    }
}




