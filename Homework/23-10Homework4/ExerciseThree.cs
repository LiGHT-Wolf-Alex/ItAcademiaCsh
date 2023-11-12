namespace ItAcademiaCsh.Homework._23_10Homework4;

public class ExerciseThree : IHomework
{
    public string DateIssueTask { get; } = "23.10.2023";
    public char TaskNumber { get; } = '3';

    public void CompletingTask()
    {
        var myArray = new int[] { 23, 43, 5, 2, 5, 23, 6, 9, 23, 23, 5, 3, 6, 32 };

        Console.Write("Array => ");
        foreach (var i in myArray)
        {
            Console.Write($"[{i}]; ");
        }

        Console.WriteLine();

        var isAllElementsUnique = true;

        Array.Sort(myArray);
        for (int i = 0, quantity; i < myArray.Length; i++)
        {
            quantity = 1;
            while ((i + 1 < myArray.Length) && (myArray[i] == myArray[i + 1]))
            {
                quantity++;
                i++;
            }

            if (quantity != 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{myArray[i - 1]} repeat => {quantity} ");
                isAllElementsUnique = false;
            }
        }

        if (isAllElementsUnique)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All elements are unique.");
        }
    }
}