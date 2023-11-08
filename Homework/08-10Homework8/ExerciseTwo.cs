namespace ItAcademiaCsh.Homework._30_10Homework5;

public class Bus
{
    public int Speed { get; set; }
    public int MaxSeats { get; }
    public int MaxSpeed { get; }
    public List<string> PassengerSurnames { get; private set; } = new List<string>();
    public bool Availability { get; set; }
    public Dictionary<int, string> BusPlaces { get; } = new Dictionary<int, string>();

    public Bus(int maxSeats, int maxSpeed)
    {
        MaxSeats = maxSeats;
        MaxSpeed = maxSpeed;
    }

    public void BoardPassenger(string surname)
    {
        if (PassengerSurnames.Count < MaxSeats)
        {
            PassengerSurnames.Add(surname);
            BusPlaces[PassengerSurnames.Count] = surname;
        }
        else
        {
            Console.WriteLine("The bus is full. Unable to board passenger.");
        }
    }

    public void DisembarkPassenger(string surname)
    {
        if (PassengerSurnames.Contains(surname))
        {
            PassengerSurnames.Remove(surname);
            var place = 0;
            foreach (var item in BusPlaces)
            {
                if (item.Value == surname)
                {
                    place = item.Key;
                    break;
                }
            }
            BusPlaces.Remove(place);
        }
        else
        {
            Console.WriteLine("This passenger is not on the bus.");
        }
    }

    public void IncreaseSpeed(int value)
    {
        if ((Speed + value) <= MaxSpeed)
        {
            Speed += value;
        }
        else
        {
            Console.WriteLine("Unable to increase speed beyond the maximum speed limit.");
        }
    }

    public void DecreaseSpeed(int value)
    {
        if ((Speed - value) >= 0)
        {
            Speed -= value;
        }
        else
        {
            Console.WriteLine("Unable to decrease speed lower than 0.");
        }
    }
}