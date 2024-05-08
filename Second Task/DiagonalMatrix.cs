namespace Homework2.Second_Task;

public class DiagonalMatrix 
{
    private int[] elements;

    public int Size { get; }

    public DiagonalMatrix(params int[] diagonalElements)
    {
        if (diagonalElements.Length == 0)
        {
            Size = 0;
        }
        else
        {
            Size = diagonalElements.Length;
            elements = new int[Size];
            Array.Copy(diagonalElements, elements, Size);
        }
    }

    public int this[int i, int j]
    {
        get
        {
            if (this.IsOutOfBounds(i, j) || !this.IsDiagonalElement(i, j))
                return 0;
            return elements[i];
        }
        set
        {
            if (!this.IsOutOfBounds(i, j) && this.IsDiagonalElement(i, j))
                elements[i] = value;
        }
    }

    public double Track()
    {
        double sum = 0;

        for (int i = 0; i < Size; i++)
        {
            sum += elements[i];
        }

        return sum;
    }

    public override bool Equals(object? obj)
    {

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        DiagonalMatrix? otherMatrix = obj as DiagonalMatrix;


        if (otherMatrix == null || Size != otherMatrix.Size)
        {
            return false;
        }

        for (int i = 0; i < Size; i++)
        {
            if (this[i, i] != otherMatrix[i, i])
            {
                return false;
            }
        }

        return true;
    }

    public DiagonalMatrix Add(DiagonalMatrix matrix)
    {
        int newSize = Math.Max(Size, matrix.Size);
        int[] resultElements = new int[newSize];

        for (int i = 0; i < newSize; i++)
        {
            int diagonalValue1 = (i < Size) ? this[i, i] : 0;
            int diagonalValue2 = (i < matrix.Size) ? matrix[i, i] : 0;
            resultElements[i] = diagonalValue1 + diagonalValue2;
        }

        return new DiagonalMatrix(resultElements);
    }
}

