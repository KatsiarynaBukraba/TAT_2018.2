using System;

namespace Saturday_17._11._18
{
    public class RandomTriangle : Triangle
    {
        public RandomTriangle(Point a, Point b, Point c) : base(a, b, c) { }

        public override double GetSquare()
        {
            var side1 = X.GetDistance(Y);
            var side2 = X.GetDistance(Z);
            var side3 = Y.GetDistance(Z);

            var halfPerimeter = (side1 + side2 + side3)/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) *
                (halfPerimeter - side2) * (halfPerimeter - side3));

        }
    }
}
