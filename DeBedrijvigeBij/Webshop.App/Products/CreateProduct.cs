using Shop.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webshop.App.ViewModels;
using Webshop.Domain.Models;

namespace Webshop.App.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _dbContext;

        // dependency Injection
        public CreateProduct(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public void Do(string name, string description, decimal price)
        //{
        //    _DbContext.Products.Add(new Product
        //    {
        //        Name = name,
        //        Description=description,
        //        Price=price
        //    });
           
        //}

        public async Task Add(Product product) // task<int> bv, of task == gewoon void
        {
            _dbContext.Products.Add(product);
           await _dbContext.SaveChangesAsync();
        }
    }
}
