using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    public  class OrderProducts
    {
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; } 

        public Order Orders { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public Product Products { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
