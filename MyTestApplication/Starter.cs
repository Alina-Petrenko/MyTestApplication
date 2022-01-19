using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApplication
{
	public static class Starter
	{
		public static void GetStart()
		{
			string inputedString = string.Empty;
			Calculator calculator = new Calculator();
			while (inputedString != "exit")
			{
				Console.WriteLine($"Please, write your expression. If you want to exit, please write 'exit'\n");
				try
				{
					inputedString = Console.ReadLine().Replace("=", "");
					if (inputedString.ToLower() == "exit")
						break;

					//Parse a string into two values ​​and an action
					var nums = Parser(inputedString, out char sing);

					int result = calculator.Operation(inputedString,nums,sing);
					Console.WriteLine($"{inputedString} = {result}\n");
				}
				catch
				{
					Console.WriteLine($"Wrong expression! Try it again!\n");

				}
			}

		}
		private static List<int> Parser(string inputedString, out char sing)
		{

			char[] operations = { '+', '-', '/', '*' };
			//Set default value for sing
			sing = '+';
			var splitedString = inputedString.Split(operations);
			var nums = splitedString.Select(int.Parse).ToList();

			//Search for the desired character
			for (int i = 0; i < operations.Length; i++)
			{
				if (inputedString.Contains(operations[i]))
				{
					sing = operations[i];
				}
			}
			return nums;
		}
	}
}