using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
	class Compare<T> where T : Worker
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
			if (a < b) return (true);
			else return (false);
		}
	}
}
