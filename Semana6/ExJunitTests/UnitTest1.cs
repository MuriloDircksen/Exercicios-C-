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
        [Test]
        public void Test3()
        {
            List<int> list = new List<int>() { 1, 7, -3, 4, 6 };
            List<int> order = Calculator.Order(list);
            List<int> orderExpected = new List<int> { -3, 1, 4, 6, 7 };
            Assert.AreEqual(orderExpected, order);
        }
    }
}