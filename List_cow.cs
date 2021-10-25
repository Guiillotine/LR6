using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class List_cow
    {
        public void Arr_inc() //Функция увеличения размера массива
        {
            Cow[] arr_cow2 = new Cow[num + 1];
            for (int i = 0; i < num; i++) arr_cow2[i] = arr_cow[i];
            arr_cow = arr_cow2;
        }
        public void Add(Food food1) //Функция инициализации элементов данных
        {
            if (num > 0) this.Arr_inc();
            Cow cow2 = new Cow();
            cow2.Set(food1);
            cow2.Set_udder();
            arr_cow[num] = cow2;
            num++; //Количество коров в списке
        }
        public void Print_list()
        {
            Cow cow2;
            for (int i = 0; i < num; i++)
            {
                Console.Write("\n № {0}", i + 1);
                arr_cow[i].Print_cow();
                arr_cow[i].Print_udder();
            }
        }
        public int Num_sp() //Возвращает количество коров в списке
        {
            return (num);
        }
        public void Herd(int n) //Создание стада на n коров
        {
            for (int i = 0; i < n; i++)
            {
                if (num > 0) this.Arr_inc();
                Cow cow2 = new Cow();
                cow2.Set("Корова " + Convert.ToString(i + 1), "Черно-пестрая", 4, 450, 15);
                cow2.Set_udder(0.39, 0.43, 0.47, 0.56);
                arr_cow[i] = cow2;
                num++;
            }
        }
        public double Volume_udder_c(int n)
        {
            return (arr_cow[n-1].Volume_udder_b(n));
        }

        private int num = 0;
        private Cow[] arr_cow = new Cow[1];
    }
}
