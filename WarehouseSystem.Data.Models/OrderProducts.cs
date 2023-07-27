using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.Data.Models
{
    public class OrderProducts
    {
        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }

        public Order Order { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
