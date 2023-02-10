using NUnit.Framework;
using ConsoleApp4;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add1To2AndReturn3()
        {
            var result = Summer.Sum(1, 2);

            Assert.AreEqual(3, result, "1 + 2 != 3");
        }

        [Test]
        public void Add2To3AndReturn5()
        {
            var result = Summer.Sum(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}