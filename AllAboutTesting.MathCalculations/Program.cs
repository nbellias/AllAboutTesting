using AllAboutTesting.MathCalculations.Models;

namespace AllAboutTesting.MathCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circleRadius = 4.3;

            Console.WriteLine($"The area of a circle with radius {circleRadius} is {new Circle(circleRadius).Area()}");
            Console.WriteLine($"The circumference of a circle with radius {circleRadius} is {new Circle(circleRadius).Circumference()}");
        }
    }
}