using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Warehouse
    {
        public void AddKorm(Food spisKorm)
        {
            int num;
            Console.Write("\n Список кормов:\n");
            for (int i = 0; i < spisKorm.KolVoKorm_sp(); i++) Console.Write("\n {0}->{1}", i + 1, spisKorm.Food_name(i));
            Console.Write("\n Введите номер корма из списка для помещения его на склад: "); num = Convert.ToInt32(Console.ReadLine());
            KormSklad[kolVo] = spisKorm.Food_name(num - 1);
            Console.Write("\n Корм {0} помещён на склад.\n", spisKorm.Food_name(num - 1));
            kolVo++;
        }
        public static Warehouse operator +(Warehouse c1, Warehouse c2)
        {
            Warehouse temp = new Warehouse();
            for (int i = 0; i < c1.kolVo; i++) { temp.KormSklad[i] = c1.KormSklad[i]; temp.kolVo++; }
            for (int i = 0; i < c2.kolVo; i++) if (temp.kolVo < 100) { temp.KormSklad[i + c1.kolVo] = c2.KormSklad[i]; temp.kolVo++; }
            return (temp);
        }
        public void print()
        {
            for (int i = 0; i < kolVo; i++) Console.Write("\n {0}", KormSklad[i]);
        }

        private int kolVo = 0;
        private String[] KormSklad = new String[100];
    }
}