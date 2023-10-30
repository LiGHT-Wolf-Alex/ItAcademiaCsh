namespace ItAcademiaCsh.Homework._30_10Homework6;

public class Math
{
    public void Add(double item1, double item2)
    {
        double result = item1 + item2;
        Console.WriteLine($"Результат сложения: {result}");
    }

    public void Subtract(double item1, double item2)
    {
        double result = item1 - item2;
        Console.WriteLine($"Результат вычитания: {result}");
    }

    public void Multiply(double item1, double item2)
    {
        double result = item1 * item2;
        Console.WriteLine($"Результат умножения: {result}");
    }

    public void Divide(double item1, double item2)
    {
        if (item2 != 0)
        {
            double result = item1 / item2;
            Console.WriteLine($"Результат деления: {result}");
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно");
        }
    }
}