using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormValidation.Data;
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
    }
}