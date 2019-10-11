using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class FizzBuzz
	{
		public string ProcessNumber(int i)
		{
			var result = string.Empty;
			if (i % 3 == 0)
				result += "Fizz";
			if (i % 5 == 0)
				result += "Buzz";
			if (string.IsNullOrEmpty(result))
				result += i.ToString();

			return result;
		}

		public List<string> Execute(List<int> input)
		{
			var result = new List<string>();
			foreach (var v in input)
			{
				result.Add(ProcessNumber(v));
			}

			return result;
		}
	}
}
