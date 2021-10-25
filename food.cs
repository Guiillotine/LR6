using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Food
    {
        public void Set(String name)
        {
            this.arr_food[num] = name;
            this.num++;
        }
        public void Set() //Функция инициализации элементов данных
        {
            Console.Write("\n Добавление нового корма\n");
            Console.Write("\n Введите название корма: ");
            arr_food[num] = Console.ReadLine();
            num++;
        }
        public int Num_sp() //Возвращает количество кормов в списке
        {
            return (num);
        }
        public String Food_name(int k) //Возвращает название корма
        {
            return (arr_food[k]);
        }
        private String[] arr_food = new String[10];
        private int num = 0;
    }
}
