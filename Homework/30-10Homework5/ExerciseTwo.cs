namespace ItAcademiaCsh.Homework._30_10Homework5;

public class ExerciseTwo : IHomework
{
    public string DateIssueTask { get; } = "30.10.2023";
    public char TaskNumber { get; } = '2';

    public void CompletingTask()
    {
        Console.Write("Enter the string => ");
        var text = Console.ReadLine();

        if (string.IsNullOrEmpty((text?.Trim())))
        {
            Console.WriteLine("LINE IS EMPTY ");
            return;
        }

        if (!text.Contains('h'))
        {
            Console.WriteLine("There is no 'h' in the line");
            return;
        }

        {
            var firstIndex = text.IndexOf("h", StringComparison.Ordinal);
            var lastIndex = text.LastIndexOf("h", StringComparison.Ordinal);

            text = text.Replace("h", "H");
            char[] replacingText = text.ToCharArray();
            replacingText[firstIndex] = replacingText[lastIndex] = 'h';
            text = new string(replacingText);

            /* или var replacingText = text.Substring(firstIndex, lastIndex).Replace("h", "H");
            text = text[..(firstIndex)] + replacingText + text[(lastIndex - 1)..];
            или  text = text[..(firstIndex)] + text[firstIndex..lastIndex].Replace("h", "H") + text[(lastIndex - 1)..];*/
        }

        Console.Write($"Replacement result => {text}");
    }
}