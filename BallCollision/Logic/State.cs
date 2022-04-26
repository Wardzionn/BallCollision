﻿using Data;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Logic
{
    public class State
    {
        public List<Ball> balls;

        public Canvas canvas;

        public Ball CreateBall(double radius)
        {
            Vector2 location = canvas.generateLocation(radius);
            return new Ball(radius, location, location);
        }

        public void AddBall(Ball ball)
        {
            balls.Add(ball); 
        }

        
    }
}
