using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Director : Worker
	{
		public Director()
		{
		}
		public Director(String name, String surname, int age, char sex, int oklad, int pooscher) : base(name, surname, age, sex, oklad)
		{
			this.pooscher = pooscher;
		}
		public void Print()
		{
			Console.Write("\n Имя: {0}\n Фамилия: {1}\n Возраст: {2}\n Пол: {3}\n Оклад: {4}\n Районный коэффициент: {5}\n Премия: {6}\n Поощерительные по результатам работы: {7}", name, surname, age, sex, oklad, rayKoef, prem, pooscher);
		}
		public int ZarPlat()
		{
			return (oklad + oklad * rayKoef / 100 + oklad * prem / 100 + oklad * pooscher / 100);
		}

		private int rayKoef = 15;
		private int prem = 20;
		private int pooscher;
	}
}
