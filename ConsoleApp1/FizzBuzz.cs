using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class FizzBuzz
	{
		public string processNumber(int i)
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
	}
}
