class Program
{
    static void Main()
    {
        List<int> numbers = GenerateRandomNumbers(9);
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        var result = numbers
            .OrderBy(x => x)
            .Skip(numbers.Count / 2)
            .OrderByDescending(x => x)
            .Select(x => x * x).ToArray();

        Console.WriteLine("Отсортированная по убыванию вторая половина коллекции:");
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }

        Console.ReadLine();
    }

    static List<int> GenerateRandomNumbers(int count)
    {
        var random = new Random();
        return Enumerable.Range(1, count)
            .Select(_ => random.Next(1, 100))
            .ToList();
    }
}


// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = { 9, 6, 2, 7, 1, 8, 5, 3, 4 };
//
//         var sortedNumbers = numbers.OrderBy(n => n).ToArray();
//
//         var halfIndex = (int)Math.Ceiling(sortedNumbers.Length / 2.0);
//
//         var secondHalf = sortedNumbers.Skip(halfIndex).ToArray();
//
//         var result = secondHalf.OrderByDescending(n => n).Select(n => n * n).ToArray();
//
//         Console.WriteLine("Отсортированная и возведённая в квадрат вторая половина коллекции:");
//         foreach (var number in result)
//             Console.WriteLine(number);
//     }
// }