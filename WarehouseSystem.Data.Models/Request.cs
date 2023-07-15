using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Request;

    public class Request
    {
        public Request ()
        { 
            this.Id = Guid.NewGuid(); 
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string Products { get; set; } = null!;

        public int ProductsCount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime Deadline { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(Board))]
        public int BoardId { get; set; }

        public virtual Board Board { get; set; } 

        [Required]
        [MaxLength(FirmNameMaxLength)]
        public string Firm { get; set; } = null!;

        [Required]
        public string Creator { get; set; } = null!;

    }
}
