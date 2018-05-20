using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace Tests
{
    [TestClass]
    public class ParametrizedUnitTestInVSTT
    {
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Working test method, reading data from XML file
        /// </summary>
        [TestMethod]
        [DeploymentItem("Data.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                        "Data.xml",
                        "ROW",
                        DataAccessMethod.Sequential)]
        public void MathUtils_SumTwoNumbersWithParameters_ShouldSumRight()
        {
            //Arrange
            MathUtils util = new MathUtils();

            int a = Int32.Parse((string)TestContext.DataRow["A"]);
            int b = Int32.Parse((string)TestContext.DataRow["B"]);
            int expectedResult = Int32.Parse((string)TestContext.DataRow["Expected"]);

            //Act
            int result = util.Sum(a, b);

            //Assert
            Assert.AreEqual(result, expectedResult, "Ne stawa, moj");
        }
    }
}