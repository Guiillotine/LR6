using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Cowshed
    {
        public void Set(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public void Print()
        {
            Console.Write("\n Длина коровника: {0}\n Ширина коровника: {1}\n Высота коровника: {2}", length, width, height);
        }
        /*public Cowshed& operator ++()
        {
            this->length++;
            return *this;
        }
        public Cowshed& operator ++(int value)
        {
            Cowshed temp = *this;
            this->length++;
            return temp;
        }*/

        /*public static Cowshed operator ++(Cowshed c1)
        {
            return new Cowshed { Value = c1.Value + 10 };
        }*/

        private int length = 500;
        private int width = 500;
        private int height = 3;
    }
}
