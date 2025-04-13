using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Application.DTOS.Product;
using eCommerceApp.Application.DTOS.Response;
using eCommerceApp.Application.Services.Interfaces;

namespace eCommerceApp.Application.Services.Implementations
{
    class ProductService() : IProductService
    {
        public Task<ServiceResponse> AddAsync(CreateProduct product)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GeTProduct>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GeTProduct> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> UpdateAsync(UpdateProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
