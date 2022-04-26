using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class DataApi
    {
        public abstract void Add(Ball ball);
        public abstract Ball Get(int index);
        public abstract int GetBallCount();

        public static DataApi CreateData()
        {
            return new BallList();
        }
    }
}
