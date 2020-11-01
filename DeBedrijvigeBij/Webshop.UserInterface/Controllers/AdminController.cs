using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Webshop.App.Products;
using Webshop.App.ProductsAdmin;
using Webshop.App.ViewModels;
using Webshop.Domain.Models;

namespace Webshop.UserInterface.Controllers
{
    [Route("[controller]")] //Also want to work with orders, dus expliciet router configureren
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
            => Ok(new App.ProductsAdmin.ReadProducts(_dbContext).Get()); //nakijken => will return IactionResult if not found?

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id)
            => Ok(new ReadProduct(_dbContext).Get(id));

        // nog aanpassen naar viewmodel hier;

        public IActionResult CreateProduct(Product viewModel) => Ok(new CreateProduct(_dbContext).Add(viewModel));
       
   
        [HttpGet("products/{id}")]
        public IActionResult DeleteProduct(int id)
           => Ok(new DeleteProduct(_dbContext).Do(id));

        [HttpPut("products")]
        public IActionResult UpdateProduct(ProductViewModel viewModel) => Ok(new UpdateProduct(_dbContext).Do(viewModel));
           //Still to do


    }
}
