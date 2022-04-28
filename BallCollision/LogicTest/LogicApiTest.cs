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
            State state = new State(500);
            LogicAPI logicApi = LogicAPI.Create();

            logicApi.addBalls(5);
            Assert.AreEqual(state.balls.Count, 5);

            logicApi.stop();
            Assert.AreEqual(state.balls.Count, 0);
        }

        public void MoveBallsTest()
        {
            State state = new State(500);
            LogicAPI logicApi = LogicAPI.Create();
            
            logicApi.addBalls(2);
            MyVector pos1 = state.balls[0].Position;
            MyVector pos2 = state.balls[1].Position;

            MyVector vel1 = state.balls[0].Velocity;
            MyVector vel2 = state.balls[1].Velocity;

            state.MoveBalls();
            Assert.AreEqual(state.balls[0].Position, MyVector.add(pos1, vel1));
            Assert.AreEqual(state.balls[1].Position, MyVector.add(pos2, vel2));
        }
    }
    

}