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
            Building building = new Building(60, 15, 8, 2);
            Garage garage = new Garage(20, 10, 4, 1, 25);
            Console.Write("\n");
            Console.WriteLine(building);
            Console.Write("\n");
            Console.WriteLine(garage);
            //building.Print();
            //Console.Write("\n");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}




