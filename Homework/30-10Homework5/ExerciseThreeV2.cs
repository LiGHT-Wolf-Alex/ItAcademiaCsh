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

        if (!string.IsNullOrEmpty(text?.Trim()))
        {
            text = Encrypt(text, encryptionStep);
            Console.WriteLine($"Encrypted string => {text}");
            Console.WriteLine($"Decrypted string => {Decrypt(text, encryptionStep)}");
        }
    }

    private string Encrypt(string text, int encryptionStep)
    {
        string encryptedText = "";
        foreach (char itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                if (itemChar < 1000)
                {
                    char start = char.IsUpper(itemChar) ? 'A' : 'a';
                    encryptedText += (char)((((itemChar + encryptionStep) - start) % 26) + start);
                }
                else
                {
                    char start = char.IsUpper(itemChar) ? 'А' : 'а';
                    encryptedText += (char)((((itemChar + encryptionStep) - start) % 32) + start);
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
        string encryptedText = "";
        foreach (char itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                if (itemChar < 1000)
                {
                    char start = char.IsUpper(itemChar) ? 'A' : 'a';
                    encryptedText += (char)((((itemChar + (26 - encryptionStep)) - start) % 26) + start);
                }
                else
                {
                    char start = char.IsUpper(itemChar) ? 'А' : 'а';
                    encryptedText += (char)((((itemChar + (32 - encryptionStep)) - start) % 32) + start);
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