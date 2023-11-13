using ItAcademiaCsh.ControlWork._13_11;

namespace ItAcademiaCsh;

class Program
{
    private static void Main()
    {
        MyStack stack = new MyStack(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}