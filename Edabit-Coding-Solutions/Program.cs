using System;

namespace Edabit_Coding_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {

            bool pass;

            do
            {
                Console.Write("Please choose a soloution you would like to run\n\nCheck the project readme file for details on each solution!" +
                "\nSolution1 = 1\nSolution2 = 2\n\nInput:");

                string input = Console.ReadLine();

                pass = true;

            
                if (input == "1")
                {
                    pass = true;
                    var solution1 = new Solution1();//Instantiate My class for Solution1
                    solution1.RunSolution1(); //Calls a Method from the Solution1 class
                }
                else if (input == "2")
                {
                    pass = true;
                    var solution2 = new Solution2();//Instantiate My class for Solution2
                    solution2.RunSolution2();//Calls a Method from the Solution2 class
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    pass = false;
                    Console.ReadLine();
                }

                Console.Clear();
            } while (pass == false);
            
            
           

        }
    }
}
