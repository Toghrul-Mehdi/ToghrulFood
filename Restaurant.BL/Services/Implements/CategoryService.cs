using Restaurant.BL.Services.Interfaces;
using Restaurant.BL.VM.Category;
using Restaurant.CORE.Entities;
using Restaurant.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.BL.Services.Implements
{
    public class CategoryService(AppDbContext _context) : ICategoryService
    {
        public async Task CreateAsync(CategoryCreateVM vm)
        {            
            Category category = new Category
            {
                CategoryName = vm.CategoryName,
            };
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<CategoryGetVM>> GetAllAsync()
        {
            /* return await _context.Categories.Where(x => !x.IsDeleted).Select(x => new CategoryGetVM
             {
                 CategoryName = x.CategoryName,
             }).ToListAsync();*/
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CategoryUpdateVM vm)
        {
            throw new NotImplementedException();
        }
    }
}
