using System;
using Saturday_17._11._18.Build;

namespace Saturday_17._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point A = new Point(0.0, 0.0);
                Point B = new Point(3.0, 0.0);
                Point C = new Point(0.0, 4.0);

                TriangleBuilder builder = new RightTriangleBuilder(new EquilateralTriangleBuilder(new RandomTriangleBuilder(null)));

                var triangle = builder.Build(A, B, C);
                Console.WriteLine(triangle.GetSquare());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
