public class MongoDataAccess: IDataAccess
{
    public MongoDataAccess()
    {

    }

    public static List<Product> Products = new List<Product>()
    {
        new Product() { Name = "Microphone", Price = 12.99},
        new Product() { Name = "Speakers", Price = 59.99},
        new Product() { Name = "Piano", Price = 120.99},
        new Product() { Name = "Guitar (Acoustic)", Price = 159.99},
        new Product() { Name = "Drum Set", Price = 65.99},
        new Product() { Name = "Bass", Price = 250.99},
        new Product() { Name = "Ethereal Choir", Price = 120.99}
    };

    public List<Product> LoadData()
    {
        Console.WriteLine("Loading Mongo Data...");
        
        return Products;
    }
    public void SaveData()
    {
        Console.WriteLine("Saving Mongo Data...");
    }
}