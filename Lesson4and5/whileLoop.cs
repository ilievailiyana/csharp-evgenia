using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson4and5
{
    internal class whileLoop
    {
        public static void Run()
        {
            //while (uslovie)
            //{
                //kod koito se izpulnqva dokato uslovieto e vqrno(uslovieto = True)
            //}
            Console.WriteLine("Printirame chislata ot 5 do 25: ");
            int count = 5;
            while (count <= 25)
            {
                Console.WriteLine("Count: " + count);
                count++; // vinagi uvelichavame count-a w kraq na loop-a inache stava bezkraen cikul
                //count = count + 1;
            }

            for (int i = 5; i <= 25; i++)
            {
                Console.WriteLine(i);
            }

            // Nova zadacha

            //kogato imame while (true), trqbva zaduljitelno da prekratim loop - a s BREAK inache stava bezkraen cikul
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber == 0)
                {
                    Console.WriteLine("Prekratqvame programata.");
                    break; // vednaga spira loop-a i produljavame ako ima kod sled loop-a 
                }
                // nqmame else, zashtoto ako chisloto userNumber e 0, nie shte sme prekratili zaradi break-a
                Console.WriteLine(userNumber);

            }
            Console.WriteLine("Sled loop-a");

            // Nova zadacha

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number to add to sum: ");
                int userNumber = int.Parse(Console.ReadLine());
                if (userNumber == 0)
                {
                    Console.WriteLine("Prekratqvame programata.");
                    Console.WriteLine("Natrupana suma do momenta: " + sum);
                    break; // vednaga spira loop-a i produljavame ako ima kod sled loop-a 
                }
                // nqmame else, zashtoto ako chisloto userNumber e 0, nie shte sme prekratili zaradi break-a
                sum = sum + userNumber;

            }
            

        }
    }
}
