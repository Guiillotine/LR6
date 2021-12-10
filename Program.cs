using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR6
{  
    class Program
    {
        public static int S(int a, int b) //Площадь
        {
            return (a * b);
        }
        public static int P(int a, int b) //Периметр
        {
            return ((a + b) * 2);
        }
        public delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Operation A = S;


            Console.ReadKey();
            //Food food = new Food();
            //food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
        }
    }

}




