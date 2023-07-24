using System;
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
        public Order ()
        { 
            this.Id = Guid.NewGuid(); 
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } 

        [ForeignKey(nameof(Board))]
        public int BoardId { get; set; }

        public virtual Board Board { get; set; }
        
        [ForeignKey(nameof(Firm))]
        public int FirmId { get; set; }

        [Required]
        [MaxLength(FirmNameMaxLength)]
        public string Firm { get; set; } = null!;

        //ApplicationUser

    }
}
