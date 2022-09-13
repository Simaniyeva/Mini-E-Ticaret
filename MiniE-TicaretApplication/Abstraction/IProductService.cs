using MiniE_Ticaret.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniE_TicaretApplication.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
