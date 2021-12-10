using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Building
	{
		public Building()
		{
			length = 50;
			width = 50;
			height = 6;
			kolVoFloor = 2;
		}
		public Building(int length, int width, int height, int kolVoFloor)
		{
			this.length = length;
			this.width = width;
			this.height = height;
			this.kolVoFloor = kolVoFloor;
		}
		public override string ToString()
		{
			string s = "";
			s += " Длина: " + Convert.ToString(length) + " Ширина: " + Convert.ToString(width) + " Высота: " + Convert.ToString(height) + " Кол.Этажей: " + Convert.ToString(kolVoFloor);
			return s;
		}

		public void Set(int length, int width, int height, int kolVoFloor)
		{
			this.length = length;
			this.width = width;
			this.height = height;
			this.kolVoFloor = kolVoFloor;
		}
		public void Print()
		{
			Console.Write("\n Длина здания: {0}\n Ширина здания: {1}\n Высота здания: {2}\n Количество этажей: {3}", length, width, height, kolVoFloor);
		}
		public int GetFloorS()
		{
			return length * width;
		}
		public int GetLength()
		{
			return length;
		}
		public int GetWidth()
		{
			return width;
		}
		protected int length;
		protected int width;
		protected int height;
		protected int kolVoFloor;
	}
}
