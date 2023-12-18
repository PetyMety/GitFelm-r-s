using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFelmérés
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<int> szamok = new List<int>();
            Console.WriteLine("Adjon meg számokat (0 végjelig):");
			int bekertSzam;

			do
			{
				bekertSzam = Convert.ToInt32(Console.ReadLine());

				szamok.Add(bekertSzam);


                Console.WriteLine("Beírt számok: " + string.Join(", ", szamok));

            } while (bekertSzam != 0);


			

			if (szamok.Count > 1)
			{
				int max = szamok.Max();
				Console.WriteLine("Maximum " + max);
			}

			if (szamok.Count > 1)
			{
				int min = szamok.Min();
				Console.WriteLine("Minimum " + min);
			}

			Console.ReadLine();
		}
	}
}
