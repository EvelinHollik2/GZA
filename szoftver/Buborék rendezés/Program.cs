using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborék_rendezés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            int max = 0;

            Console.WriteLine("0 vége az adatbevitelnek");

            do
            {
                Console.Write("Kérem a/az " + max + ". adatot:");
                tomb[max] = Convert.ToInt32(Console.ReadLine());
                max++;
            }
            while (tomb[max - 1] != 0);
            max--;

            Boolean voltcsere;
            int j;

            do
            {
                voltcsere = false;
                for (j = 0; j < max - 1; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int top = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = top;
                    }
                }
            }
            while (voltcsere);

            for (j = 0; j <= max; j++)
                Console.WriteLine(tomb[j]);

                Console.ReadKey();
            return;
        }
    }
}
