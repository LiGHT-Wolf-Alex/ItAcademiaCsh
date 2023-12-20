class Dish
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Dish(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Appetizer : Dish
{
    public Appetizer(string name, decimal price) : base(name, price)
    {
    }
}

class MainCourse : Dish
{
    public MainCourse(string name, decimal price) : base(name, price)
    {
    }
}

class Drink : Dish
{
    public Drink(string name, decimal price) : base(name, price)
    {
    }
}

class Dessert : Dish
{
    public Dessert(string name, decimal price) : base(name, price)
    {
    }
}

class Order
{
    private List<Dish> dishes;

    public Order()
    {
        dishes = new List<Dish>();
    }

    public void AddDish(Dish dish)
    {
        dishes.Add(dish);
    }

    public decimal CalculateTotal()
    {
        decimal total = dishes.Sum(dish => dish.Price);

        // скидк 10%, если есть десерт
        if (dishes.Any(dish => dish is Dessert))
        {
            total *= 0.9m;
            Console.WriteLine("Уииии, у вас скидка в 10% на весь заказ, вы красавчик(ца) =)!");
        }

        return total;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("Заказ:");

        foreach (var dish in dishes)
        {
            Console.WriteLine($"{dish.Name} - {dish.Price:C}");
        }

        Console.WriteLine($"Итого: {CalculateTotal():C}");
    }
}

class Program
{
    static void Main()
    {
        var order = new Order();
        order.AddDish(new Appetizer("Салат Цезарь", 150));
        order.AddDish(new MainCourse("Стейк", 300));
        order.AddDish(new Drink("Красное вино", 200));
        order.AddDish(new Dessert("Тирамису", 120));

        order.PrintReceipt();

        Console.ReadLine();
    }
}