namespace ItAcademiaCsh.Homework._30_10Homework5;

public class ExerciseThree : IHomework
{
    public string DateIssueTask { get; } = "30.10.2023";
    public char TaskNumber { get; } = '3';

    public readonly string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэяabcdefghijklmnopqrstuvwxyz";

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
            text = CaesarEncryption(text, encryptionStep);
            Console.WriteLine(text);
        }
    }

    private string CaesarEncryption(string text, int encryptionStep)
    {
        var encryptedText = "";
        var isUpercase = false;

        foreach (var itemChar in text)
        {
            if (char.IsLetter(itemChar))
            {
                char itemByfChar;
                if (char.IsUpper(itemChar))
                {
                    itemByfChar = char.ToLower(itemChar);
                    isUpercase = true;
                }
                else
                {
                    itemByfChar = itemChar;
                }

                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (i < 32 && itemByfChar == Alphabet[i])
                    {
                        encryptedText += Encryption(Alphabet[..32], in encryptionStep, in i, ref isUpercase);
                        break;
                    }

                    if (i >= 32 && itemByfChar == Alphabet[i])
                    {
                        encryptedText += Encryption(Alphabet[32..], in encryptionStep, i - 32, ref isUpercase);
                        break;
                    }
                }
            }
            else
            {
                encryptedText += itemChar.ToString();
            }
        }

        return encryptedText;
    }

    private string Encryption(string alphabet, in int encryptionStep, in int i, ref bool isUpercase)
    {
        if (i + encryptionStep <= alphabet.Length - 1)
        {
            if (isUpercase)
            {
                isUpercase = false;
                return alphabet[i + encryptionStep].ToString().ToUpper();
            }

            return alphabet[i + encryptionStep].ToString();
        }

        var wentBeyondBoundaries = (i + encryptionStep) - alphabet.Length;
        while (wentBeyondBoundaries > alphabet.Length - 1)
        {
            wentBeyondBoundaries = (i + encryptionStep) - alphabet.Length;
        }

        if (isUpercase)
        {
            isUpercase = false;
            return alphabet[wentBeyondBoundaries].ToString().ToUpper();
        }

        return alphabet[wentBeyondBoundaries].ToString();
    }
}