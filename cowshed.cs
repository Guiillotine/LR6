using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	public Cowshed()
	{
	public void Set(int length, int width, int height)
	{
		this->length = length;
		this->width = width;
		this->height = height;
	}
	public void Print()
	{
		cout << "\n Длина коровника:" << length << "\n Ширина коровника:" << width << "\n Высота коровника:" << height;
	}
	public Cowshed& operator ++()
	{
		this->length++;
		return *this;
	}
	public Cowshed& operator ++(int value)
	{
		Cowshed temp = *this;
		this->length++;
		return temp;
	}
	private int length = 500;
	private int width = 500;
	private int height = 3;
}
}
