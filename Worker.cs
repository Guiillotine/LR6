﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    abstract class Worker
    {
		public Worker()
		{
		}
		public Worker(String name, String surname, int age, char sex, int oklad)
		{
			this.name = name;
			this.surname = surname;
			this.age = age;
			this.sex = sex;
			this.oklad = oklad;
		}
		public void Print()
		{
			Console.Write("\n Имя: {0}\n Фамилия: {1}\n Возраст: {2}\n Пол: {3}\n Оклад: {4}", name, surname, age, sex, oklad);
		}
		public abstract int ZarPlat();

		protected String name;
		protected String surname;
		protected int age;
		protected char sex;
		protected int oklad;
	}
}
