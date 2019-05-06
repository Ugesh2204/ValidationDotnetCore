using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Data;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext db;

        public EmployeeController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
    }
}