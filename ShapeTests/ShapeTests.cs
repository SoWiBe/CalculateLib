namespace ShapeTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void GetCircleAreaTest()
        {
            double radius = 15;
            double correct_answer = 706.8583;

            double result = CalculateLib.AreaCalculation.GetInstance().GetArea(radius);

            Assert.AreEqual(correct_answer, result, 0.001, "Incorrect! - " + result);
        }

        [TestMethod]
        public void GetTriangleAreaTest()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            double correct_answer = 6;

            double result = CalculateLib.AreaCalculation.GetInstance().GetArea(firstSide, secondSide, thirdSide);

            Assert.AreEqual(correct_answer, result, 0.001, "Incorrect! - " + result);
        }

        [TestMethod]
        public void GetTriangleAreaTest1()
        {
            double firstSide = 5;
            double secondSide = 4;
            double thirdSide = 5;
            double correct_answer = 9.165;

            double result = CalculateLib.AreaCalculation.GetInstance().GetArea(firstSide, secondSide, thirdSide);

            Assert.AreEqual(correct_answer, result, 0.001, "Incorrect! - " + result);
        }
    }
}