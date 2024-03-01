using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormApp.Controllers;

public class HomeController : Controller
{



    public IActionResult Index(string searchString, string category)
    {
        var product = Repository.Products;
        if (!String.IsNullOrEmpty(searchString))
        {
            ViewBag.SearchString = searchString;
            product = product.Where(p => p.BookName.ToLower().Contains(searchString)).ToList();
        }
        if (!String.IsNullOrEmpty(category) && category != "0")
        {
            product = product.Where(p => p.CategoryId == int.Parse(category)).ToList();
        }
        //ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        var model = new ProductViewModel
        {
            Products = product,
            Categories = Repository.Categories,
            SelectedCategory = category
        };
        return View(model);
    }
    public IActionResult Admin()
    {
        return View(Repository.Products);
    }


    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product model, IFormFile ImageFile)
    {
        var allowedExtensions = new[] { ".jpg", "jpeg", ".png" };
        string extension = "";

        if (ImageFile != null)
        {
            extension = Path.GetExtension(ImageFile.FileName);

            if (!allowedExtensions.Contains(extension))
            {
                ModelState.AddModelError("", "Please add add a picture in allowed format");
            }
        }

        var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);



        if (ModelState.IsValid)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await ImageFile.CopyToAsync(stream);
            }
            model.ProductId = Repository.Products.Count + 1;
            Repository.CreateProduct(model);
            return RedirectToAction("Index");
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(model);

    }


    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var entity = Repository.Products.FirstOrDefault(b => b.ProductId == id);
        if (entity == null)
        {
            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View(entity);
        }
        return View();
    }

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var entity = Repository.Products.FirstOrDefault(b => b.ProductId == id);
        if (entity == null)
        {
            return NotFound();
        }
        ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
        return View(entity);
    }


    [HttpPost]
    public async Task<IActionResult> Edit(int id, Product model, IFormFile ImageFile)
    {
        if (id != model.ProductId)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            if (ImageFile != null)
            {
                var allowedExtensions = new[]{
            var extension = Path.GetExtension(ImageFile.FileName);
                var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(stream);
                }
                model.Image = randomFileName;
            }
            Repository.EditProduct(model);
            return RedirectToAction("Admin");
        }

    }
}
