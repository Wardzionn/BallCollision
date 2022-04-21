using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Vector
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public  static Vector vector(double x, double y) => new Vector(x, y);

        public  Vector add(Vector v1, Vector v2) { return new Vector(v1.x + v2.x, v1.y + v2.y); }

        public Vector reverse(Vector v1) { return new Vector(-v1.x,-v1.y); }

        public static Vector subtract(Vector v1, Vector v2) { return new Vector(v1.x - v2.x, v1.y - v2.y);}

        public static Vector multiply(Vector v1, double f) { return new Vector(v1.x * f, v1.y * f);}
    }
}
