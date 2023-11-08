namespace ItAcademiaCsh.Homework._23_10Homework4;

class BeeElephant
{
    private int beePart;
    private int elephantPart;

    public BeeElephant(int beePart, int elephantPart)
    {
        this.beePart = beePart;
        this.elephantPart = elephantPart;
    }

    public bool Fly()
    {
        return beePart >= elephantPart;
    }

    public string Trumpet()
    {
        return elephantPart >= beePart ? "tu-tu-doo-doo" : "wzzzz";
    }

    public void Eat(string meal, int value)
    {
        switch (meal)
        {
            case "nectar":
                elephantPart -= value;
                beePart += value;
                break;
            case "grass":
                elephantPart += value;
                beePart -= value;
                break;
        }

        elephantPart = elephantPart switch
        {
            > 100 => 100,
            < 0 => 0,
            _ => elephantPart
        };

        beePart = beePart switch
        {
            > 100 => 100,
            < 0 => 0,
            _ => beePart
        };
    }
}