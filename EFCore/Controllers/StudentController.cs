using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Controllers
{
    public class StudentController : Controller
    {

        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var student = await _context.Students.FindAsync(id);
            //var student = await _context.Students.FirstOrDefault(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        //tarayicidan gonderdigimiz verilerin dogrulugunu kontrol etmek icin
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                //eger ayni anda baska biri ayni veriyi degistirirse bunu engeller
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Students.Any(e => e.StudentId == student.StudentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }


                }
                return RedirectToAction("Index", "Student");
            }
            return View(student);
        }
    }
}