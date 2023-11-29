namespace ItAcademiaCsh.Homework._27_11Homework9._1_Lesson;

public class Truck : Vehicle
{
    private string _model = null!;
    private float _liftingСapacity = 0.0f;

    public string Model { get; set; }

    public float LiftingСapacity
    {
        get => _liftingСapacity;
        set
        {
            if (value >= 0 && value <= 1000)
                _liftingСapacity = value;
            else
                throw new Exception("Incorrect lift capacity!");
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Lifting Capacity: {_liftingСapacity}");
    }
}