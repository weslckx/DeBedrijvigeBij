using Shop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Webshop.Domain.Models;

namespace Webshop.App.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _DbContext;

        // dependency Injection
        public CreateProduct(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Do(string name, string description, decimal price)
        {
            _DbContext.Products.Add(new Product
            {
                Name = name,
                Description=description,
                Price=price
            });
           
        }
    }
}
