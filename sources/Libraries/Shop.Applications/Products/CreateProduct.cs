using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applications.CreateProducts 
{
    using Shop.Applications.GetProducts;
    using Shop.Database;
    using Shop.Domain.Models;
    public class CreateProduct
    {
        private ApplicationDbContext _contex;

        public CreateProduct(ApplicationDbContext context)
        {
            _contex = context;
        }

        public async Task Do(ProductViewModel vm)
        {
            _contex.Products.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value
            });

            await _contex.SaveChangesAsync(); 
        }

    }

    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
