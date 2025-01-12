using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.BL.Services.Interfaces;
using Restaurant.BL.VM.Category;
using Restaurant.CORE.Entities;
using Restaurant.DAL.Context;

namespace Restaurant.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService _service ,AppDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateVM vm)
        {
            if(!ModelState.IsValid)
                return View();
            await _service.CreateAsync(vm);
            return RedirectToAction(nameof(Index));
        }
    }
}
