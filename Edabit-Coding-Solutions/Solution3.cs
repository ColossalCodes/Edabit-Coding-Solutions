using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Edabit_Coding_Solutions
{
    public class Solution3
    {
        int i = 123;

        public void RunSolution3()
        {
            string output = ReverseAndNot(123);
            Console.WriteLine("The Input was 123 So Answer should be 321123!\n\n" + output);
            Console.ReadLine();
        }
        public static string ReverseAndNot(int i)
        {
            string str = Convert.ToString(i);
            char[] charInput = str.ToCharArray();
            

            string outputStr = "";

            for (int t = str.Length-1; t >= 0; t--)//Cycling through the char array backwards 
            {
                outputStr = outputStr.Insert(outputStr.Length, (charInput[t]).ToString());
                
                //Put the last char of chars at the length of outputStr
            }

            outputStr = outputStr.Insert(outputStr.Length, (str));

            return outputStr;
        }
    }



    
    
}
