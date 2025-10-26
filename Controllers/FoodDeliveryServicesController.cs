using Lab5.Data;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lab5.Controllers
{
    public class FoodDeliveryServicesController : Controller
    {
        private readonly DealsFinderDbContext _context;
        public FoodDeliveryServicesController(DealsFinderDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var services = _context.FoodDeliveryServices.ToList();
            return View(services);
        }
    }
}
