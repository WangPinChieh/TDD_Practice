using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class FizzBuzz
	{
		public string processNumber(int i)
		{
			if (i % 3 == 0)
				return "Fizz";
			if (i % 5 == 0)
				return "Buzz";
			return i.ToString();
		}
	}
}
