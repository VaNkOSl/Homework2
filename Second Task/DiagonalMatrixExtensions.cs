namespace Homework2.Second_Task
{
    public static class DiagonalMatrixExtensions
    {
        public static string ToDiagonalString(this DiagonalMatrix matrix)
        {
            string result = "";

            for (int i = 0; i < matrix.Size; i++)
            {
                result += matrix[i, i] + " ";
            }

            return result.TrimEnd();
        }

        public static bool IsOutOfBounds(this DiagonalMatrix matrix, int i, int j)
        {
            return i < 0 || j < 0 || i >= matrix.Size || j >= matrix.Size;
        }

        public static bool IsDiagonalElement(this DiagonalMatrix matrix, int i, int j)
        {
            return i == j;
        }
    }
}
