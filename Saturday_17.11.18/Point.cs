using System;

namespace Saturday_17._11._18
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsEqual(Point a)
        {
            if (Math.Abs(x - a.x) <= double.Epsilon && Math.Abs(y - a.x) <= double.Epsilon)
                return true;
            else return false;
        }

        public double GetDistance(Point a)
        {
            return Math.Sqrt((x - a.x) * (x - a.x) + (y - a.y) * (y - a.y));
        }
    }
}
