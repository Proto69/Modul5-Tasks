using NUnit.Framework;
using ConsoleApp4;

namespace ConsoleApp5
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Adding1And2Gives3()
        {
            //Arrange
            Summer summer = new();

            //Act
            int result = Summer.Sum(1, 2);

            //Assert
            Assert.AreEqual(3, result, "1 + 2 != 3");
        }   
    }
}