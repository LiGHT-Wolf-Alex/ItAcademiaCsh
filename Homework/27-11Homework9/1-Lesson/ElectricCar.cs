namespace ItAcademiaCsh.Homework._27_11Homework9._1_Lesson;

public class ElectricCar : Car
{
    private int _vehicleRange;
    private float _carCharge;

    public int VehicleRange
    {
        get => _vehicleRange;
        set
        {
            if (value >= 0)
                _vehicleRange = value;
            else
                throw new Exception("Incorrect vehicle range!");
        }
    }

    public float CarCharge
    {
        get => _carCharge;
        set
        {
            if (value >= 0 && value <= 100)
                _carCharge = value;
            else
                throw new Exception("Incorrect car charge!");
        }
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Vehicle Range: {_vehicleRange}");
        Console.WriteLine($"Car Charge: {_carCharge}");
    }
}