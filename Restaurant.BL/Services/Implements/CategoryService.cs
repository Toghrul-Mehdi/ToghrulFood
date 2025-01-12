using Restaurant.BL.Services.Interfaces;
using Restaurant.BL.VM.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        public Task CreateAsync(CategoryCreateVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<CategoryGetVM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CategoryUpdateVM vm)
        {
            throw new NotImplementedException();
        }
    }
}
