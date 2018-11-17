using System;

namespace Saturday_17._11._18
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point a, Point b, Point c) : base(a, b, c) { }

        public override double GetSquare()
        {
            var side = X.GetDistance(Y);

            return Math.Sqrt(3) / 4 * side * side;
        }
    }
}
