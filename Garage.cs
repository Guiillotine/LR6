using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Garage : Building
	{
		public Garage()
		{
			kolVoCars = 15;
		}
		public Garage(int length, int width, int height, int kolVoFloor, int kolVoCars) : base(length, width, height, kolVoFloor)
		{
			this.kolVoCars = kolVoCars;
		}
		public void Set(int length, int width, int height, int kolVoFloor, int kolVoCars)
		{
			base.Set(length, width, height, kolVoFloor);
			this.kolVoCars = kolVoCars;
		}
		public void Print()
		{
			Console.Write("\n Длина здания: {0}\n Ширина здания: {1}\n Высота здания: {2}\n Количество этажей: {3}\n Количество машиномест: {4}", length, width, height, kolVoFloor, kolVoCars);
		}
		private int kolVoCars;
	}
}
