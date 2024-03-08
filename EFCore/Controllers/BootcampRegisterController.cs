using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Controllers
{
    public class BootcampRegisterController : Controller
    {
        private readonly DataContext _context;
        public BootcampRegisterController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Students = new SelectList(await _context.Students.ToListAsync(), "StudentId", "NameSurname");
            ViewBag.Bootcamps = new SelectList(await _context.Bootcamps.ToListAsync(), "CourseId", "CourseName");

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var bootcampRegistrations = await _context.
        RegisteredUsers
        .Include(x => x.Student)
        .Include(x => x.Course)
        .ToListAsync();
            return View(bootcampRegistrations);
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisteredUsers model)
        {
            model.RegistrationDate = DateTime.Now;
            _context.RegisteredUsers.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var registeredUser = await _context.RegisteredUsers.FindAsync(id);
            if (registeredUser == null)
            {
                return NotFound();
            }
            return View(registeredUser);
        }



    }
}