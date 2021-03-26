using NUnit.Framework;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
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
            double s = Math_1.Formula(3, 4, 5);
            Assert.AreEqual(109.9, s, 0.1);

        }
        [Test]
        public void Test2()
        {
            double s = Math_1.Formula(3, 4, 5);
            Assert.Throws<System.ArgumentException>(() => {
                double S = Math_1.Formula(-3, 4, 5);
            });
        }
    }
}