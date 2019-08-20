using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticalMean
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Vvedite pervoe chislo:");
			string chislo = Console.ReadLine();
			double firstValue = Convert.ToDouble(chislo);
			Console.WriteLine("Vvedite vtoroe chislo:");
			chislo = Console.ReadLine();
			double secondValue = Convert.ToDouble(chislo);
			Console.WriteLine("result = "+((firstValue+secondValue)/2));
			Console.ReadLine();
		}
	}
}
