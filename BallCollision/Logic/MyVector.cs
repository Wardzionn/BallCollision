using System;
using System.Collections.Generic;
using System.Text;


namespace Logic
{
    public class MyVector
    {
            public double X {  get; set; }
             public double Y { get; set; }   

        public MyVector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static MyVector add(MyVector v1, MyVector V2)
        {
            return new MyVector(v1.X + V2.X, v1.Y + V2.Y);
        }

        public static MyVector subtract(MyVector v1, MyVector V2)
        {
            return new MyVector(v1.X - V2.X, v1.Y - V2.Y);
        }

        public static MyVector Multiply(MyVector v1, double k)
        {
            return new MyVector(v1.X *k , v1.Y * k);
        }

        public static double Distance(MyVector v1, MyVector v2)
        {
            double length = Math.Sqrt(Math.Pow(v1.X, 2) + Math.Pow(v1.Y, 2));
            double distance = Math.Sqrt(Math.Pow(v2.X-v1.X, 2)+Math.Pow(v2.Y-v1.Y, 2));

            return distance;
        }
        

    }



}

