using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderRef { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
