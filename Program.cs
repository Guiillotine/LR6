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
            List_cow list_cow = new List_cow(); Food food = new Food();
            food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
            for (int i = 0; i < 2; i++) list_cow.Add(food);
            list_cow.PrintArrKorovnik();
            Console.Write("\n Информация о корове, находящейся в стоиле во 2 ряду на 3 месте:\n");
            list_cow.GetCow(2, 3).Print_cow();
            Console.ReadKey();
        }
    }
}

