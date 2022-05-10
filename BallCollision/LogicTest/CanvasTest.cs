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
            MyVector v1 = new MyVector(2, 3);
            MyVector v2 = new MyVector(4, 5);

            Assert.AreEqual(MyVector.Length(MyVector.add(v1, v2)), 10);



        }
    }
}