using Microsoft.AspNetCore.Mvc;
using WebApplicationCrud2.Data;
using WebApplicationCrud2.Models;
using WebApplicationCrud2.Models.Domain;

namespace WebApplicationCrud2.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;
        public EmployeesController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;

        }
    
    
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
    [HttpPost]
    public IActionResult Add(AddEmployeeViewModel addEmployeeRequest)
    {
        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            Name = addEmployeeRequest.Name,
            Salary = addEmployeeRequest.Salary,
            Email = addEmployeeRequest.Name,
        };

        mvcDemoDbContext.Employees.Add(employee)

            }
}

