using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Product;

    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime BestFrom { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime BestBefore { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime DateAdded { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int IsActive { get; set; }
    }
}
