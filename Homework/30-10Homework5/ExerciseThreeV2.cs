namespace ItAcademiaCsh.Homework._30_10Homework5;

public class ExerciseThreeV2 : IHomework
{
    public string DateIssueTask { get; } = "30.10.2023";
    public char TaskNumber { get; } = '3';

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

        if (Console.ReadKey().Key == ConsoleKey.E)
        {
            Console.WriteLine($"\r\nEncrypted string => {Encrypt(text, encryptionStep)}");
        }
        else if (Console.ReadKey().Key == ConsoleKey.D)
        {
            Console.WriteLine($"\r\nDecrypted string => {Decrypt(text, encryptionStep)}");
        }
    }

    private string Encrypt(string text, int encryptionStep)
    {
        string encryptedText = "";
        foreach (var itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                var numberLetters = 32;
                if (itemChar < 1000)
                {
                    numberLetters = 26;
                    var start = char.IsUpper(itemChar) ? 'A' : 'a';
                    encryptedText += (char)((((itemChar + encryptionStep) - start) % numberLetters) + start);
                }
                else if (itemChar is 'ё' or 'Ё')
                {
                    var start = char.IsUpper(itemChar) ? 'А' : 'а';
                    var item = char.IsUpper(itemChar) ? 1046 : 1078;
                    encryptedText += (char)((((itemChar + encryptionStep) - start) % numberLetters) + start);
                }
                else
                {
                    char start;
                    int step;
                    if (char.IsUpper(itemChar))
                    {
                        start = 'А';
                        step = (itemChar < 1046) ? encryptionStep : encryptionStep + 1;
                        encryptedText += (char)((((itemChar + step) - start) % numberLetters) + start);
                    }
                    else
                    {
                        start = 'а';
                        step = (itemChar < 1078) ? encryptionStep : encryptionStep + 1;
                        encryptedText += (char)((((itemChar + step) - start) % numberLetters) + start);
                    }
                    
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
                int numberOfLetters;
                if (itemChar < 1000)
                {
                    numberOfLetters = 26;
                    var start = char.IsUpper(itemChar) ? 'A' : 'a';
                    encryptedText += (char)((((itemChar + (26 - encryptionStep)) - start) % numberOfLetters) + start);
                }
                else
                {
                    numberOfLetters = 32;
                    var start = char.IsUpper(itemChar) ? 'А' : 'а';
                    encryptedText += (char)((((itemChar + (32 - encryptionStep)) - start) % numberOfLetters) + start);
                }
            }
            else
            {
                encryptedText += itemChar;
            }
        }
        
        return encryptedText;
    }
}