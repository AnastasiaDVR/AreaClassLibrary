using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaClassLibrary;

namespace AreaClassLibraryTest
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void AreaCircle_3mult3multPi_Returned28_27()
        {
            double radius = 3;
            double expected = 28.27;

            double result = radius.AreaCircle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaTriangle_24and26and10_Returned120()
        {
            double[] sides = { 24, 26, 10};
            double expected = 120;

            double result = sides.AreaTriangle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RightTriangle__24and26and10_ReturnedTrue()
        {
            double[] sides = { 24, 26, 10 };
            bool expected = true;

            bool result = sides.isRightTringle();

            Assert.AreEqual(expected, result);
        }

        /// Test 0 and less then 0

        [TestMethod]
        public void RadiusCircle_Zero_ReturnedZero()
        {
            double radius = 0;
            double expected = 0;

            double result = radius.AreaCircle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RadiusCircle_LessThenZero_ReturnedZero()
        {
            double radius = -1;
            double expected = 0;

            double result = radius.AreaCircle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SidesTriangle_0and0and0_Returned0()
        {
            double[] sides = { 0, 0, 0 };
            double expected = 0;

            double result = sides.AreaTriangle();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SidesTriangle_LessThenZero_Returned0()
        {
            double[] sides = { -1, -12, -2 };
            double expected = 0;

            double result = sides.AreaTriangle();

            Assert.AreEqual(expected, result);
        }

    }
}
