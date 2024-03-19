using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();

            list.Add(new Departament { Id = 1, name="Eletronics" });
            list.Add(new Departament { Id = 2, name="Fashion" });

            return View(list);
        }
    }
}
