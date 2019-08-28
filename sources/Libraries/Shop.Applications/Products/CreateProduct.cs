using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applications.Products
{
    using Shop.Database;
    using Shop.Domain.Models;
    public class CreateProduct
    {
        private ApplicationDbContext _contex;

        public CreateProduct(ApplicationDbContext context)
        {
            _contex = context;
        }

        public async Task Do(string name, string description, decimal value)
        {
            _contex.Products.Add(new Product
            {
                Name = name,
                Description = description,
                Value =value
            });

            await _contex.SaveChangesAsync(); 
        }
    }
}
