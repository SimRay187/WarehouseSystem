using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Data.Models
{
    using static Common.EntityValidationConstants.Employee;
    
     public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }=null!;

        [Required]
        [MaxLength(SecondNameMaxLength)]
        public string SecondName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Range(18,100)]
        public int Age { get; set; }


        /* da widim ot Usera Orderite my
        public ApplicationUser() {
         this.UserOrders=new HashSet<Order>();
        }

        public virtual ICollection<Order>UserOrders { get; set; }
         */

    }
    
}
