using System.ComponentModel.DataAnnotations;


namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Board;

    public class Board
    {
        public Board()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}