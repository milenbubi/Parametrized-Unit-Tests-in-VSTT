using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace Tests
{
    [TestClass]
    public class MathUtilsTest
    {
        [TestMethod]
        public void MathUtils_SumTwoNumbers_ShouldSumRight()
        {
            //Arrange
            MathUtils util = new MathUtils();

            int a = 4;
            int b = 3;

            //Act
            int result = util.Sum(a, b);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}