using Data;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Logic
{
    public class State
    {
        public BallList ballList;

        public Canvas canvas;

        public State(Canvas canvas)
        {
            this.ballList = (BallList)DataApi.CreateData();
            this.canvas = canvas;
        }

        public Ball CreateBall(double radius)
        {
            Vector2 location = canvas.generateLocation(radius);
            return new Ball(radius, location, location);
        }

        public void AddBall(Ball ball)
        {
            ballList.Add(ball);
        }

        
    }
}
