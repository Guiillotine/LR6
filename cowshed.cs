using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Cowshed
    {
        /*public void Set(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }*/

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Print()
        {
            Console.Write("\n Длина коровника: {0}\n Ширина коровника: {1}\n Высота коровника: {2}", length, width, height);
        }

        public static Cowshed operator ++(Cowshed c1)
        {
            return new Cowshed { length = c1.length + 1};
        }

        private int length = 500;
        private int width = 500;
        private int height = 3;
    }
}
