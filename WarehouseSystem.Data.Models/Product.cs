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
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime BestFrom { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime BestBefore { get; set;}

        [Required]
        public int Count { get; set; }
        
        public bool IsAvailable { get; set; } 
    }
}
