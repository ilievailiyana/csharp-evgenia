using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson1and2
{
    internal class ANDandOR
    {
        public static void Run()
        {
            // Logichesko i -> AND &
            
            // Age >= 14
            // Height >= 130

            int age = 20;
            int height = 120;

            // izpulneno X i Y

            if (age >= 14 && height >= 130)
            {
                Console.WriteLine("Mojesh da se kachish na vlakcheto!");
            }
            else
            {
                Console.WriteLine("Ne moje da se kachish");
            }

            // Logichesko ILI -> OR ||

            Console.WriteLine("Enter the current day of the week: ");
            string day = Console.ReadLine();

            if (day == "subota" || day == "nedelya")
            {
                Console.WriteLine("It's a weekend day!");
            }
            else
            {
                Console.WriteLine("It's not weekend.");
            }

            // Otstupka v magazin
            // Ako si student i imash karta za otstupka -> poluchavash namalenie
            // Ako si pensioner -> poluchavash namalenie

            bool isStudent = false;
            bool hasDiscountCard = true;
            bool isSenior = true;

            if ( isStudent && hasDiscountCard || isSenior)
            {
                Console.WriteLine("Poluchavash discount!");
            } else
            {
                Console.WriteLine("Nqma namalenie..");
            }
            


        }
    }
}
