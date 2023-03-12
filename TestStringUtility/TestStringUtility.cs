using TDD_exercise;

namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        [TestMethod]
        public void ShouldFindYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void SearchShouldBeCaseSensitive()
        {
            string stringToCheck = "mySerious";
            string stringToFind = "S";
            int expectedResult = 1;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Nulltest()
        {
            string? stringToCheck = null;
            string? stringToFind = null;
            int? expectedResult = null;

            StringUtility classUnderTest = new StringUtility();
            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}