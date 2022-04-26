using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public abstract class LogicAPI
    {
        public abstract void AddBalls(int count);

        public abstract State getCurrentState();
    }
}
