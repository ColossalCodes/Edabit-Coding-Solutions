using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit_Coding_Solutions
{
    public class Solution2
    {
        public void RunSolution2()
        {
            long output;
            long output2;
            bool pass;

            do
            {
                pass = true;

                Console.Write("Please Input a number then an exponent to be calculated!\n\nNumber:");
                string input1 = Console.ReadLine();
                Console.Write("Exponent:");
                string input2 = Console.ReadLine();

                if (!long.TryParse(input1, out output)  )
                {
                    pass = false;
                    Console.WriteLine("The first number you typed in was invalid, try again!\n\nLoading...");
                    System.Threading.Thread.Sleep(5000);
                }
                
                if (!long.TryParse(input2, out output2))
                {
                    pass = false;
                    Console.WriteLine("The Second number you typed in was invalid, try again!\n\nLoading...");
                    System.Threading.Thread.Sleep(5000);
                }

                Console.Clear();

            } while (pass == false);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CalculateExponent(output,output2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

        }

        public static long CalculateExponent(long number, long exponent)
        {
            double input = number; //Implicit conversion
            double Power = exponent;

            return (long)Math.Pow(input, Power);
        }
    }
}
