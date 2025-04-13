using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Application.DTOS.Product;
using eCommerceApp.Application.DTOS.Response;

namespace eCommerceApp.Application.Services.Interfaces
{
   public interface IProductService
    {
        Task<IEnumerable<GeTProduct>> GetAllAsync();
        Task<GeTProduct> GetByIdAsync(Guid id);
        Task<ServiceResponse> AddAsync(CreateProduct product);
        Task<ServiceResponse> UpdateAsync(UpdateProduct product);
        Task<ServiceResponse> DeleteAsync(Guid id);
    }
}
