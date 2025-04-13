using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Application.DTOS.Category;
using eCommerceApp.Application.DTOS.Response;
using eCommerceApp.Application.Services.Interfaces;

namespace eCommerceApp.Application.Services.Implementations
{
    class CategoryService : ICategoryService
    {
        public Task<ServiceResponse> AddAsync(CreateCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategory> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse> UpdateAsync(CreateCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
