using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Cowshed
    {
        public Cowshed()
        {
            KolVoCowshed++;
        }
        public void Set(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int Length
        {
            get { return length; }
            set { if ((value > 0) && (value < 510)) length = value; else if (value < 0) length = 0; else if (value > 500) length = 500; }
        }
        public int Width
        {
            get { return width; }
            set { if ((value > 0) && (value < 510)) width = value; else if (value < 0) width = 0; else if (value > 500) width = 500; }
        }
        public int Height
        {
            get { return height; }
            set { if ((value > 0) && (value <= 3)) height = value; else if (value < 0) height = 0; else if (value > 3) height = 3; }
        }

        public void Print()
        {
            Console.Write("\n Длина коровника: {0}\n Ширина коровника: {1}\n Высота коровника: {2}", length, width, height);
        }
        public static Cowshed operator ++(Cowshed c1)
        {
            return new Cowshed { length = c1.length + 1};
        }
        public static int GetKolVo()
        {
            return KolVoCowshed;
        }
        private static int KolVoCowshed = 0;
        private int length = 500;
        private int width = 500;
        private int height = 3;
    }
}


