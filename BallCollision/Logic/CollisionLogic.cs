using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Logic
{
    public class CollisionLogic : LogicAPI
    {
        public State state { get ; set; }   
        public static readonly int BallRadius = 20;

        public CollisionLogic()
        {
            state = new State(new Canvas(new Vector2(0, 0), new Vector2(500, 500)));
        }

        public override void AddBalls(int count)
        {
            for(int i = 0; i < count; i++)
            {
                state.AddBall(state.CreateBall(20));
            }
        }

        public override State getCurrentState()
        {
            return state;
        }
    }
}
