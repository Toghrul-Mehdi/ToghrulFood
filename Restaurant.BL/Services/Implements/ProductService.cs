using Restaurant.BL.Services.Interfaces;
using Restaurant.BL.VM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.Services.Implements
{
    public class ProductService : IProductService
    {
        public Task CreateAsync(ProductCreateVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ProductGetVM>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductUpdateVM vm)
        {
            throw new NotImplementedException();
        }
    }
}
