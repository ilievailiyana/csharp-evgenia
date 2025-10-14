using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson6and7
{
    internal class biggestNumber
    {
        public static void Run()
        {
            int num1 = 20;
            int num2 = 15;
            int num3 = 10;
            int num4 = 30;

            int maxNumber = -1;

            if (num1 > maxNumber)
            {
                Console.WriteLine($"maxNumber se smeni ot {maxNumber} na {num1}");
                maxNumber = num1;
            }
            if (num2 > maxNumber)
            {
                Console.WriteLine($"maxNumber se smeni ot {maxNumber} na {num2}");
                maxNumber = num2;
            }
            if (num3 > maxNumber)
            {
                Console.WriteLine($"maxNumber se smeni ot {maxNumber} na {num3}");
                maxNumber = num3;
            }
            if (num4 > maxNumber)
            {
                Console.WriteLine($"maxNumber se smeni ot {maxNumber} na {num4}");
                maxNumber = num4;
            }
            Console.WriteLine($"Nai-golqmoto chislo e: {maxNumber}");

        }

        public static void Run2()
        {
            int[] numbers = { 10, 15, 20, 30, 40, 45, 50, 40 };
            int maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    Console.WriteLine($"maxNumber se smeni ot {maxNumber} na {numbers[i]}");
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine($"Nai-golqmoto chislo e: {maxNumber}");
        }
    }
}
