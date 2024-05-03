using Homework2.Task_One;

namespace UnitTest
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void PointMassTest()
        {
            Point point = new Point { X = 1, Y = 2, Z = 3, Mass = 5 };

            double mass = point.Mass;

            Assert.AreEqual(5, mass);

            Assert.IsTrue(point.Mass >= 0);
        }

        [TestMethod]

        public void PointIsZeroTest()
        {
            Point point = new Point { X = 0, Y = 0, Z = 0, Mass = 5 };

            Assert.IsTrue(point.IsZero());
        }

        [TestMethod]

        public void PointDistanceTest()
        {
            Point point1 = new Point { X = 1, Y = 2, Z = 3, Mass = 5 };
            Point point2 = new Point { X = 4, Y = 5, Z = 6, Mass = 6 };

            double distance = point1.DistanceTo(point2);

            double expectedDistance = Math.Sqrt(27);
            double tolerance = 0.0001;

            Assert.AreEqual(Math.Sqrt(27), distance);
            Assert.IsTrue(Math.Abs(expectedDistance - distance) < tolerance);
        }
    }
}