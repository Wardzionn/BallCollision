using Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            double radius = rng.NextDoubleInRange(5, 20);
            double mass = rng.NextDoubleInRange(1, 8);

            return new Ball(new MyVector(pos_x,pos_y), new MyVector(vel_x,vel_y), radius, mass);
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
                CheckBallCollision();
                Thread.Sleep(speed);
            }
        }

        public void start()
        {
            updatePosition = new Task(MoveBallsConstantly);
            updatePosition.Start();
        }

        public void CheckBallCollision()
        {
            if (balls.Count > 0)
            {
                for (int i = 0; i < balls.Count; i++)
                {
                    for (int j = i+1; j < balls.Count; j++)
                    {                       

                        if (MyVector.Length(balls[i].Position, balls[j].Position) <= (balls[i].Radius + balls[j].Radius))
                        {
                            List<MyVector> vels = Ball.calculateVels(balls[i], balls[j]);
                            balls[i].Velocity = vels[0];
                            balls[j].Velocity = vels[1];
                        }
                    }
                }
            }
        }


    }
}
