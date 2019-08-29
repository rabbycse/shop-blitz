using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applications.ProductsAdmin  
{
    using Database;
    public class GetProduct
    {
        private ApplicationDbContext _context;

        public GetProduct(ApplicationDbContext context) 
        {
            _context = context;
        }

        public ProductViewModel Do(int id) =>
         _context.Products.Where(x => x.Id == id).Select(x => new ProductViewModel
         {
             Name = x.Name,
             Description = x.Description,
             Value = x.Value,
         })
            .FirstOrDefault();
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }

}
