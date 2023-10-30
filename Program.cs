using ItAcademiaCsh.Homework._30_10Homework6;

namespace ItAcademiaCsh;

class Program
{
    private static void Main(string[] args)
    {
        Soda soda1 = new Soda("клубничным");
        Console.WriteLine(soda1);

        Soda soda2 = new Soda();
        Console.WriteLine(soda2);
    }
}