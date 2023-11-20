namespace ItAcademiaCsh.Homework._08_10Homework8;

class Product
{
    public string ProductName { get; set; }
    public string StoreName { get; set; }
    public double ProductCost { get; set; }

    public string GetInformation()
    {
        return $"ProductName: {ProductName}, StoreName: {StoreName}, ProductCost: {ProductCost} руб.";
    }
}

class Warehouse
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        _products.Remove(product);
    }

    public Product GetProductByIndex(int index)
    {
        if (index >= 0 && index < _products.Count)
        {
            return _products[index];
        }
        else
        {
            throw new IndexOutOfRangeException("inadmissible index");
        }   
    }

    public Product GetProductByName(string name)
    {
        var productByName = _products.Find(goods => goods.ProductName == name);
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

internal class Program
{
    static void _Main()
    {
        var warehouse = new Warehouse();

        var product1 = new Product { ProductName = "Cargo1", StoreName = "Store1", ProductCost = 100 };
        var product2 = new Product { ProductName = "Cargo2", StoreName = "Store2", ProductCost = 200 };
        var product3 = new Product { ProductName = "Cargo3", StoreName = "store3", ProductCost = 300 };

        warehouse.AddProduct(product1);
        warehouse.AddProduct(product2);
        warehouse.AddProduct(product3);

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