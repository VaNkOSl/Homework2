using Homework2.Second_Task;

namespace UnitTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void ConstructorTest_WithElements()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3);

            Assert.AreEqual(3, matrix1.Size);
        }

        [TestMethod]
        public void ConstructorTest_WithoutElements()
        {
            DiagonalMatrix matrix2 = new DiagonalMatrix();

            Assert.AreEqual(0, matrix2.Size);
        }

        [TestMethod]
        
        public void IndexerTest()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3);

            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(2, matrix[1, 1]);
            Assert.AreEqual(3, matrix[2, 2]);
            Assert.AreEqual(0, matrix[0, 1]);
            Assert.AreEqual(0, matrix[1, 0]);
        }

        [TestMethod]
        public void TrackTest()
        {
            DiagonalMatrix matrix = new DiagonalMatrix(1, 2, 3);

            double track = matrix.Track();

            Assert.AreEqual(6, track);
        }

        [TestMethod]
        public void EqualsTest()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3);
            DiagonalMatrix matrix2 = new DiagonalMatrix(1, 2, 3);
            DiagonalMatrix matrix3 = new DiagonalMatrix(3, 4, 5);

            Assert.IsTrue(matrix1.Equals(matrix2));
            Assert.IsFalse(matrix1.Equals(matrix3));

        }

        [TestMethod]

        public void AddTest()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3);
            DiagonalMatrix matrix2 = new DiagonalMatrix(4, 5, 6, 7);

            DiagonalMatrix resultMatrix = matrix1.Add(matrix2);

            Assert.AreEqual(4, resultMatrix.Size);
            Assert.AreEqual("5 7 9 7", resultMatrix.ToDiagonalString());
        }
    }
}
