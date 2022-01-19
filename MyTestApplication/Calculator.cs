using System;
using System.Collections.Generic;

namespace MyTestApplication
{
    public class Calculator
    {
		public int Operation(string inputedString, List<int> nums, char sing)
		{
			var operation = new Dictionary<char, Func<int, int, int>>
			{
				{'+',(firstValue, secondValue)=> firstValue+secondValue},
				{'-', (firstValue, secondValue)=> firstValue-secondValue},
				{'*', (firstValue, secondValue)=> firstValue*secondValue},
				{'/', (firstValue, secondValue)=> firstValue/secondValue}
			};
			var result = operation[sing](nums[0], nums[1]);
			return result;

		}
	}
}