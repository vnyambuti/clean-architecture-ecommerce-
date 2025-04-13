using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Application.Exception
{
   public class ItemNotFound(string message):IOException(message)
    {
    }
}
