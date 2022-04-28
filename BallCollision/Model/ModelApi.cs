using Data;
using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Model
{
    public abstract class ModelApi
    {
        public abstract List<BallModel> balls { get;}

        public abstract void addBallsAndStart(int ballsCount);
        public abstract void stopSim();

        public static ModelApi CreateApi()
        {
            return new CollisionModel();
        }

        internal class CollisionModel : ModelApi
        {
            public LogicAPI collisionLogic;
            public override List<BallModel> balls => ChangeBallToBallInModel();

            public CollisionModel()
            {
                collisionLogic = collisionLogic ?? LogicAPI.Create();
            }

      

            public override void addBallsAndStart(int ballsCount)
            {
                collisionLogic.addBalls(ballsCount);
                collisionLogic.start();
            }

            public override void stopSim()
            {
                if (balls.Count > 0)
                {
                    balls.Clear();
                    collisionLogic.stop();
                } 
                
            }


            public List<BallModel> ChangeBallToBallInModel()
            {
                List<BallModel> result = new List<BallModel>();

                foreach (Ball ball in collisionLogic.getBalls())
                {
                    result.Add(new BallModel(ball));
                }
                return result;
            }

        }

    }
    
}
