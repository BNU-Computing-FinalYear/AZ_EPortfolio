using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Employer : User
    {
        [Key]
        private string EmployerId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Company Name")]
        private string CompanyName { get; set; }

        [Required]
        [StringLength(5000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        private string Description { get; set; }
    }
}
