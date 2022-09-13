using MiniE_Ticaret.Domain.Entities;
using MiniE_TicaretApplication.Abstraction;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniE_Ticaret.Persistance.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1 ",
                    Price = 300,
                    Stock = 45
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2 ",
                    Price = 400,
                    Stock = 45
                },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3 ",
                    Price = 350,
                    Stock = 45
                },
                new Product()
                {
                    Id = 4,
                    Name = "Product 4 ",
                    Price = 550,
                    Stock = 45
                }

            };

        }   
            
    }
}
