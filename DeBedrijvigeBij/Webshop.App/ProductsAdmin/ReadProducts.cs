using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Webshop.App.ViewModels;

namespace Webshop.App.ProductsAdmin
{
    public class ReadProducts
    {
        private ApplicationDbContext _dbContext { get; set; }

        public ReadProducts(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ProductAdminViewModel> Get() => _dbContext.Products.ToList().Select(x =>
            new ProductAdminViewModel
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Price = x.Price
            } );

    }
}
