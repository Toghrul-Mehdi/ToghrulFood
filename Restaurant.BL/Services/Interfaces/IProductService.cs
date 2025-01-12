using Restaurant.BL.VM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductCreateVM vm);
        Task UpdateAsync(ProductUpdateVM vm);
        Task<ICollection<ProductGetVM>> GetAllAsync();
    }
}
