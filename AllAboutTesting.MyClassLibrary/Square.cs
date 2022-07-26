namespace AllAboutTesting.MyClassLibrary
{
    public class Square
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double Area()
        {
            return Math.Pow(Side, 2);
        }

        public double Perimeter()
        {
            return 4 * Side;
        }
    }
}