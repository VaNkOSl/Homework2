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
    }
}
