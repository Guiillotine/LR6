using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace NongenericCollections
{
	namespace LR6
	{
		class Building : IComparable, IComparer
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
			public int Getheight()
			{
				return height;
			}
			public int Compare(Object o1, Object o2)  // сравнение 2 объектов
			{
				Building a = (Building)o1;
				Building b = (Building)o2;
				if ((a.GetFloorS() < b.GetFloorS())) return -1;
				else return 1;
			}
			public int CompareTo(Object x)
			{
				return Compare(this, x);
			}
			protected int length;
			protected int width;
			protected int height;
			protected int kolVoFloor;
		}
	}
}


