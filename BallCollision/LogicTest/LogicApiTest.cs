using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;
using System.Numerics;

namespace LogicTest
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void AddRemoveBallsTest()
        {
            LogicAPI logicApi = LogicAPI.Create();
            logicApi.addBalls(5);
            Assert.AreEqual(logicApi.getBalls().Count, 5);

            logicApi.stop();
            Assert.AreEqual(logicApi.getBalls().Count, 0);
        }

        [TestMethod]
        public void MoveBallsTest()
        {
            LogicAPI logicApi = LogicAPI.Create();
            
            logicApi.addBalls(2);
            
            
            double pos1x = logicApi.getBalls()[0].Position.X;
            double pos1y = logicApi.getBalls()[0].Position.Y;
            double pos2x = logicApi.getBalls()[1].Position.X;
            double pos2y = logicApi.getBalls()[1].Position.Y;

            double vel1x = logicApi.getBalls()[0].Velocity.X;
            double vel2x = logicApi.getBalls()[1].Velocity.X;
            double vel1y = logicApi.getBalls()[0].Velocity.Y;
            double vel2y = logicApi.getBalls()[1].Velocity.Y;

            logicApi.getState().MoveBalls();

            Assert.AreEqual(logicApi.getBalls()[0].Position.X, pos1x+vel1x);
            Assert.AreEqual(logicApi.getBalls()[0].Position.Y, pos1y+vel1y);
            Assert.AreEqual(logicApi.getBalls()[1].Position.X, pos2x+vel2x);
            Assert.AreEqual(logicApi.getBalls()[1].Position.Y, pos2y+vel2y);
        }
    }
    

}