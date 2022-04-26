using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;
using System.Numerics;

namespace LogicTest
{
    [TestClass]
    public class LogicApiTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            LogicAPI logic = new CollisionLogic();

            State cur = logic.getCurrentState();
            Vector2 position = cur.canvas.generateLocation(50);
            Ball ball = new Ball(50, position, position);
            Assert.IsTrue(cur.canvas.IsInCanvas(ball));
        }
    }
}