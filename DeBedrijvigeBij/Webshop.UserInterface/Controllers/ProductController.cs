﻿using System;
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

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct([Bind("Name,Description,Price")] Product product)
        {
            await new CreateProduct(_dbContext).Add(product);
            return View();
        }
    }
}
