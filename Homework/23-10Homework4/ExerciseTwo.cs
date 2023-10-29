namespace ItAcademiaCsh.Homework._23_10Homework4;

public class ExerciseTwo : IHomework
{
    public string DateIssueTask { get; } = "23.10.2023";
    public char TaskNumber { get; } = '2';

    public void CompletingTask()
    {
        Console.Write("Enter the number of array elements => ");
        int.TryParse(Console.ReadLine(), out var arraySIze);

        var myArray = new float [arraySIze];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"[{i}] = ");
            float.TryParse(Console.ReadLine(), out myArray[i]);
        }

        float max = myArray[0], min = myArray[0];

        for (int i = 1; i < myArray.Length; i++)
        {
            if (max < myArray[i])
            {
                max = myArray[i];
                continue;
            }

            if (min > myArray[i])
            {
                min = myArray[i];
            }
        }

        Console.WriteLine($"max = {max}; min = {min}");
        Console.WriteLine($"Difference between maximum and minimum in an array => {max - min}");
    }
}