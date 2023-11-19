namespace ItAcademiaCsh.Homework._30_10Homework6;

public class Math
{
    public double Add(double item1, double item2) =>  item1 + item2;

    public double Subtract(double item1, double item2) => item1 - item2;

    public double Multiply(double item1, double item2) => item1 * item2;

    public double? Divide(double item1, double item2)
    {
        if (item2 != 0) return item1 / item2;
        Console.WriteLine("Деление на 0");
        return null;
    }
}