using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Data;
using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormValidation.Controllers
{
    public class DepartmentController : Controller
    {
        readonly ApplicationDbContext db;

        public DepartmentController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            return View( await db.Departments.ToListAsync());
        }


        //Create Method#
       [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            db.Add(department);
            db.SaveChanges();

            return View(department);

        }

    }
}