using System;

namespace Saturday_17._11._18.Build
{
    public class EquilateralTriangleBuilder : TriangleBuilder
    {
        public EquilateralTriangleBuilder(TriangleBuilder successor) : base(successor) { }

        public bool IsEquilateralTriangle(Point a, Point b, Point c)
        {
            var side1 = a.GetDistance(b);
            var side2 = a.GetDistance(c);
            var side3 = b.GetDistance(c);

            if (Math.Abs(side1 - side2) < double.Epsilon && Math.Abs(side1 - side3) < double.Epsilon
                                                         && Math.Abs(side2 - side3) < double.Epsilon)
                return true;
            else
            {
                return false;
            }
        }

        public override Triangle Build(Point a, Point b, Point c)
        {
            if (CheckExist(a,b,c) && IsEquilateralTriangle(a,b,c))
            {
                return new EquilateralTriangle(a,b,c);
            }
            else if (successor != null)
            {
                return successor.Build(a, b, c);
            }
            else
            {
                throw new Exception("Triangle not exist!");
            }
        }
    }
}
