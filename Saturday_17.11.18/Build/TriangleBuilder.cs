using System;

namespace Saturday_17._11._18
{
    public abstract class TriangleBuilder
    {
        protected TriangleBuilder successor;

        public TriangleBuilder(TriangleBuilder successor)
        {
            this.successor = successor;
        }

        public abstract Triangle Build(Point a, Point b, Point c);

        public bool CheckExist(Point a, Point b, Point c)
        {
            var side1 = a.GetDistance(b);
            var side2 = a.GetDistance(c);
            var side3 = b.GetDistance(c);

            if ((side1 > (side2 + side3)) || (side2 > (side1 + side3)) || (side3 > (side2 + side1))) return false;
            else return true;
        }
    }
}
