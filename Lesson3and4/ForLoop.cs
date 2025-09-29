using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson3and4
{
    internal class ForLoop
    {
        public static void Run()
        {
            Console.WriteLine(10);
            Console.WriteLine(11);
            Console.WriteLine(12);
            Console.WriteLine(13);
            Console.WriteLine(14);
            Console.WriteLine(15);
            Console.WriteLine();


            for (int chislo = 10; chislo <= 15; chislo++)
            {
                Console.WriteLine(chislo);
            }

            string[] fruits = { "orange", "apple", "pineapple" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            int[] chisla = { 5, 6, 7, 2 };
            int suma = 0;
            foreach (int i in chisla)
            {
                Console.WriteLine(i);
                suma = suma + i;
            }
            Console.WriteLine($"Suma: {suma}");


        }
    }
}
