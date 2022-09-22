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
        [Test]
        public void GivenMaxStringFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            string name = max.FindMaxStringNumber("Truck","Car", "Bike");
            Assert.AreEqual(name,"Truck");
        }
        [Test]
        public void GivenMaxStringSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            string name = max.FindMaxStringNumber("Car", "Truck", "Bike");
            Assert.AreEqual(name, "Truck");
        }
        [Test]
        public void GivenMaxStringThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaximumNumb max = new FindMaximumNumb();
            string name = max.FindMaxStringNumber("Car", "Bike", "Truck");
            Assert.AreEqual(name, "Truck");
        }
        [Test]
        public void GivenMaxGenricsFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<int> max = new FindMaxGenrics<int>(3, 1, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxGenricsSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<int> max = new FindMaxGenrics<int>(1, 3, 2);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxGenricsThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<int> max = new FindMaxGenrics<int>(1, 2, 3);
            int num = max.FindMax();
            Assert.AreEqual(num, 3);
        }
        [Test]
        public void GivenMaxGenricsFolatsFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<float> max = new FindMaxGenrics<float>(3.1f, 1.2f, 2.4f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxGenricsFolatsSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<float> max = new FindMaxGenrics<float>(2.4f, 3.1f, 1.2f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxGenricsFolatsThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<float> max = new FindMaxGenrics<float>(1.2f, 2.4f, 3.1f);
            float num = max.FindMax();
            Assert.AreEqual(num, 3.1f);
        }
        [Test]
        public void GivenMaxGenricsStringFirstNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<string> max = new FindMaxGenrics<string>("Truck", "Car", "Bike");
            string name = max.FindMax();
            Assert.AreEqual(name, "Truck");
        }
        [Test]
        public void GivenMaxGenricsStringSecondNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<string> max = new FindMaxGenrics<string>("Car", "Truck", "Bike");
            string name = max.FindMax();
            Assert.AreEqual(name, "Truck");
        }
        [Test]
        public void GivenMaxGenricsStringThirdNumber_WhenAnalized_ShouldReturnMaxNumber()
        {
            FindMaxGenrics<string> max = new FindMaxGenrics<string>("Car", "Bike", "Truck");
            string name = max.FindMax();
            Assert.AreEqual(name, "Truck");
        }
    }
}