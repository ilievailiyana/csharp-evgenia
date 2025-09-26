using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson1and2
{
    internal class Lesson1
    {
        public static void Run()
        {
            Console.WriteLine("Hello");

            // promenliva - zapazvame stoinost s koqto da rabotim i koqto mojem da promenqme
            int number;
            number = 1;
            Console.WriteLine(number);
            number = 5;
            Console.WriteLine(number);
            int otherNumber = 10;
            Console.WriteLine(number / otherNumber);

            double myDouble = 3.14233;

            char myChar = 'A';
            string myString = "hello";

            Console.WriteLine(10);
            Console.WriteLine(myString);
            Console.WriteLine("hello");

            Console.WriteLine("Hi" + number);
            Console.WriteLine($"Hi {number}");

            bool myBool = true;
            bool myOtherBool = false;
        }
    }
}
