using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.App.ProductsAdmin
{
    public class DeleteProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProduct(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Do(int productId)
        {
            var product = _dbContext.Products.FirstOrDefault(x => x.ProductId == productId);
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
