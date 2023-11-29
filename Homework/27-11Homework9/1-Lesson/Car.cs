namespace ItAcademiaCsh.Homework._27_11Homework9._1_Lesson;

public class Car : Vehicle
{
    private int _numberDoors = 0;
    private int _fuel = 0;

    public int NumberDoors
    {
        get => _numberDoors;
        set
        {
            if (value >= 0 && value <= 4)
                _numberDoors = value;
            else
                throw new Exception("Неверное количество дверей!");
        }
    }

    public int Fuel
    {
        get => _fuel;
        set
        {
            if (value >= 0 && value <= 100)
                _fuel = value;
            else
                throw new Exception("Неверное количество топлив!");
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {_numberDoors}");
        Console.WriteLine($"Fuel: {_fuel}");
    }
}