using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class FizzBuzz
	{
		public string processNumber(int i)
		{
			if (i == 3)
				return "Fizz";

			return i.ToString();
		}
	}
}
