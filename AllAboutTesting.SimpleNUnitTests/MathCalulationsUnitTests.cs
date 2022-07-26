using AllAboutTesting.MathCalculations.Models;
using AllAboutTesting.MyClassLibrary;
using AllAboutTesting.MyWebAPI.Models;


namespace AllAboutTesting.SimpleNUnitTests
{
    public class MathCalculationsTests
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MathCalculationsTest1()
        {
            var radius = 1;
            var circleArea = new Circle(radius).Area();
            Assert.That(circleArea, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
        }

        [Test]
        public void MathCalculationsTest2()
        {
            var radius = 1;
            var circleArea = new Circle(radius).Circumference();
            Assert.That(circleArea, Is.EqualTo(2 * Math.PI * radius));
        }
        
    }
}