using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson3and4
{
    internal class ArrayTask
    {
        public static void Run()
        {
            int number = 5;

            // index - poziciq na elementa v masiva
            // index-ite zapochvat ot 0
            int[] masiv = { 5, 10, 15, 3, 6, 4 , 5 };
            Console.WriteLine(masiv[0]);

            string[] words = { "orange", "cherry" };

            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[4] = 100;
            Console.WriteLine(numbers[1]);

            numbers[1] = 22;
            Console.WriteLine(numbers[1]);

            // vzimame posledniq element ot masiva
            Console.WriteLine(numbers[numbers.Length - 1]);

            // int i = index/poziciq/chislo ot koeto zapochvame 
            // i < numbers.Length - dokoga da se izpulnqva for loop-a 
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
        
    }
}
