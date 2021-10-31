using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class List_cow
    {
        public void ArrResize() //Функция увеличения размера массива
        {
            Cow[] arr_cow2 = new Cow[kolVoKorov + 1];
            for (int i = 0; i < kolVoKorov; i++) arr_cow2[i] = arr_cow[i];
            arr_cow = arr_cow2;
        }
        public void Add(Food food1) //Функция инициализации элементов данных
        {
            if (kolVoKorov > 0) this.ArrResize();
            Cow cow2 = new Cow();
            cow2.Set(food1);
            cow2.Set_udder();
            arr_cow[kolVoKorov] = cow2;
            kolVoKorov++;
        }
        public void Print_list()
        {
            for (int i = 0; i < kolVoKorov; i++)
            {
                Console.Write("\n № {0}", i + 1);
                arr_cow[i].Print_cow();
                arr_cow[i].Print_udder();
            }
        }
        public int KolVoKorov_sp() //Возвращает количество коров в списке
        {
            return (kolVoKorov);
        }
        public void Herd(int n) //Создание стада на n коров
        {
            for (int i = 0; i < n; i++)
            {
                if (kolVoKorov > 0) this.ArrResize();
                Cow cow2 = new Cow();
                cow2.Set("Корова " + Convert.ToString(i + 1), "Черно-пестрая", 4, 450, 15);
                cow2.Set_udder(0.39, 0.43, 0.47, 0.56);
                arr_cow[i] = cow2;
                kolVoKorov++;
            }
        }
        public double VolumeUdderC(int n)
        {
            return (arr_cow[n-1].VolumeUdderB(n));
        }

        public void CountIllCow(ref int illCow)
        {
            illCow = 0;
            illCow += this.illCow;
        }
        public void CountMeatCow(out int MeatCow)
        {
            MeatCow = 0;
            MeatCow += this.MeatCow;
        }


        private int kolVoKorov = 0;
        private int illCow = 3;
        private int MeatCow = 5;
        private Cow[] arr_cow = new Cow[1];
    }
}
