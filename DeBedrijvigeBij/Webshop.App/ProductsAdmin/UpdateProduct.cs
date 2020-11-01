using Shop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Webshop.App.ViewModels;

namespace Webshop.App.ProductsAdmin
{
    public class UpdateProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateProduct(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

 public ProductAdminViewModel Do(ProductViewModel model) { return null; } //temporary fix

    }
}
