using System;
using System.CodeDom;

namespace Saturday_17._11._18.Build
{
    public class RightTriangleBuilder : TriangleBuilder
    {
        public RightTriangleBuilder(TriangleBuilder successor): base(successor) { }

        public bool IsRightTriangle(Point a, Point b, Point c)
        {

            var side1 = a.GetDistance(b);
            var side2 = a.GetDistance(c);
            var side3 = b.GetDistance(c);

            double case1 = Math.Abs(side1 * side1 - side2 * side2 - side3 * side3);
            double case2 = Math.Abs(side2 * side2 - side1 * side1 - side3 * side3);
            double case3 = Math.Abs(side3 * side3 - side2 * side2 - side1 * side1);

            if (case1 < double.Epsilon || case2 < double.Epsilon || case3 < double.Epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Triangle Build(Point a, Point b, Point c)
        {
            var condition1 = CheckExist(a, b, c);
            var condition2 = IsRightTriangle(a, b, c);
            if (condition1 && condition2)
                return new RightTriangle(a,b,c);
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
