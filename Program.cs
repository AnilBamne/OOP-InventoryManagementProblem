namespace InventoryManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:/Users/ishwa/source/repos/c#208/InventoryManagement/InventoryManagement/Inventory.json";
            FetchInventoryDetails fetchInventoryDetails = new FetchInventoryDetails();
            Inventory data = fetchInventoryDetails.Read(path);
            Console.WriteLine(data.typesofRice.name);
            Console.WriteLine(data.typesofRice.weight);
            Console.WriteLine(data.typesofRice.price);

        }
    }
}