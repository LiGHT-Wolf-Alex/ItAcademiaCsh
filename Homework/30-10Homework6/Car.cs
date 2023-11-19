namespace ItAcademiaCsh.Homework._30_10Homework6;

public class Car
{
    private string _color;
    private string _type;
    private int? _year;

    public Car(string color, string type, int year)
    {
        _color = color;
        _type = type;
        _year = year;
    }

    public void Start()
    {
        Console.WriteLine("Автомобиль заведён");
    }

    public void Stop()
    {
        Console.WriteLine("Автомобиль заглушен");
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public void SetYear(int year)
    {
        if (year >= 1886)
        {
            _year = year;
        }
        else
        {
            _year = null;
            Console.WriteLine("Год выпуска не может быть меньше < 1886 г.");
        }
    }
}