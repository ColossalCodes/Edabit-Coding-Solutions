	using System;
	using System.Globalization;
 public class Solution1
{
	public void RunSolution1()
	{
		//Just the UI and running of this solution

		Console.WriteLine("Please input any letters and the output will reverse the case of the letters\n");
		Console.Write("input:");
		string output = ReverseCase(Console.ReadLine());
		Console.Write("\nOutput:");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(output);
		Console.ForegroundColor = ConsoleColor.White;
		Console.ReadLine();
	}

	public static string ReverseCase(string str)
	{
		char[] letters = str.ToCharArray();
		string output = "";//Word to be outputted

		foreach (char c in letters)//loop through the chars from the array
		{
			bool check;
			check = char.IsUpper(c);//Checks the Char to see if it is Uppercase

            switch (check)//Switch will flip the case of the char around
			{
				case true:
					output = output.Insert(output.Length, char.ToLower(c).ToString());
					break;
				case false:
					output = output.Insert(output.Length, char.ToUpper(c).ToString());
					break;
				default:
					break;
			}
		}
		return output;//output
	}
}
