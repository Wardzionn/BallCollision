using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Ball 
    {
        public double Radius { get; set; }
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }

        public Ball(double radius, Vector position, Vector velocity)
        {
            Radius = radius;
            Position = position;
            Velocity = velocity;
        }
    }
}
