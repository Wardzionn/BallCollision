using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;
using System.Collections.Generic;

namespace LogicTest
{
    [TestClass]
    public class BallTest
    {
        [TestMethod]
        public void MoveBallTest()
        {
            MyVector vel = new MyVector(20, 35);
            MyVector pos = new MyVector(200, 450);

            Ball ball = new Ball(pos, vel, 25, 10);

            //move ball in general area
            ball.moveBall(700);
            Assert.AreEqual(ball.Position.X, 220);
            Assert.AreEqual(ball.Position.Y, 485);

            //move ball to edge and bounce vertically
            ball.moveBall(230);
            Assert.AreEqual(ball.Velocity.X, -20);
        }

        [TestMethod]
        public void AreTouchingTest()
        {
            MyVector vel = new MyVector(20, 35);
            MyVector pos = new MyVector(200, 450);
            MyVector pos2 = new MyVector(250, 450);

            Ball ball = new Ball(pos, vel, 20, 10);
            Ball ball2 = new Ball(pos2, vel, 30, 10);
            Ball ball3 = new Ball(pos2, vel, 10, 10);

            Assert.IsTrue(ball.IsTouching(ball2));
            Assert.IsFalse(ball.IsTouching(ball3));

        }

        [TestMethod]
        public void VectorCalculationTest()
        {
            MyVector vel = new MyVector(10, 15);
            MyVector vel2 = new MyVector(-10, 13);

            MyVector pos = new MyVector(200, 450);
            MyVector pos2 = new MyVector(250, 450);

            Ball ball = new Ball(pos, vel, 20, 10);
            Ball ball2 = new Ball(pos2, vel2, 30, 20);

            List<MyVector> calculatedVels = Ball.CalculateVels(ball, ball2);

            Assert.AreEqual(calculatedVels[0].X, -16.67, 0.01);
            Assert.AreEqual(calculatedVels[0].Y, 15, 0.1);

            Assert.AreEqual(calculatedVels[1].X, 3.33, 0.01);
            Assert.AreEqual(calculatedVels[1].Y, 13, 0.1);





        }
    }
}