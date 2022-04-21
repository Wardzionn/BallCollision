using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class State
    {
        public List<Ball> balls;

        public void AddBall(double radius)
        {
            Random rng = new Random();

            double x = rng.NextDouble() + 100;
            double y = rng.NextDouble() + 100;

            balls.Add(new Ball(radius,new Vector(x,y), new Vector(x,y)));
        }
    }
}
