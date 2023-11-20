namespace ItAcademiaCsh.Homework._30_10Homework5;

class Bus
{
    private int? _maxSeats;
    private int? _maxSpeed;
    private int _speed = 0;

    public int? MaxSeats
    {
        get => _maxSeats;
        private set
        {
            if (value < 1)
            {
                throw new Exception("В автобусе нет мест!");
            }

            _maxSeats = value;
            SeatAvailability = true;
        }
    }

    public int? MaxSpeed
    {
        get => _maxSpeed;
        private set
        {
            if (value < 1)
            {
                throw new Exception("Автобус сломан (value < 1)!");
            }

            _maxSpeed = value;
        }
    }

    public int Speed
    {
        get => _speed;
        private set
        {
            var byf = _speed + value;
            if (byf > _maxSpeed)
            {
                throw new Exception("Автобус не может превышать разрешенную скорость!");
            }

            if (byf < 0)
            {
                throw new Exception("Автобус не умеет ездить задним ходом");
            }

            _speed = byf;
            SeatAvailability = byf == 0;
        }
    }

    public List<string?> PassengerSurnames { get; } = new List<string?>();
    public bool SeatAvailability { get; private set; } = false;
    public Dictionary<int, string?> BusPlaces { get; private set; } = new Dictionary<int, string?>() { };

    /// <param name="maxSeats"> если меньше 1 вызовет Exception </param>
    /// <param name="maxSpeed"> если меньше 1 вызовет Exception</param>
    public Bus(int maxSeats, int maxSpeed)
    {
        MaxSeats = maxSeats;
        MaxSpeed = maxSpeed;
        for (var i = 0; i < _maxSeats; i++)
        {
            BusPlaces[i] = null;
        }
    }

    public void SpeedIncrease(int value) => Speed = value;

    public void DecreaseSpeed(int value) => Speed = -value;

    public void BoardPassenger(List<string> passengerSurnames)
    {
        if (!SeatAvailability)
        {
            throw new Exception("Пассадка запрещена!");
        }

        var didntBoard = "";
        foreach (var surnames in passengerSurnames)
        {
            if (PassengerSurnames.Contains(surnames))
            {
                continue;
            }

            if (PassengerSurnames.Count < _maxSeats)
            {
                PassengerSurnames.Add(surnames);
                for (var i = 0; i < _maxSeats; i++)
                {
                    if (BusPlaces[i] == null)
                    {
                        BusPlaces[i] = surnames;
                        break;
                    }
                }
            }
            else
            {
                didntBoard += surnames;
            }
        }

        if (didntBoard != "")
        {
            SeatAvailability = false;
            throw new Exception("Нет мест для: " + didntBoard);
        }
    }

    public void DisembarkPassenger(List<string> passengerSurnames)
    {
        if (!SeatAvailability)
        {
            throw new Exception("Высадка запрещена!");
        }

        var noPassenger = "";

        foreach (var surname in passengerSurnames)
        {
            if (PassengerSurnames.Remove(surname))
            {
                for (var i = 0; i < _maxSeats; i++)
                {
                    if (BusPlaces[i] == surname)
                    {
                        BusPlaces[i] = null;
                        break;
                    }
                }
                SeatAvailability = true;
            }
            else
            {
                noPassenger += surname + " ";
            }
        }

        if (noPassenger != "")
        {
            throw new Exception("Пассажиры не найдены: " + noPassenger);
        }
    }
}