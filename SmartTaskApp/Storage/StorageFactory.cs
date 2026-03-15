namespace SmartTaskApp.Storage
{
    public class StorageFactory
    {
        public static IStorage Create(string type)
        {
            if (type == "json")
                return new JsonStorage();

            return new JsonStorage();
        }
    }
}