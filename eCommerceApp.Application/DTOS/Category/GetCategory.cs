using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Application.DTOS.Product;

namespace eCommerceApp.Application.DTOS.Category
{
    public class GetCategory:CategoryBase
    {
       
        public Guid Id { get; set; }
        public GeTProduct? Product { get; set; }
    }
}
