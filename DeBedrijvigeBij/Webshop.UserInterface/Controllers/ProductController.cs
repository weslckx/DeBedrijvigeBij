using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Webshop.App.Products;
using Webshop.App.ViewModels; // proper of niet?
using Webshop.Domain.Models;

namespace Webshop.UserInterface.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _dbContext { get; set; }

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(new ReadProducts(_dbContext).Get());
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([Bind("Name,Description,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                await new CreateProduct(_dbContext).Add(product);
                return RedirectToAction("ProductCreated",product);
            }

            return View(product);
        }

        public IActionResult ProductCreated(Product product)
        {

            return View(product);
        }

    }
}
