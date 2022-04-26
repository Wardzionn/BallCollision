using Data;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace LogicTest
{
    [TestClass]
    public class CanvasTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Canvas canvas = new Canvas(new Vector2(0,0), new Vector2(500,500));
            Ball ball = new Ball(20, new Vector2(30, 30), new Vector2(500, 500));
            Assert.IsTrue(canvas.IsInCanvas(ball));
            ball = new Ball(30, new Vector2(30, 30), new Vector2(500, 500));
            Assert.IsTrue(canvas.IsInCanvas(ball));
            ball = new Ball(40, new Vector2(30, 30), new Vector2(500, 500));
            Assert.IsFalse(canvas.IsInCanvas(ball));
            ball = new Ball(40, new Vector2(40, 30), new Vector2(500, 500));
            Assert.IsFalse(canvas.IsInCanvas(ball));
            ball = new Ball(40, new Vector2(300, 300), new Vector2(500, 500));
            Assert.IsTrue(canvas.IsInCanvas(ball));
            ball = new Ball(40, new Vector2(470, 470), new Vector2(500, 500));
            Assert.IsFalse(canvas.IsInCanvas(ball));
            ball = new Ball(40, new Vector2(470,470), new Vector2(500, 500));
            Assert.IsFalse(canvas.IsInCanvas(ball));

            for (int i = 0; i < 30; i++)
            {
                Vector2 loc = canvas.generateLocation(ball.Radius);
                ball.Position = loc;
                Assert.IsTrue(canvas.IsInCanvas(ball));
            }



        }
    }
}