using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Data;
using FormValidation.Models;
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



        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            db.Add(employee);
            db.SaveChanges();

            return View(employee);

        }
    }
}