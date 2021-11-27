using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class List_cow
    {
        public List_cow()
        {
            kolVoKorov = 0;
            illCow = 3;
            MeatCow = 4;
            Cow cow = new Cow();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                {
                    cow.Set("0", "0", 0, 0, 0);
                    arr_Korovnik[i,j] = cow;
                }
        }
        public List_cow(int illCow)
        {
            this.illCow = illCow;
            kolVoKorov = 0;
            MeatCow = 4;
        }
        public List_cow(int kolVoKorov, string name, string breed, int age, double weight, int nadoi)
        {
            this.kolVoKorov = 0;
            for (int i = 0; i < kolVoKorov; i++)
            {
                Cow cow = new Cow(name, breed, age, weight, nadoi);
            if (this.kolVoKorov > 0) this.ArrResize();
            arr_cow[i] = cow;
            this.kolVoKorov++;
        }
    }
    public void ArrResize() //Функция увеличения размера массива
        {
            Cow[] arr_cow2 = new Cow[kolVoKorov + 1];
            for (int i = 0; i < kolVoKorov; i++) arr_cow2[i] = arr_cow[i];
            arr_cow = arr_cow2;
        }
        public void Add(Food food1) //Функция инициализации элементов данных
        {
            if (kolVoKorov > 0) this.ArrResize();
            Cow cow = new Cow();
            cow.Set(food1);
           //cow2.Set_udder();
            arr_cow[kolVoKorov] = cow;
            /*int x, y;
            Console.Write("\n Введите номер ряда стоила коровы: "); x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Введите номер места стоила коровы: "); y = Convert.ToInt32(Console.ReadLine());
            x = x - 1;
            y = y - 1;
            arr_Korovnik[x,y] = cow;*/
            kolVoKorov++;
        }
        public void PrintArrKorovnik()
        {
            Console.Write("\n     План расположения коров в стойлах:\n _________________________________________\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" | ");
                    if (arr_Korovnik[i,j].GetName() == "0") Console.Write(" --- ");
                    else Console.Write("{0}",arr_Korovnik[i,j].GetName());
                }
                Console.Write(" |\n");
            }
            Console.Write(" _________________________________________\n");
        }
        public Cow GetCow(int x, int y)
        {
            x = x - 1;
            y = y - 1;
            return arr_Korovnik[x,y];
        }
        public void Print_list()
        {
            for (int i = 0; i < kolVoKorov; i++)
            {
                Console.Write("\n № {0}", i + 1);
                arr_cow[i].Print_cow();
                //arr_cow[i].Print_udder();
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
        public int GetIllCow()
        {
            return illCow;
        }

        private int kolVoKorov;
        private int illCow;
        private int MeatCow;
        private Cow[,] arr_Korovnik = new Cow[3,5];
        private Cow[] arr_cow = new Cow[1];
    }
}
