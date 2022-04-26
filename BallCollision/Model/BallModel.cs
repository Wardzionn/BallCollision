using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Logic;

namespace Model
{
    public class BallModel
    {
        private Ball ball;

        public BallModel(Ball ball)
        {
            this.ball = ball;
        }

        public double X
        {
           get { return ball.Position.X; }
        }

        public double Y
        {
            get { return ball.Position.Y; }
        }

        public double Radius
        {
            get { return ball.Radius; }
        }



    }
}
