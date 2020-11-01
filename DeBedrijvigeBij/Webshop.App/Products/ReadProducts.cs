using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Webshop.App.ViewModels;

namespace Webshop.App.Products
{
    public class ReadProducts
    {
        private ApplicationDbContext _dbContext { get; set; }

        public ReadProducts(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public IEnumerable<ProductViewModel> Get()
        //{
        //    return _dbContext.Products.ToList().Select(x =>
        //    new ProductViewModel
        //    {
        //        Name = x.Name,
        //        Description = x.Description,
        //        Price = $"€ { x.Price:N2}" // to string
        //    }
        //    ) ;
        //}

        public IEnumerable<ProductViewModel> Get() => _dbContext.Products.ToList().Select(x =>
            new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Price = $"€ { x.Price:N2}" // to string
            } );

    }
}
