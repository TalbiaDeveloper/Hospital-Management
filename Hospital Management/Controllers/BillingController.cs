using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class BillingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
