namespace APIExample.Model
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer(string offername,List<Product> lstProducts)
        {
            this.OfferName= offername;
            this.Products = lstProducts;
        }
    }
}
