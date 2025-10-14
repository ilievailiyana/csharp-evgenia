using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson6and7
{
    internal class SaveAndReadFromFile
    {
        public static void Run()
        {
            // Da se zapishat chislata ot 1 do 20 vuv file i sled tova da se printirat samo kratnite na 3
            string filename = "numbers.txt";
            // File-a se zapazva v papkata kudeto ti e proekta primer:
            // Urok6/bin/Debug/net8.0/numbers.txt

            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 1; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }

            using (StreamReader reader = new StreamReader(filename))
            {
                Console.WriteLine("Vsichki chisla kratni na 3: ");
                string line;
                // dokato ima sledvasht red vuv file-a toest dokato reda e razlichen ot null
                while ((line = reader.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    if (num % 3 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }




        }
    }
}
