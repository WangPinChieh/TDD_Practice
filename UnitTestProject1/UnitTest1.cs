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
	}
}
