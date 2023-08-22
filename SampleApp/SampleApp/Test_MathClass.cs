using NUnit.Framework; //Import NUnit framework

namespace SampleApp
{
    class Test_MathClass
    {
        [TestFixture] //TestFixture indicate class contain unit tests
        class TestCase
        {
            MathClass math; //declare an object

            [SetUp]
            public void SetUp()
            {
                math = new MathClass(); //create a object
            }

            [Test] //Indicate test method
            public void Add()
            {
                Assert.AreEqual(50, math.Add(45, 5));
            }

            [Test]
            public void Sub()
            {
                Assert.AreEqual(10, math.Subtract(20, 10));
            }

            [Test]
            public void Mul()
            {
                Assert.AreEqual(75, math.Multiple(15, 5));
            }

            [Test]
            public void Div()
            {
                Assert.AreEqual(10, math.Division(50, 5));
            }
        }
    }
}
