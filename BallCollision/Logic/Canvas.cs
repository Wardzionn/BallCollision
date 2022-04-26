using Data;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Logic
{
    public class Canvas
    {
        public Vector2 LeftUpperCorner;
        public Vector2 RightLowerCorner;
        public static Random rng = new Random();

        public bool IsInCanvas(Ball ball)
        {
            return inX(ball) && inY(ball);
        }

        public Canvas(Vector2 leftUpperCorner, Vector2 rightLowerCorner)
        {
            LeftUpperCorner = leftUpperCorner;
            RightLowerCorner = rightLowerCorner;
        }

        public bool inX(Ball ball)
        {
            return ball.Position.X - ball.Radius >= LeftUpperCorner.X && ball.Position.X + ball.Radius <= RightLowerCorner.X;
        }

        public bool inY(Ball ball)
        {
            return ball.Position.Y - ball.Radius >= LeftUpperCorner.Y && ball.Position.Y + ball.Radius  <= RightLowerCorner.Y;
        }

        public Vector2 generateLocation(double radius)
        {

            double x = rng.NextDoubleInRange(LeftUpperCorner.X + radius, RightLowerCorner.X - radius);
            double y = rng.NextDoubleInRange(LeftUpperCorner.Y + radius, RightLowerCorner.Y - radius);

            return new Vector2((float)x, (float)y);
        }
    }
}
