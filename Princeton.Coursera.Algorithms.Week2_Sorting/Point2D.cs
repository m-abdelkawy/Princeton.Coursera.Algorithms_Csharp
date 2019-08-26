using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Princeton.Coursera.Algorithms.Week2_Sorting
{
    public class Point2D : IComparable<Point2D>
    {

        private readonly double x;
        private readonly double y;

        public Point2D(double _x, double _y)
        {
            if (Double.IsInfinity(x) || Double.IsInfinity(y))
                throw new ArithmeticException("Coordinates must be finite!");

            if (Double.IsNaN(x) || Double.IsNaN(y))
                throw new ArithmeticException("Coordinates cannot be NaN!");
            this.x = _x;
            this.y = _y;
        }

        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public double R
        {
            get { return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); }
        }
        public double Theta
        {
            get { return Math.Atan2(y, x); }
        }

        private double AngleTo(Point2D that)
        {
            double dx = that.x - this.x;
            double dy = that.y - this.y;

            return Math.Atan2(dy, dx);
        }

        private int Ccw(Point2D a, Point2D b, Point2D c)
        {
            double area2 = (b.x - a.x) * (c.y - a.y) - (b.y - a.y) * (c.x - a.x);
            if (area2 < 0) return -1;  //clockwise
            else if (area2 > 0) return 1;  //counter clockwise
            else return 0;  //collinear
        }

        public static double Area2(Point2D a, Point2D b, Point2D c)
        {
            return (b.x - a.x) * (c.y - a.y) - (b.y - a.y) * (c.x - a.x);
        }

        public double DistanceTo(Point2D that)
        {
            double dx = that.x - this.x;
            double dy = that.y - this.y;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        public double DistanceSquaredTo(Point2D that)
        {
            double dx = that.x - this.x;
            double dy = that.y - this.y;

            return Math.Pow(dx, 2) + Math.Pow(dy, 2);
        }

        public int CompareTo(Point2D that)
        {
            if (this.y < that.y) return -1;
            if (this.y > that.y) return 1;
            if (this.x < that.x) return -1;
            if (this.x > that.x) return 1;
            return 0;
        }

    }
}
