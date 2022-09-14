using Diamond;

namespace DiamondTestNUnit
{
    public class DiamondTest
    {
        #region
        /// <summary>
        /// Created test case with valid input
        /// </summary>
        [Test]
        public static void CreateDiamondSuccess()
        {
            //provide valid input and verify that getting staus code 201
            string input = Constant.inputValue;
            int result = CreateDiamond.DiamondMaking(input);
            Assert.That(result, Is.EqualTo(201));
        }

        /// <summary>
        /// Created test case with numeric value
        /// </summary>
        [Test]
        public static void DiamondTestWithNumericValue()
        {
            //provide numeric value or special charcter and diamond will not created and return status code 400
            string input = Constant.numericValue;
            int result = CreateDiamond.DiamondMaking(input);
            Assert.That(result, Is.EqualTo(400));
        }
        /// <summary>
        /// created test for exception occured
        /// </summary>
        [Test]
        public static void DiamondTestFailure()
        {
            //If exception occured will catch and return status code 500
            string input = Constant.invalidInput;
            int result = CreateDiamond.DiamondMaking(input);
            Assert.That(result, Is.EqualTo(500));
        }
    }
    #endregion
}