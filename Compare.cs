using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Compare<T> where T : Worker  //IComparable<T> //public class TemplateTest<T> where T : int
	{
	public Compare()
		{

		}
	public bool Max(T a, T b)
		{
			if (a > b) return (true);
			else return (false);
		}
	public bool Min(T a, T b)
		{
			/*if (a.CompareTo(b) < 0) return (true);
			else*/ return (false);
		}
	}
}
