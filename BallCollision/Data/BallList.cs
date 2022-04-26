using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class BallList : DataApi
    {
        private readonly List<Ball> ballList;

        public BallList()
        {
            this.ballList = new List<Ball>();
        }

        public override void Add(Ball ball)
        {
            ballList.Add(ball); 
        }

        public override Ball Get(int index)
        {
            return ballList[index];
        }

        public override int GetBallCount()
        {
            return ballList.Count;
        }
    }
}
