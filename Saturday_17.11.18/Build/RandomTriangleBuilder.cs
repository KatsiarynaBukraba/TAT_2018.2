using System;

namespace Saturday_17._11._18.Build
{
    public class RandomTriangleBuilder : TriangleBuilder
    {
        public RandomTriangleBuilder(TriangleBuilder successor) : base(successor) { }

        public override Triangle Build(Point a, Point b, Point c)
        {
            if (CheckExist(a,b,c))
            {
                return new RandomTriangle(a, b, c); 
            }

            return null;
        }
    }
}
