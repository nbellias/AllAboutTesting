using AllAboutTesting.MathCalculations.Models;
using AllAboutTesting.MyClassLibrary;

namespace AllAboutTesting.SimpleNUnitTests
{
    public class ClassLibraryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MyClassLibraryTest1()
        {
            var side = 1;
            var squareArea = new Square(side).Area();
            Assert.That(squareArea, Is.EqualTo(Math.Pow(side, 2)));
        }

        [Test]
        public void MyClassLibraryTest2()
        {
            var side = 1;
            var squarePerimeter = new Square(side).Perimeter();
            Assert.That(squarePerimeter, Is.EqualTo(4 * side));
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void MyClassLibraryTest3(int value)
        {
            Assert.That(new PrimeNumber(value).IsPrime(), Is.EqualTo(true));
        }
    }
}
