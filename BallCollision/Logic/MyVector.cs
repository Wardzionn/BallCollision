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

        public MyVector subtract(MyVector v1, MyVector V2)
        {
            return new MyVector(v1.X - V2.X, v1.Y - V2.Y);
        }

        public MyVector Multiply(MyVector v1, double k)
        {
            return new MyVector(v1.X *k , v1.Y * k);
        }

    }
}
