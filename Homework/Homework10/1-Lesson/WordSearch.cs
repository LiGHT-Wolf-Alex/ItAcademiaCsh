namespace ItAcademiaCsh.Homework.Homework10._1_Lesson;

public class WordSearch
{
    private const string InputFilePath = @"input.txt";
    private const string OutputFilePath = @"output.txt";

    public WordSearch()
    {
        try
        {
            using (var reader = new StreamReader(InputFilePath))
            using (var writer = new StreamWriter(OutputFilePath))
            {
                while (reader.ReadLine() is { } line)
                {
                    var wordCounts = CountWords(line);

                    if (wordCounts.Count > 0)
                    {
                        var (key, value) = wordCounts.MaxBy(x => x.Value);

                        writer.WriteLine($"{key} {value}");
                    }
                }
            }

            Console.WriteLine("Done! The results have been written to the output file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please make sure the input file exists and try again.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    private Dictionary<string, int> CountWords(string? text)
    {
        var wordCounts = new Dictionary<string, int>();

        var words = text?.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (words == null) return wordCounts;
        foreach (var word in words)
        {
            if (!wordCounts.TryAdd(word, 1))
            {
                wordCounts[word]++;
            }
        }

        return wordCounts;
    }
}