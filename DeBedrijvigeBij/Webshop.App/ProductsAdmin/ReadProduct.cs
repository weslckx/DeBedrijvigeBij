using Microsoft.EntityFrameworkCore;
using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Webshop.App.ViewModels;
using Webshop.Domain.Models;

namespace Webshop.App.ProductsAdmin
{
    class ReadProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public ReadProduct(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ProductAdminViewModel Get(int productId) => 
            _dbContext.Products.Where(x => x.ProductId == productId).Select(x=> new ProductAdminViewModel
            {

            ProductId = x.ProductId,
            Name = x.Name,
            Description = x.Description,
            Price = x.Price

            }
            ).FirstOrDefault();
     
    }
}
