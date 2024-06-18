namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a database type: \nList \nSQL \nMongo");
            string type = Console.ReadLine();

            IDataAccess data = DataAccessFactory.GetDataAccessType(type);

            List<Product> products = data.LoadData();
            data.SaveData();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Product List:");
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i].Name}: ${products[i].Price}");
            }
        }
    }
}
