using FindMaximumNumber;
using NUnit.Framework;

namespace FindMaximumNumberTest
{
    //A-Arrange
    //A-Act
    //A-Assert
    public class Tests
    {
        [Test]
        public void GivenMaxFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            int num = max.FindMaxIntNumber(3, 1, 2);
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            int num = max.FindMaxIntNumber(1, 3, 2);
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            int num = max.FindMaxIntNumber(1, 2, 3);
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxFolatsFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            float num = max.FindMaxFloatNumber(3.1f, 1.2f, 2.4f);
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxFolatsSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            float num = max.FindMaxFloatNumber(2.4f, 3.1f, 1.2f);
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxFolatsThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            float num = max.FindMaxFloatNumber(1.2f, 2.4f, 3.1f);
            Assert.AreEqual(num, 3.1f);
        }
    }
}