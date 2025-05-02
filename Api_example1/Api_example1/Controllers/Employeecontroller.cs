using Microsoft.AspNetCore.Mvc;

namespace Api_example1.Controllers
{
    public class Employeecontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
