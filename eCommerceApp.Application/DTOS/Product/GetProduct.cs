using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceApp.Application.DTOS.Category;

namespace eCommerceApp.Application.DTOS.Product
{
   public class GeTProduct:ProductBase
    {
        public Guid Id { get; set; }

        public GetCategory? Category { get; set; }
    }
}
