using Shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.App.ProductsAdmin
{
    class UpdateProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateProduct(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
