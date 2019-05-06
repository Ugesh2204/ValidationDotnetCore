using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Data;
using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormValidation.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext db;

        public EmployeeController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Employees.ToListAsync());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }


        //Add Method 
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            //Retriving Image from Http Context

            if (ModelState.IsValid)
            {
                //if is valid we will retrive the files
                var files = HttpContext.Request.Form.Files;
                //check files is not zero - Null
                if (files[0] != null && files[0].Length > 0)
                {
                    //convert it into byte
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }

                    employee.Picture = p1;

                    db.Employees.Add(employee);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }

            }

            return View(employee);
        }
    }
}