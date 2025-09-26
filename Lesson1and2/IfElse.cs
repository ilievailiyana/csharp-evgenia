using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evgenia.Lesson1and2
{
    internal class IfElse
    {
        public static void Run()
        {
            // User-a vuvejda ocenka i nie trqbva da printirame imeto na ocenka 
            // 6 -> otlichen
            // 5 -> mnogo dobur

            Console.WriteLine("Molya vuvedi ocenka (2 - 6): ");
            //string input = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());

            if (score >= 5.5)
            {
                Console.WriteLine("Otlichen");
            }
            else if (score >= 4.5)
            {
                Console.WriteLine("Mnogo dobur");
            }
            else if (score >= 3.5)
            {
                Console.WriteLine("Dobur");
            }
            else if (score >= 2.5)
            {
                Console.WriteLine("Sreden");
            }
            else
            {
                Console.WriteLine("Slab");
            }
        }
        public static void Run3()
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is 0.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public static void Run2()
        {
            //"hello" -> ?
            
            Console.WriteLine("Enter your age: ");
            string input = Console.ReadLine();


            //bool result = age >= 18;

            int age;
            if (int.TryParse(input, out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You can vote!");
                }
                else
                {
                    Console.WriteLine("Not yet!");
                }
            } 
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }


    }
}
