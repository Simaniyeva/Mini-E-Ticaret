using Microsoft.Extensions.DependencyInjection;
using MiniE_Ticaret.Persistance.Concrete;
using MiniE_TicaretApplication.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniE_Ticaret.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();

        }
    }
}
