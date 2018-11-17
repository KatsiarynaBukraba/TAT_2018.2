using System;

namespace Saturday_17._11._18
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(Point a, Point b, Point c) : base(a, b, c) { }

        public override double GetSquare()
        {
            var side1 = X.GetDistance(Y);
            var side2 = X.GetDistance(Z);
            var side3 = Y.GetDistance(Z);

            if (Math.Abs(side3 * side3 - side2 * side2 - side1 * side1) < double.Epsilon)
                return side2 * side1 / 2;
            else if (Math.Abs(side2 * side2 - side1 * side1 - side3 * side3) < double.Epsilon)
                return side1 * side3 / 2;
            else return side2 * side3 / 2;
        }
    }
}
