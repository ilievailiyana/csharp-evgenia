using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson8and9
{
    internal class exercise
    {
        public static void Run()
        {
            string[] cvetove = { "orange", "10", "black", "white" };

            Console.WriteLine(cvetove[2]);

            // imame poziciqta na elementa i ot poziciqta vzimame elementa
            for (int poziciq = 0; poziciq < cvetove.Length; poziciq++)
            {
                Console.WriteLine(cvetove[poziciq]);
            }

            cvetove[1] = "blue";

            // imame elementa na masiva
            foreach (string element in cvetove)
            {
                Console.WriteLine(element);
            }
        }

        public static void Run2()
        {
            // srednata ocenka na edin klas
            int[] ocenki = { 4, 3, 5, 2, 6, 5, 2, 5 };

            // kolko elementa ima v masiva
            int broiOcenki = ocenki.Length;

            // suma na ocenkite
            int sum = 0;

            foreach (int ocenka in ocenki)
            {
                sum += ocenka;
            }

            // sredna ocenka
            Console.WriteLine(sum/broiOcenki);

        }

        public static void Run3()
        {
            // Zima, Lqto, Esen ili Prolet - sprqmo temperatura koqto user-a vuvejda
            // Zima - pod 5 gradusa
            // Esen - mejdu 6 i 15 gradusa
            // Prolet - mejdy 16 i 22 gradusa
            // Lqto - nad 22 gradusa

            Console.WriteLine("Please enter a temperature: ");
            int temperatura = int.Parse(Console.ReadLine());

            // podredbata na if-ovete v sluchaq nqma znachenie zashtoto imame i dolna i gorna granica
            // ako imame samo dolna granica (bez AND) togava podredbata trqbva da e ot nai golqmo kum nai malko
            if (temperatura > 22)
            {
                Console.WriteLine("It's summer!");
            }
            else if (temperatura >= 16 && temperatura <= 22)
            {
                Console.WriteLine("It's spring!");
            }
            else if (temperatura >= 6 && temperatura < 16)
            {
                Console.WriteLine("It's autumn!");
            }
            else
            {
                Console.WriteLine("It's winter!");
            }
        }

        public static void Run4()
        {
            // prekratim programata ako user-a vuvede 'exit'

            while (true)
            {

                Console.WriteLine("Please enter a temperature: ");

                // int.Parse - smenq samo tipa na promenlivata ot string kum int ako e vuzmojno
                // string userInput = "22"
                // int temperatura = 22
                string userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int temperatura = int.Parse(userInput);
                
                if (temperatura > 22)
                {
                    Console.WriteLine("It's summer!");
                }
                else if (temperatura >= 16 && temperatura <= 22)
                {
                    Console.WriteLine("It's spring!");
                }
                else if (temperatura >= 6 && temperatura < 16)
                {
                    Console.WriteLine("It's autumn!");
                }
                else
                {
                    Console.WriteLine("It's winter!");
                }
            }
        }
    }
}
