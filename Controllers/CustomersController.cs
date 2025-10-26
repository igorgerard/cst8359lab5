using Lab5.Data;
using Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lab5.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DealsFinderDbContext _context;
        public CustomersController(DealsFinderDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
    }
}
