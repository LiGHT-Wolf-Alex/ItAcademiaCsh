namespace ItAcademiaCsh.Homework._30_10Homework6;

public class Soda
{
    private readonly string _flavor;

    public Soda(string flavor = null)
    {
        _flavor = flavor;
    }

    public override string ToString()
    {
        if (_flavor != null)
        {
            return $"У вас газировка с {_flavor} вкусом";
        }
        else
        {
            return "У вас обычная газировка";
        }
    }
}