using System.Text.RegularExpressions;

namespace ItAcademiaCsh.Homework.Homework10._2_lesson;

public class ForbiddenWords
{
    private const string ForbiddenWordsFilePath = "forbidden_words.txt";

    public ForbiddenWords()
    {
        Console.Write("Введите путь к файлу с текстом: ");
        var textFilePath = Console.ReadLine();

        var text = ReadFile(textFilePath);
        if (text == null)
        {
            Console.WriteLine("Ошибка при чтении файла с текстом.");
            return;
        }

        var forbiddenWords = ReadForbiddenWords(ForbiddenWordsFilePath);
        if (forbiddenWords == null)
        {
            Console.WriteLine("Ошибка при чтении файла с запрещенными словами.");
            return;
        }

        var censoredText = CensorText(text, forbiddenWords);
        Console.WriteLine(censoredText);
    }

    private string? ReadFile(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (Exception)
        {
            return null;
        }
    }

    private string[]? ReadForbiddenWords(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath)
                .SelectMany(line => line.Split(' '))
                .Select(word => word.ToLower())
                .ToArray();
        }
        catch (Exception)
        {
            return null;
        }
    }

    private string CensorText(string text, string[] forbiddenWords)
    {
        var pattern = string.Join("|", forbiddenWords.Select(word => "\\b" + word + "\\b"));
        return Regex.Replace(text, pattern, match => new string('*', match.Length), RegexOptions.IgnoreCase);
    }
}