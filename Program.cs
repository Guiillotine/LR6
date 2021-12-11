using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace NongenericCollections
{
    namespace LR6
    {
        class Program
        {
            public static int findUsingIterator(int it, ArrayList BuildingList)
            {
                for (; it < BuildingList.Count; it++)
                {
                    Building tmp = (Building)BuildingList[it];
                    if (tmp.Getheight() >= 3 && tmp.Getheight() <= 6) return it;
                }
                return -1;
            }
            static void Main(string[] args)
            {
                Garage garage1 = new Garage(15, 15, 2, 1, 10), garage2 = new Garage(20, 25,3, 1, 20), garage3 = new Garage(20, 15, 3, 1, 15);
                Building building1 = new Building(50, 50, 6, 2), building2 = new Building(30, 45, 9, 3);
                ArrayList BuildingList = new ArrayList();
                BuildingList.Clear();
                BuildingList.Add(garage1); BuildingList.Add(building1);
                BuildingList.Add(garage2); BuildingList.Add(building2);
                BuildingList.Add(garage3);
                Console.Write("\n ПОИСК ЗДАНИЙ С ВЫСОТОЙ ОТ 3 ДО 6 М.\n\n ПОЛНЫЙ СПИСОК ЗДАНИЙ:\n");
                foreach (Building k in BuildingList)
                {
                    k.Print(); Console.Write("\n");
                }

                Console.Write("\n ПО ЗАПРОСУ НАЙДЕНО:\n");
                for (int i = 0; i < BuildingList.Count; i++)
                {
                    int a;
                    a = findUsingIterator(i, BuildingList);
                    if (a != -1)
                    {
                        Building tmp = (Building)BuildingList[a];
                        tmp.Print(); Console.Write("\n");
                        i = a;
                    }
                }

                Console.ReadKey();

                //Food food = new Food();
                //food.Add("Силос"); food.Add("Комбикорм"); food.Add("Солома"); food.Add("Свёкла");
            }
        }

    }
}




