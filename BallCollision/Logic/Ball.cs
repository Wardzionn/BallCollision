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
        public double Mass { get; set; }

        public Ball(MyVector position, MyVector velocity, double radius, double mass)
        {
            Radius = radius;
            Position = position;
            Velocity = velocity;
            Mass = mass;
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

        public void bounceBall()
        {
            Velocity.X = -Velocity.X;
            Velocity.Y = -Velocity.Y;
        }

        public static List<MyVector> calculateVels(Ball b1, Ball b2)
        {
            List<MyVector> result = new List<MyVector>();

            double distanceX = b1.Position.X - b2.Position.X;
            double distanceY = b1.Position.Y - b2.Position.Y;
            double collisionAngle = Math.Atan2(distanceY, distanceX);
            double pA_magnitude = Math.Sqrt(b1.Velocity.X * b1.Velocity.X + b1.Velocity.Y * b1.Velocity.Y);
            double pB_magnitude = Math.Sqrt(b2.Velocity.X * b2.Velocity.X + b2.Velocity.Y * b2.Velocity.Y);
            double pA_direction = Math.Atan2(b1.Velocity.Y, b1.Velocity.X);
            double pB_direction = Math.Atan2(b2.Velocity.Y, b2.Velocity.X);
            double pA_newVelocityX = pA_magnitude * Math.Cos(pA_direction - collisionAngle);
            double pA_newVelocityY = pA_magnitude * Math.Sin(pA_direction - collisionAngle);
            double pB_newVelocityX = pB_magnitude * Math.Cos(pB_direction - collisionAngle);
            double pB_newVelocityY = pB_magnitude * Math.Sin(pB_direction - collisionAngle);
            double pA_finalVelocityX = ((b1.Mass - b2.Mass) * pA_newVelocityX + (b2.Mass + b2.Mass) * pB_newVelocityX) / (b1.Mass + b2.Mass);
            double pB_finalVelocityX = ((b1.Mass + b1.Mass) * pA_newVelocityX + (b2.Mass - b1.Mass) * pB_newVelocityX) / (b1.Mass + b2.Mass);
            double pA_finalVelocityY = pA_newVelocityY;
            double pB_finalVelocityY = pB_newVelocityY;
            MyVector b1_Velocity = new MyVector((float)(Math.Cos(collisionAngle) * pA_finalVelocityX + Math.Cos(collisionAngle + Math.PI / 2) * pA_finalVelocityY), (float)(Math.Sin(collisionAngle) * pA_finalVelocityX + Math.Sin(collisionAngle + Math.PI / 2) * pA_finalVelocityY));
            MyVector b2_Velocity = new MyVector((float)(Math.Cos(collisionAngle) * pB_finalVelocityX + Math.Cos(collisionAngle + Math.PI / 2) * pB_finalVelocityY), (float)(Math.Sin(collisionAngle) * pB_finalVelocityX + Math.Sin(collisionAngle + Math.PI / 2) * pB_finalVelocityY));

            result.Add(b1_Velocity);
            result.Add(b2_Velocity);

            return result;

        }
    }
}
