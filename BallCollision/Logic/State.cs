using Data;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logic
{
    public class State
    {
        public int canvasSize;
        public List<Ball> balls { get; set; }
        public Task updatePosition;
        public int speed = 30;

        public State(int canvasSize)
        {
            this.canvasSize = canvasSize;
        }

        public Ball CreateBall()
        {
            Random rng = new Random();
            double pos_x = rng.NextDoubleInRange(1, canvasSize);
            double pos_y = rng.NextDoubleInRange(1, canvasSize);

            double vel_x = rng.NextDoubleInRange(1, 5);
            double vel_y = rng.NextDoubleInRange(1, 5);

            return new Ball(new MyVector(pos_x,pos_y), new MyVector(vel_x,vel_y));
        }

        public void AddBalls(int ballsCount)
        {
            balls = new List<Ball>();
            for (int i = 0; i < ballsCount; i++)
            {
                balls.Add(CreateBall());
            }
        }

        public void removeBalls(int BallsNumber)
        {
            balls = new List<Ball>();
            for (int i = 0; i < BallsNumber; i++)
            {
                balls.RemoveAt(i);
            }
        }

        public void MoveBalls()
        {
            foreach (Ball ball in balls)
            {
                ball.moveBall(canvasSize);
            }
        }

        public void MoveBallsConstantly()
        {
            while (true)
            {
                MoveBalls();
                Thread.Sleep(speed);
            }
        }

        public void start()
        {
            updatePosition = new Task(MoveBallsConstantly);
            updatePosition.Start();
        }


    }
}
