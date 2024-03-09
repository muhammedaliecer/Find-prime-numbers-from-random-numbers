using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_onuncu_odev
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Random rnd = new Random();
			int[] sayilar = new int[rnd.Next(1, 50)];

			for (int i = 0; i < sayilar.Length; i++)
			{
				sayilar[i] = rnd.Next(2, 200);
				Console.Write(sayilar[i] + ",");
			}
			Console.WriteLine();
			Console.WriteLine("{0} adet sayı oluşturuldu", sayilar.Length);
            Console.WriteLine();
            Console.WriteLine("*************************");

            int asalSayiSayisi = 0;

			for (int i = 0; i < sayilar.Length; i++)
			{
				int sayac = 0;
				for (int j = 2; j < sayilar[i]; j++)
				{
					if (sayilar[i] % j == 0)
					{
						sayac++;
						break;
					}
				}

				if (sayac == 0)
				{
					asalSayiSayisi++;
					Console.WriteLine(sayilar[i]);
				}
			}
            Console.WriteLine();
            Console.WriteLine("Bu sayılardan {0} tanesi asal sayıdır.", asalSayiSayisi);




			Console.ReadKey();
		}
	}
}
