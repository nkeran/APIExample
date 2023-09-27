using APIExample.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace APIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOffersController : ControllerBase
    {
        OfferServices offerServices;
        public ProductOffersController(OfferServices objofferServices)
        {
            this.offerServices = objofferServices;
        }
        

        [HttpPost]
        public void AddProducts(Product product)
        {
            offerServices.GetAllProducts().Add(product);
        }
        [HttpGet]
        public List<Product> GetProducts()
        {

          return offerServices.GetAllProducts().Take(3).OrderBy(i => i.Price).ToList();
        }
        [HttpGet]
        public List<Product> GetTodayOffers()
        {

            return offerServices.GetTodaysOffers();
        }
        [HttpGet]
        public Product GetSecondLowest()
        {

            return offerServices.GetAllProducts().Take(2).OrderBy(i=>i.Price).ToList()[1];
        }
    }
}
