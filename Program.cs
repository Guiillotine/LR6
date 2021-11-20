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
            list_cow.Add(food);
            Console.ReadKey();
        }
    }
}

