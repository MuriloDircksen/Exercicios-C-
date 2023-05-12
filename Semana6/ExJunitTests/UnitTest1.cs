using ExJunit;
namespace ExJunitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<int> list = new List<int>() { 1,2,-3,4,6};
            int sum = Calculator.Sum(list);
            int sumExpected = 10;
            Assert.AreEqual(sumExpected, sum);
        }
    }
}