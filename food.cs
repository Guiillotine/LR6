using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Food
    {
        public void Set(String name)
        {
            this.arr_food[kolVoKorm] = name;
            this.kolVoKorm++;
        }
        public void Set() //Функция инициализации элементов данных
        {
            Console.Write("\n Добавление нового корма\n");
            Console.Write("\n Введите название корма: ");
            arr_food[kolVoKorm] = Console.ReadLine();
            kolVoKorm++;
        }
        public int KolVoKorm_sp() //Возвращает количество кормов в списке
        {
            return (kolVoKorm);
        }
        public String Food_name(int k) //Возвращает название корма
        {
            return (arr_food[k]);
        }
        private String[] arr_food = new String[10];
        private int kolVoKorm = 0;
    }
}
