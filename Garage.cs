using System;
using System.Collections;
using System.Linq;
using System.Text;
namespace NongenericCollections
{
	namespace LR6
	{
		class Garage : Building, ICloneable
		{
			public Garage()
			{
				kolVoCars = 15;
			}
			public Garage(int length, int width, int height, int kolVoFloor, int kolVoCars) : base(length, width, height, kolVoFloor)
			{
				this.kolVoCars = kolVoCars;
			}
			public object Clone()
			{
				return new Garage(length, width, height, kolVoFloor, kolVoCars);
			}

			public override string ToString()
			{
				string s = "";
				s += " Длина: " + Convert.ToString(length) + " Ширина: " + Convert.ToString(width) + " Высота: " + Convert.ToString(height) + " Кол.Этажей: " + Convert.ToString(kolVoFloor) + " Кол.Машиномест: " + Convert.ToString(kolVoCars);
				return s;
			}
			public void Set(int length, int width, int height, int kolVoFloor, int kolVoCars)
			{
				base.Set(length, width, height, kolVoFloor);
				this.kolVoCars = kolVoCars;
			}
			public void Print()
			{
				Console.Write("\n Длина гаража: {0}\n Ширина гаража: {1}\n Высота гаража: {2}\n Количество этажей: {3}\n Количество машиномест: {4}", length, width, height, kolVoFloor, kolVoCars);
			}
			private int kolVoCars;
		}
	}
}
