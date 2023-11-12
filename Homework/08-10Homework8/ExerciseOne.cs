namespace ItAcademiaCsh.Homework._08_10Homework8;


class Product
{
    public string ProductName { get; set; }
    public string StoreName { get; set; }
    public double TheCostOfTheGoodsD { get; set; }

    public string GetInformation()
    {
        return $"ProductName: {ProductName}, StoreName: {StoreName}, TheCostOfTheGoodsD: {TheCostOfTheGoodsD} руб.";
    }
}

class Warehouse
{
    private List<Product> Products = new List<Product>();

    public void AddAProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public Product GetProductByIndex(int index)
    {
        if (index >= 0 && index < Products.Count)
        {
            return Products[index];
        }
        else
        {
            throw new IndexOutOfRangeException("inadmissible index");
        }
    }

    public Product GetProductByName(string name)
    {
        var productByName = Products.Find(товар => товар.ProductName == name);
        if (productByName != null)
        {
            return productByName;
        }
        else
        {
            throw new Exception("Product with this name was not found");
        }
    }
}

class Program
{
    static void _Main()
    {
        var warehouse = new Warehouse();

        var product1 = new Product { ProductName = "Cargo1", StoreName = "Store1", TheCostOfTheGoodsD = 100 };
        var product2 = new Product { ProductName = "Cargo2", StoreName = "Store2", TheCostOfTheGoodsD = 200 };
        var product3 = new Product { ProductName = "Cargo3", StoreName = "store3", TheCostOfTheGoodsD = 300 };

        warehouse.AddAProduct(product1);
        warehouse.AddAProduct(product2);
        warehouse.AddAProduct(product3);

        Console.WriteLine(warehouse.GetProductByIndex(0).GetInformation());

        try
        {
            var productByName = warehouse.GetProductByName("Cargo2");
            Console.WriteLine(productByName.GetInformation());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}