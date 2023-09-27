namespace APIExample.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Product()
        {

        }
        public Product(string productname,decimal price ,string desc)
        {
            this.ProductName = productname;
            this.Price=price;
            this.Description = desc;
        }
    }
}
