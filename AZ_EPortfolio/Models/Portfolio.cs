using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Portfolio
    {
        [Key]
        private string PortfolioId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Skills")]
        private string Skills { get; set; }

        [Required]
        [StringLength(5000)]
        [DisplayName("Knowledge")]
        [DataType(DataType.MultilineText)]
        private string Knowledge { get; set; }

        [Required]
        [StringLength(5000)]
        [DisplayName("Experience")]
        [DataType(DataType.MultilineText)]
        private string Experience { get; set; }

    }
}
