using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCrud2.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
