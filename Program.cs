using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.Write("enter number");

			int a = Convert.ToInt32(Console.ReadLine());

			Console.Write("enter number");

			int b = Convert.ToInt32(Console.ReadLine());

			if (a > b)
			{
				// a is bigger
				Console.WriteLine(a);

			}
			else
			{
				// b is bigger
				Console.WriteLine(b);
			}
		}
	}
}
