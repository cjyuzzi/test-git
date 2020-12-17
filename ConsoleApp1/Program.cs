using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			var maxJobClass = string.Empty;

            int jobClass1, jobClass2;
			if (int.TryParse("1", out jobClass1))
			{
				if (!string.IsNullOrWhiteSpace("D"))
				{
					if (int.TryParse("D", out jobClass2))
						maxJobClass = jobClass1 >= jobClass2 ? jobClass1.ToString() : jobClass2.ToString();
				}
				else
					maxJobClass = jobClass1.ToString();
			}

			Console.WriteLine(maxJobClass);
        }
    }
}
