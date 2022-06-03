using Logic;
using System;
using System.Collections.Generic;

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

        public void moveBall()
        {
            int edge = 500;
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

        public void logData()
        {
            
                
        }
        
        public bool IsTouching(Ball ball2) => MyVector.Distance(this.Position, ball2.Position) <= this.Radius + ball2.Radius;
        
        public static List<MyVector> CalculateVels(Ball b1, Ball b2)
        {
            List<MyVector> result = new List<MyVector>();

            double distanceX = b1.Position.X - b2.Position.X;
            double distanceY = b1.Position.Y - b2.Position.Y;
            double collisionAngle = Math.Atan2(distanceY, distanceX);
            
            double b1_magnitude = Math.Sqrt(b1.Velocity.X * b1.Velocity.X + b1.Velocity.Y * b1.Velocity.Y);
            double b2_magnitude = Math.Sqrt(b2.Velocity.X * b2.Velocity.X + b2.Velocity.Y * b2.Velocity.Y);
            
            double b1_direction = Math.Atan2(b1.Velocity.Y, b1.Velocity.X);
            double b2_direction = Math.Atan2(b2.Velocity.Y, b2.Velocity.X);

            double b1_newVelocityX = b1_magnitude * Math.Cos(b1_direction - collisionAngle);
            double b2_newVelocityX = b2_magnitude * Math.Cos(b2_direction - collisionAngle);
            
            double b1_finalVelocityX = ((b1.Mass - b2.Mass) * b1_newVelocityX + (b2.Mass + b2.Mass) * b2_newVelocityX) / (b1.Mass + b2.Mass);
            double b2_finalVelocityX = ((b1.Mass + b1.Mass) * b1_newVelocityX + (b2.Mass - b1.Mass) * b2_newVelocityX) / (b1.Mass + b2.Mass);
            
            double b1_finalVelocityY = b1_magnitude * Math.Sin(b1_direction - collisionAngle);
            double b2_finalVelocityY = b2_magnitude * Math.Sin(b2_direction - collisionAngle);
            
            MyVector b1_Velocity = new MyVector((float)(Math.Cos(collisionAngle) * b1_finalVelocityX
                                                 + Math.Cos(collisionAngle + Math.PI / 2) * b1_finalVelocityY), (float)(Math.Sin(collisionAngle) * b1_finalVelocityX
                                                 + Math.Sin(collisionAngle + Math.PI / 2) * b1_finalVelocityY));
            
            MyVector b2_Velocity = new MyVector((float)(Math.Cos(collisionAngle) * b2_finalVelocityX
                                    + Math.Cos(collisionAngle + Math.PI / 2) * b2_finalVelocityY), (float)(Math.Sin(collisionAngle) * b2_finalVelocityX
                                    + Math.Sin(collisionAngle + Math.PI / 2) * b2_finalVelocityY));

            result.Add(b1_Velocity);
            result.Add(b2_Velocity);

            return result;

        }

        public override string ToString()
        {
            return "Pos: " + Position.ToString() +
              " Vel: " + Velocity.ToString();
        }
    }
}
