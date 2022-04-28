using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Logic;

namespace Data
{
    public class Ball 
    {
        public double Radius { get; set; }
        public MyVector Position { get; set; }
        public MyVector Velocity { get; set; }

        public Ball(MyVector position, MyVector velocity)
        {
            Radius = 10;
            Position = position;
            Velocity = velocity;
        }

        public void moveBall(int edge)
        {
            double x = Position.X + Velocity.X;
            double y = Position.Y + Velocity.Y;

            if (x > edge || x - Radius <= 0)
            {
                Velocity.X = -Velocity.X;
            }
            if (y > edge || y - Radius <= 0)
            {
                Velocity.Y = -Velocity.Y;
            }

            Position.X = x;
            Position.Y = y;
        }
    }
}
