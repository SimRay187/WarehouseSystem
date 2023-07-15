using System.ComponentModel.DataAnnotations;


namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Board;

    public class Board
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;


    }
}