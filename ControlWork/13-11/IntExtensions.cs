namespace ItAcademiaCsh.ControlWork._13_11;

public static class IntExtensions
{
    public static string ToWords(this int number)
    {

        var byfer = number.ToString();
        var text = "";
        
        foreach (var VARIABLE in byfer)
        {
            text += " "  + VARIABLE switch
            {
                '0' => "ноль",
                '1' => "один",
                '2' => "два",
                '3' => "три",
                '4' => "четыре",
                '5' => "пять",
                '6' => "шесть",
                '7' => "семь",
                '8' => "восемь",
                '9' => "девять"
            };
        }
        
        return text;
    }
}