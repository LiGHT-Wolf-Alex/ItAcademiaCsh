namespace ItAcademiaCsh.ControlWork._13_11;

public static class IntExtensions
{
    public static string ToWords(this int number)
    {

        var byfer = number;
        while (byfer != 0)
        {
            
            
        }
        string[] units =
        {
            "ноль", "один", "два", "три", "четыре",
            "пять", "шесть", "семь", "восемь", "девять"
        };
        if (number == 0 )
        {
            return "минус " + Math.Abs(number).ToWords();
        }
        return units[number];
    }
}