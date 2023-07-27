using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Firm;
    public class Firm
    {
        public Firm()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(FirmNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(BulstatMaxLength)]
        public string Bulstat { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Address { get; set; } = null!;
    }
}
