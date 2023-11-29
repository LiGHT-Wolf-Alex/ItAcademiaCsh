namespace ItAcademiaCsh.Homework._27_11Homework9._1_Lesson;

public class Vehicle
{
    private float _weight = 0.0f;
    private int _maxSpeed = 0;

    public float Weight
    {
        get => _weight;
        set
        {
            if (value >= 0 && value <= 7000)
                _weight = value;
            else
                throw new Exception("Incorrect mass!");
        }
    }

    public int MaxSpeed
    {
        get => _maxSpeed;
        set
        {
            if (value >= 0 && value <= 400)
                _maxSpeed = value;
            else
                throw new Exception("Invalid maximum speed!");
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Weight: {_weight}");
        Console.WriteLine($"Max Speed: {_maxSpeed}");
    }
}