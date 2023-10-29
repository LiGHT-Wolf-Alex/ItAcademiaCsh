namespace ItAcademiaCsh.Homework._30_10Homework5;

public class ExerciseOne : IHomework
{
    public string DateIssueTask { get; } = "30.10.2023";
    public char TaskNumber { get; } = '1';

    public void CompletingTask()
    {
        Console.Write("Enter n - where nxn is the size of the matrix => ");
        int.TryParse(Console.ReadLine(), out var arraySize);

        if (arraySize < 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The matrix must consist of more than 1 element");
            Console.ForegroundColor = default;
            return;
        }

        var matrix = new int [arraySize, arraySize];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}] => ");
                if (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.WriteLine("incorrectValue");
                    j--;
                }
            }
        }

        Console.Clear();
        MatrixOutput(matrix);

        int sumSideDiagonal = matrix[0, matrix.GetLength(1) - 1];
        int belowDiagonalSum = 0;

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            sumSideDiagonal += matrix[i, matrix.GetLength(1) - 1 - i];
            for (int j = matrix.GetLength(1) - 1; j >= matrix.GetLength(1) - i; j--)
            {
                belowDiagonalSum += matrix[i, j];
            }
        }

        Console.WriteLine($"Sum of elements of the secondary diagonal: {sumSideDiagonal}");
        Console.WriteLine($"Sum of elements under the secondary diagonal: {belowDiagonalSum}");
    }

    private void MatrixOutput(int[,] matrix)
    {
        Console.WriteLine("Matrix сreated");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}