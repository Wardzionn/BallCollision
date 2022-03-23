using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassLibrary1.Class1 testowa = new ClassLibrary1.Class1(3,"esa","wariaty");
            Assert.IsNotNull(testowa);
            Assert.AreEqual(testowa.getAge(), 3);
            testowa.setAge(5);
            Assert.AreEqual(testowa.getAge(), 5);
        }
    }
}