using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Cleaner : Worker, IWorker
	{
		public Cleaner()
		{
		}
		public Cleaner(String name, String surname, int age, char sex, int oklad) : base(name, surname, age, sex, oklad)
		{
		}
		public void Print()
		{
			Console.Write("\n Имя: {0}\n Фамилия: {1}\n Возраст: {2}\n Пол: {3}\n Оклад: {4}\n Районный коэффициент: {5}\n Премия: {6}", name, surname, age, sex, oklad, rayKoef, prem);			
		}
		public int ZarPlat()
		{
			return (oklad + oklad * rayKoef / 100 + oklad * prem / 100);
		}
		public void PrintZarPlat()
		{
			Console.Write("\n Зарплата уборщика составляет: {0} р.", ZarPlat());
		}
		private int rayKoef = 15;
		private int prem = 20;
	}
}
