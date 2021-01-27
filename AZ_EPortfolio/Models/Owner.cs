using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Owner : User
    {
        [Key]
        private string OwnerId { get; set; }

        private EmploymentStatus EmploymentStatus { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Please enter a valid UK contact number")]
        [DisplayName("Mobile No")]
        private int MobileNo { get; set; }

        private OwnerTypes OwnerType { get; set; }

    }
}
