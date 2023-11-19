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
        return string.IsNullOrWhiteSpace(_flavor) ? "У вас обычная газировка" : $"У вас газировка с {_flavor} вкусом";
    }
}