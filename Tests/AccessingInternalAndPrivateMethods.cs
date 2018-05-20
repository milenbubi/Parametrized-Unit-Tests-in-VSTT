using Microsoft.VisualStudio.TestTools.UnitTesting;

using Utilities;

namespace Tests
{
    [TestClass]
    public class AccessingInternalAndPrivateMethods
    {
        [TestMethod]
        public void TestInternalMethod()
        {
            var intern = new ClassContainingPrivateAndInternalMembers();

            string msg = intern.InternalMethod();

            Assert.AreEqual("Internal method", msg);
        }

        [TestMethod]
        public void TestInternalProperty()
        {
            var intern = new ClassContainingPrivateAndInternalMembers();

            string msg = intern.InternalProperty;

            Assert.AreEqual("Internal property", msg);
        }

        [TestMethod]
        public void TestPrivateMethod()
        {
            PrivateObject priv = new PrivateObject(typeof(ClassContainingPrivateAndInternalMembers));

            string msg = (string)priv.Invoke("PrivateMethod");

            Assert.AreEqual("Private method", msg);
        }
    }
}