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
        public string PortfolioId { get; set; }

        [StringLength(1000)]
        [DisplayName("Skills")]
        public string Skills { get; set; }

        [StringLength(5000)]
        [DisplayName("Knowledge")]
        [DataType(DataType.MultilineText)]
        public string Knowledge { get; set; }

        [StringLength(5000)]
        [DisplayName("Experience")]
        [DataType(DataType.MultilineText)]
        public string Experience { get; set; }

    }
}
