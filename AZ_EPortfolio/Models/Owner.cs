using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Owner : AzUser
    {
        [Key]
        public string OwnerId { get; set; }

        public EmploymentStatus EmploymentStatus { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Please enter a valid UK contact number")]
        [DisplayName("Mobile No")]
        public int MobileNo { get; set; }

        public OwnerTypes OwnerType { get; set; }

    }
}
