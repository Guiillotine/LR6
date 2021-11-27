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
            Building building = new Building();
            Garage garage = new Garage();
            building.Set(60, 15, 8, 2);
            garage.Set(20, 10, 4, 1, 25);
            building.Print();
            garage.Print();
        }
    }
}




