using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Application.DTOS.Response
{
   public record ServiceResponse(bool Success=false,String Message=null);
  
}
