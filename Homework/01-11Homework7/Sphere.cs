namespace ItAcademiaCsh.Homework._01_11Homework7;

public class Sphere
{
    private double _radius;
    private double _x;
    private double _y;
    private double _z;

    public Sphere()
    {
        _radius = 1;
        _x = 0;
        _y = 0;
        _z = 0;
    }

    public Sphere(double radius)
    {
        _radius = radius;
        _x = 0;
        _y = 0;
        _z = 0;
    }

    public Sphere(double radius, double x, double y, double z)
    {
        _radius = radius;
        _x = x;
        _y = y;
        _z = z;
    }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    public double GetSquare()
    {
        return 4 * Math.PI * Math.Pow(_radius, 2);
    }

    public string GetCenter()
    {
        return $"{_x} {_y} {_z}";
    }

    public void SetCenter(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }

    public bool IsPointInside(double x, double y, double z)
    {
        double distance = Math.Sqrt(Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2) + Math.Pow(z - _z, 2));

        return distance <= _radius;
    }
}