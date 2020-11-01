using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Domain.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        //Nav Prop
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
