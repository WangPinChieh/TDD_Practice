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
			Assert.AreEqual("1", new FizzBuzz().processNumber(1));
		}

		[TestMethod]
		public void ShouldProcessInput_2()
		{
			Assert.AreEqual("2", new FizzBuzz().processNumber(2));
		}

		[TestMethod]
		public void ShouldProcessInput_3()
		{
			Assert.AreEqual("Fizz", new FizzBuzz().processNumber(3));
		}

		[TestMethod]
		public void ShouldProcessInput_5()
		{
			Assert.AreEqual("Buzz", new FizzBuzz().processNumber(5));
		}

		[TestMethod]
		public void ShouldProcessInput_6()
		{
			Assert.AreEqual("Fizz", new FizzBuzz().processNumber(6));
		}

		[TestMethod]
		public void ShouldProcessInput_10()
		{
			Assert.AreEqual("Buzz", new FizzBuzz().processNumber(10));
		}

		[TestMethod]
		public void ShouldProcessInput_15()
		{
			Assert.AreEqual("FizzBuzz", new FizzBuzz().processNumber(15));
		}

		[TestMethod]
		public void ShouldProcessInput_30()
		{
			Assert.AreEqual("FizzBuzz", new FizzBuzz().processNumber(30));
		}
	}
}