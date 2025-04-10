using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Domain.Interfaces;
using eCommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerceApp.Infrastructure.Repository
{
    public class GenericRepo<TEntity>(AppDbContext context) : IGeneric<TEntity> where TEntity : class
    {
       public async Task<int> AddAsync(TEntity entity)
        {
           context.Set<TEntity>().Add(entity);
            return await context.SaveChangesAsync();
        }

       public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
          return await context.Set<TEntity>().AsNoTracking().ToArrayAsync();
        }

       public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var result=await context.Set<TEntity>().FindAsync(id);
            return result!;
        }

      public  async Task<int> UpdateAsync(TEntity entity)
        {
           context.Set<TEntity>().Update(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
           var entity=await context.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                context.Set<TEntity>().Remove(entity);
                return await context.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException($"Item with {id} not found");
            }
        }
    }
}
