using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Order;

    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;


        public IEnumerable<OrderProducts> OrdersProducts { get; set; } = new List<OrderProducts>();

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime Deadline { get; set; }


        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(Board))]
        public Guid BoardId { get; set; }

        public virtual Board Board { get; set; } = null!;

        [ForeignKey(nameof(Firm))]
        public Guid FirmId { get; set; }

        public Firm Firm { get; set; } = null!;

        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }

        public ApplicationUser Employee { get; set; } = null!;

    }
}
