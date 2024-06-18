public class ListDataAccess: IDataAccess
{
    public ListDataAccess()
    {

    }

    public static List<Product> Products = new List<Product>()
    {
        new Product() { Name = "Toilet", Price = 12.99},
        new Product() { Name = "Locket", Price = 59.99},
        new Product() { Name = "Harmonica", Price = 120.99},
        new Product() { Name = "Empty Jar", Price = 159.99},
        new Product() { Name = "Ribbon", Price = 65.99},
        new Product() { Name = "Seed Packet", Price = 250.99},
        new Product() { Name = "Perfume", Price = 120.99}
    };

    public List<Product> LoadData()
    {
        Console.WriteLine("Loading List Data...");

        return Products;
    }
    public void SaveData()
    {
        Console.WriteLine("Saving List Data...");
    }
}