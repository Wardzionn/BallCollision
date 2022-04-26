using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    internal class BallList
    {
        private readonly List<Ball> ballList;

        public BallList()
        {
            this.ballList = new List<Ball>();
        }

        public void Add(Ball ball)
        {
            ballList.Add(ball); 
        }

        public Ball Get(int index)
        {
            return ballList[index];
        }

        public int GetBallCount()
        {
            return ballList.Count;
        }
    }
}
