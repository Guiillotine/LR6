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
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n Место № {0}\n Введите 1, чтобы обозначить, что место занято коровой\n 0 - если место свободно : ", i + 1); a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Cowshed cowshed = new Cowshed(a);
            cowshed.PrintZanyatMest();
            Console.ReadKey();
        }
    }
}

