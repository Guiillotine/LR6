using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Cow
    {
        public void Set(String name, String breed, int age, double weight, int nadoi)
        {
            if (name != " ") this.name = name;
            if (breed != " ") this.breed = breed;
            if (age != 0) this.age = age;
            if (weight != 0) this.weight = weight;
            if (nadoi != 0) this.nadoi = nadoi;
        }


        public void Set(Food spisKorm) //Функция инициализации элементов данных
        {
            int a;
            Console.Write("\n Добавление новой коровы \n");

            Console.Write("\n Введите кличку коровы: ");
            name = Console.ReadLine();

            Console.Write("\n Введите породу коровы: ");
            breed = Console.ReadLine();

            Console.Write("\n Выберите корм для коровы: ");
            for (int i = 0; i < spisKorm.KolVoKorm_sp(); i++)
            {
                Console.Write("\n {0} -> {1}", (i + 1), spisKorm.Food_name(i));
            }
            Console.Write("\n ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < spisKorm.KolVoKorm_sp(); i++)
                if ((i + 1) == a) food = spisKorm.Food_name(i);

            Console.Write("\n\n Введите возраст коровы (лет): ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Введите вес коровы (кг): ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Введите надой коровы (л/сут): ");
            nadoi = Convert.ToInt32(Console.ReadLine());
        }
        public void Print_cow() //Вывод на экран информации об одной корове
        {
            Console.Write("\n ИМЯ: {0}\n ПОРОДА: {1}\n КОРМ: {2}\n ВОЗРАСТ(лет): {3}\n ВЕС(кг): {4}\n НАДОЙ(л/день): {5}\n", name, breed, food, age, weight, nadoi);
        }
        public void Set_udder()
        {
            udder.Set_udder();
        }
        public void Set_udder(double length, double width, double girth, double depth)
        {
            udder.set_udder(length, width, girth, depth);
        }
        public double VolumeUdderB(int n)
        {
            return (udder.VolumeUdderA(n));
        }
        public void Print_udder()
        {
            udder.Print_udder();
        }
        private class Udder
        {
            public double length = 0.39;//длина
            public double width = 0.43; //ширина
            public double girth = 0.47; //обхват
            public double depth = 0.56; //глубина
            public void set_udder(double length, double width, double girth, double depth)
            {
                this.length = length;
                this.width = width;
                this.girth = girth;
                this.depth = depth;
            }
            public void Set_udder() //Заполнение полей из консоли
            {
                Console.Write("\n Заполнение параметров вымени коровы\n");
                Console.Write("\n Введите длину вымени (м): "); length = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Введите ширину вымени (м): "); width = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Введите обхват вымени (м): "); girth = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Введите глубину вымени (м): "); depth = Convert.ToDouble(Console.ReadLine());
            }
            public double VolumeUdderA(int n) //Возвращает значение объёма вымени
            {
                return (length * width * depth);
            }
            public void Print_udder() //Печать параметров вымени для коровы
            {
                Console.Write("\n Параметры вымени для этой коровы:\n ДЛИНА: {0} М\n ШИРИНА: {1} М\n ОБХВАТ: {2} М\n ГЛУБИНА: {3} M\n", length, width, girth, depth);
            }
        }
        private Udder udder = new Udder();
        private String name = "Буренка";
        private String breed = "Черно-пестрая"; //порода
        private String food = "Сено";
        private int age = 4;
        private double weight = 400;
        private int nadoi = 15; //Надой
    }
}
