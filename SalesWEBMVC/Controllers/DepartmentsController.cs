using Microsoft.AspNetCore.Mvc;
using SalesWEBMVC.Models;
using System.Collections.Generic;

namespace SalesWEBMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Computer" });

            return View(list);
        }
    }
}
