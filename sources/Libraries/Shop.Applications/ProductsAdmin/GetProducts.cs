﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applications.ProductsAdmin 
{
    using Database;
    public class GetProducts
    {
        private ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>
         _context.Products.ToList().Select(x => new ProductViewModel
         {
             Id = x.Id,
             Name = x.Name,
             Description = x.Description,
             Value = x.Value,
         });
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }

}
