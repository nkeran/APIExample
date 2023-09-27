using APIExample.Model;
using Microsoft.AspNetCore.Mvc;

namespace APIExample.Controllers
{
    public class HomeController : Controller
    {
        OfferServices offerServices;
        public HomeController(OfferServices objofferServices) 
        { 
         this.offerServices= objofferServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
