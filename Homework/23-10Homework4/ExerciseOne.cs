namespace ItAcademiaCsh.Homework._23_10Homework4;

public class ExerciseOne : IHomework
{
    public string DateIssueTask { get; } = "23.10.2023";
    public char TaskNumber { get; } = '1';

    public void CompletingTask()
    {
        Console.Write("Enter the number of array elements => ");
        int.TryParse(Console.ReadLine(), out var arraySIze);

        if (arraySIze < 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Array size must be greater than 2!");
            Console.ForegroundColor = default;
            return;
        }

        var myArray = new int[arraySIze];
        {
            var random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 100);
                Console.Write($"{myArray[i]}; ");
            }
        }

        int sum = 0;
        foreach (var item in myArray)
        {
            sum += item;
        }

        Console.WriteLine($"\r\nSum of all array elements => {sum}");
    }
}