namespace ItAcademiaCsh.Homework._30_10Homework5;

public class ExerciseThreeV2 : IHomework
{
    public string DateIssueTask { get; } = "30.10.2023";
    public char TaskNumber { get; } = '3';
    public readonly string AlphabetRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public void CompletingTask()
    {
        Console.Write("Enter the string => ");
        var text = Console.ReadLine();
        Console.Write("Enter the encryption step => ");
        if (!int.TryParse(Console.ReadLine(), out var encryptionStep))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR IN ENCRYPTION STEP");
            Console.ForegroundColor = default;
            return;
        }

        if (string.IsNullOrEmpty(text?.Trim()))
        {
            Console.WriteLine("The line is empty");
            return;
        }

        Console.WriteLine("What would you like to do, encrypt and decrypt the message?");
        Console.Write("press: e - encrypt or d - decrypt => ");

        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.E)
        {
            Console.WriteLine($"\r\nEncrypted string => {Encrypt(text, encryptionStep)}");
        }
        else if (key.Key == ConsoleKey.D)
        {
            Console.WriteLine($"\r\nDecrypted string => {Decrypt(text, encryptionStep)}");
        }
    }

    private string Encrypt(string text, int encryptionStep)
    {
        var encryptedText = "";

        foreach (var itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                if (itemChar < 1000)
                {
                    encryptedText += EnglishEncoder(itemChar, encryptionStep);
                }
                else
                {
                    encryptedText += RussianEncoder(itemChar, encryptionStep);
                }
            }
            else
            {
                encryptedText += itemChar;
            }
        }

        return encryptedText;
    }

    private string Decrypt(string text, int encryptionStep)
    {
        var encryptedText = "";

        foreach (var itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                int numberLetters;
                if (itemChar < 1000)
                {
                    numberLetters = 26;
                    encryptedText += EnglishEncoder(itemChar, numberLetters - encryptionStep);
                }
                else
                {
                    numberLetters = 33;
                    encryptedText += RussianEncoder(itemChar, numberLetters - encryptionStep);
                }
            }
            else
            {
                encryptedText += itemChar;
            }
        }

        return encryptedText;
    }

    private char RussianEncoder(char item, int encryptionStep)
    {
        var isLargeText = false;
        const int numberLetters = 33;

        if (char.IsUpper(item))
        {
            isLargeText = true;
            item = char.ToLower(item);
        }

        var index = 0;
        while (item != AlphabetRus[index])
        {
            index++;
        }

        int letterNumber = (index + encryptionStep) % numberLetters;
        return isLargeText ? char.ToUpper(AlphabetRus[letterNumber]) : AlphabetRus[letterNumber];
    }

    private char EnglishEncoder(char item, int encryptionStep)
    {
        const int numberLetters = 26;
        var start = char.IsUpper(item) ? 'A' : 'a';
        return (char)((item + encryptionStep - start) % numberLetters + start);
    }
}