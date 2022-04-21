using System;
using System.Collections.Generic;
using System.Text;
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
           get { return ball.Position.x; }
        }

        public double Y
        {
            get { return ball.Position.y; }
        }

        public double Radius
        {
            get { return ball.Radius; }
        }



    }
}
