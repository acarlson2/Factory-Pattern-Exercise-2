public class SQLDataAccess: IDataAccess
{
    public SQLDataAccess()
    {

    }

    public static List<Product> Products = new List<Product>()
    {
        new Product() { Name = "Lego Set", Price = 12.99},
        new Product() { Name = "Nintendo Switch", Price = 59.99},
        new Product() { Name = "Amiibo", Price = 120.99},
        new Product() { Name = "Monitor", Price = 159.99},
        new Product() { Name = "Mouse", Price = 65.99},
        new Product() { Name = "Desk", Price = 250.99},
        new Product() { Name = "Power Supply", Price = 120.99}
    };

    public List<Product> LoadData()
    {
        Console.WriteLine("Loading SQL Data...");

        return Products;
    }
    public void SaveData()
    {
        Console.WriteLine("Saving SQL Data...");
    }
}