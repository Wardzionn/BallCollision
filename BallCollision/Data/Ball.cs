using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Data
{
    public class Ball 
    {
        public double Radius { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }

        public Ball(double radius, Vector2 position, Vector2 velocity)
        {
            Radius = radius;
            Position = position;
            Velocity = velocity;
        }
    }
}
