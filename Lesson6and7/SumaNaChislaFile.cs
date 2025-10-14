using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson6and7
{
    internal class SumaNaChislaFile
    {
        public static void Run()
        {
            // Da se zapishat vuv file chislata ot 10 do 100 no prez 10 t.e. 10, 20, 30, ... 
            // Da se nameri sumata na chislata ot file-a i da se printira tazi suma

            string filename = "numbers.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 10; i <= 100; i += 10)
                {
                    writer.WriteLine(i);
                }
            }

            int totalSum = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    totalSum += num;
                }
            }
            Console.WriteLine($"Suma na chislata: {totalSum}");

        }
    }
}
