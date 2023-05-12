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
        [Test]
        public void Test2()
        {
            List<int> list = new List<int>() { 1, 7, -3, 4, 6 };
            List<int> reverse = Calculator.Reverse(list);
            List<int> reverseExpected = new List<int> { 6,4,-3,7,1};
            Assert.AreEqual(reverseExpected, reverse);
        }
    }
}