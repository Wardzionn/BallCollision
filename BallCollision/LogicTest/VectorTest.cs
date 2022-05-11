using Data;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace LogicTest
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void DistanceTest()
        {
            MyVector v1 = new MyVector(2, 3);
            MyVector v2 = new MyVector(5, 3);

            Assert.AreEqual(MyVector.Distance(v1,v2), 3);
        }

        [TestMethod]
        public void BasicOperationsTest()
        {
            MyVector v1 = new MyVector(2, 3);
            MyVector v2 = new MyVector(5, 3);

            Assert.AreEqual(MyVector.add(v1, v2).X, 7);
            Assert.AreEqual(MyVector.add(v1, v2).Y, 6);

            Assert.AreEqual(MyVector.subtract(v2, v1).X, 3);
            Assert.AreEqual(MyVector.subtract(v2, v1).Y, 0);

            Assert.AreEqual(MyVector.Multiply(v1, 2).X, 4);
            Assert.AreEqual(MyVector.Multiply(v1, 2).Y, 6);
        }
    }
}