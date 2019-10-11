using System.Collections.Generic;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ShouldProcessInput_1()
		{
			Assert.AreEqual("1", new FizzBuzz().ProcessNumber(1));
		}

		[TestMethod]
		public void ShouldProcessInput_2()
		{
			Assert.AreEqual("2", new FizzBuzz().ProcessNumber(2));
		}

		[TestMethod]
		public void ShouldProcessInput_3()
		{
			Assert.AreEqual("Fizz", new FizzBuzz().ProcessNumber(3));
		}

		[TestMethod]
		public void ShouldProcessInput_5()
		{
			Assert.AreEqual("Buzz", new FizzBuzz().ProcessNumber(5));
		}

		[TestMethod]
		public void ShouldProcessInput_6()
		{
			Assert.AreEqual("Fizz", new FizzBuzz().ProcessNumber(6));
		}

		[TestMethod]
		public void ShouldProcessInput_10()
		{
			Assert.AreEqual("Buzz", new FizzBuzz().ProcessNumber(10));
		}

		[TestMethod]
		public void ShouldProcessInput_15()
		{
			Assert.AreEqual("FizzBuzz", new FizzBuzz().ProcessNumber(15));
		}

		[TestMethod]
		public void ShouldProcessInput_30()
		{
			Assert.AreEqual("FizzBuzz", new FizzBuzz().ProcessNumber(30));
		}

		[TestMethod]
		public void ShouldProcessFizzBuzzCorrectly()
		{
			var input = new List<int>()
			{
				1, 2, 3, 5, 6, 10, 15, 30
			};

			var result = new FizzBuzz().Execute(input);

			var expected = new List<string>()
			{
				"1", "2", "Fizz", "Buzz", "Fizz", "Buzz", "FizzBuzz", "FizzBuzz"
			};

			CollectionAssert.AreEqual(result, expected);

		}
	}
}