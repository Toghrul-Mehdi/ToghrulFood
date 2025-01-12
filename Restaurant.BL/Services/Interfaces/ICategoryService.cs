using Restaurant.BL.VM.Category;
using Restaurant.BL.VM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryCreateVM vm);
        Task UpdateAsync(CategoryUpdateVM vm);
        Task<ICollection<CategoryGetVM>> GetAllAsync();
    }
}
