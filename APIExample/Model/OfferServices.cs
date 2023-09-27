using System.Security.Cryptography.Xml;

namespace APIExample.Model
{
    public class OfferServices
    {
        private List<Product> inventory = null;
        public OfferServices()

        {
            inventory = AddInventory();
        }
        public List<Product> GetAllProducts()
        {
            return inventory;
        }
        public List<Product> GetTodaysOffers()
        {
            Random random = new Random();
            random.Next(3, inventory.Count);
            return inventory;
        }
        private List<Product> AddInventory()
        {
            inventory = null;
            try
            {
               inventory.Add( new Product() { ProductName = "P1", Price = 100m, Description = "P1 Description" });
                inventory.Add(new Product() { ProductName = "P2", Price = 200m, Description = "P2 Description" });
                inventory.Add(new Product() { ProductName = "P3", Price = 300m, Description = "P3 Description" });
                inventory.Add(new Product() { ProductName = "P4", Price = 400m, Description = "P4 Description" });
                inventory.Add(new Product() { ProductName = "P5", Price = 500m, Description = "P5 Description" });
                inventory.Add(new Product() { ProductName = "P6", Price = 600m, Description = "P6 Description" });
            }
            catch (Exception ex)
            {

            }
            return inventory;
        }
    }
}
