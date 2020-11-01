using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //Nav Prop
        public ICollection<Stock> Stocks { get; set; } // only need add and remove, so ICollection
        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}
