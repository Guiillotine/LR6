using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Admin : Worker
	{
		public Admin()
		{
		}
		public Admin(String name, String surname, int age, char sex, int oklad) : base(name, surname, age, sex, oklad)
		{
		}
		public void Print()
		{
			Console.Write("\n Имя: {0}\n Фамилия: {1}\n Возраст: {2}\n Пол: {3}\n Оклад: {4}\n Районный коэффициент: {5}\n Премия: {6}\n Надбавка за квалификацию: {7}", name, surname, age, sex, oklad, rayKoef, prem, kvalPrem);
		}
		public int ZarPlat()
		{
			return (oklad + oklad * rayKoef / 100 + oklad * prem / 100 + oklad * kvalPrem / 100);
		}

		private int rayKoef = 15;
		private int prem = 20;
		private int kvalPrem = 25;
	}
}
