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

        public void Do(int id, string name, string description)
        {
            _contex.Products.Add(new Product
            {
                Id = id,
                Name = name,
                Description = description
            });
        }
    }
}
