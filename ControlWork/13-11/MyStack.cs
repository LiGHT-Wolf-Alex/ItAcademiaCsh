namespace ItAcademiaCsh.ControlWork._13_11;

public class MyStack
{
    private int[] stackArray;
    private int indexTopElementStack = -1; //-1 - пустой стек

    public MyStack(int size)
    {
        if (size > 0)
        {
            stackArray = new int[size];
        }
        else
        {
            Console.WriteLine("размер стека не может быть меньше 1");
        }
    }

    public void Push(int element)
    {
        if (stackArray == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некоректно создан стек");
            Console.ForegroundColor = default;
            return;
        }

        if (indexTopElementStack == stackArray.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Стек переполнен");
            Console.ForegroundColor = default;
            return;
        }

        stackArray[++indexTopElementStack] = element;
    }

    public int? Pop()
    {
        if (stackArray == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Некоректно создан стек");
            Console.ForegroundColor = default;
            return null;
        }

        if (indexTopElementStack == -1)
        {
            Console.WriteLine("Стек пустой");
            return 0;
        }

        return stackArray[indexTopElementStack--];
    }
}