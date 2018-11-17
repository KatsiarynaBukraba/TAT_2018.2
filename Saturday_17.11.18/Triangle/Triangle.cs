namespace Saturday_17._11._18
{
    public abstract class Triangle
    {
        public Point X { get; set; }
        public Point Y { get; set; }
        public Point Z { get; set; }

        public Triangle(Point x, Point y, Point z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public abstract double GetSquare();
    }
}
