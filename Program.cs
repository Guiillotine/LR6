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
            Garage garage = new Garage(20,25,4,1,15);
            int a;
            Operation Z;
            garage.Print();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n\n 1->Узнать площадь гаража\n 2->Узнать периметр гаража\n ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) { Z = S; Console.Write("\n Площадь гаража = "); }
                else { Z = P; Console.Write("\n Периметр гаража = "); }
                Console.Write("{0}", Z(garage.GetLength(), garage.GetWidth()));
            }

            Console.ReadKey();

            //Food food = new Food();
            //food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
        }
    }

}




