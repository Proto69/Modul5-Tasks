using ConsoleApp4;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class TestingSum
    {
        [Test]
        public void Adding5And10AndReturn15()
        {
            var sum = Summer.Sum(5, 10);
            Assert.AreEqual(15, sum);
        }
    }
}
