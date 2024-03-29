﻿using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("LogicTest")]

namespace Logic
{
    public abstract class LogicAPI
    {
        public abstract void addBalls(int count);
        public abstract void start();
        public abstract void stop();
        public abstract List<Ball> getBalls();

        public static LogicAPI Create(DataApi data = default(DataApi))
        {
            return new CollisionLogic(
                data == null ? DataApi.CreateDataApi() : data);
        }
        public abstract State getState();

        private class CollisionLogic : LogicAPI
        {
            private DataApi data;
            private Task updatePosition;
            private State state { get; }

            public CollisionLogic(DataApi data)
            {
                this.data = data;
                state = new State(500);
            }
            public override void addBalls(int count)
            {

                state.AddBalls(count);
            }

            public override List<Ball> getBalls()
            {
                return state.balls;
            }

            public override State getState()
            {
                return state;
            }

            public override void start()
            {
                if(state.balls.Count > 0)
                {
                    updatePosition = Task.Run(state.MoveBallsConstantly);
                }
            }

            public override void stop()
            {
                state.balls.Clear();
               
            }

            


        }

    }
}
