using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIT
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello on Branch");
            Console.WriteLine("Hello on feature2");
           
        }
    }
}
