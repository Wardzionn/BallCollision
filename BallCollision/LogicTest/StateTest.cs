using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;
using System.Numerics;

namespace LogicTest
{
    [TestClass]
    public class StateTest
    {
        [TestMethod]
        public void RandomBallCreationAndRemovalTest()
        {
            State state = new State(500);
            int ballCount = 2;

            state.AddBalls(ballCount);

            Assert.AreNotEqual(state.balls[0].Position.X, state.balls[1].Position.X);
            Assert.AreNotEqual(state.balls[0].Position.Y, state.balls[1].Position.Y);

            Assert.AreNotEqual(state.balls[0].Velocity.X, state.balls[1].Velocity.X);
            Assert.AreNotEqual(state.balls[0].Velocity.Y, state.balls[1].Velocity.Y);

            Assert.AreNotEqual(state.balls[0].Radius, state.balls[1].Radius);
            Assert.AreNotEqual(state.balls[0].Mass, state.balls[1].Mass);

            state.removeBalls(ballCount);

            Assert.AreEqual(state.balls.Count, 0);
        }
    }
}