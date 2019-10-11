using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var serviceCollection = new ServiceCollection();
			var buildServiceProvider = serviceCollection
				.AddSingleton<IFizzBuzz, FizzBuzz>()
				.BuildServiceProvider();
			var processNumber = buildServiceProvider.GetService<IFizzBuzz>().ProcessNumber(1);

			Console.WriteLine("Hello World!" + processNumber);
			Console.ReadLine();
		}
	}
}
