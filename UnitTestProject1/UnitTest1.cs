using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ShouldProcessInput()
		{
			var processNumber = new FizzBuzz().processNumber(1);
			Assert.AreEqual("1", processNumber);

		}
	}
}
