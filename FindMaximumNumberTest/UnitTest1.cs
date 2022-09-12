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
    }
}