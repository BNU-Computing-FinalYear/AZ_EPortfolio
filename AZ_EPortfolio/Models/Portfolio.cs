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
        public int PortfolioId { get; set; }

        [StringLength(64)]
        [DisplayName("User Id")]
        public string UserKey { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("Portfolio Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("Author Name")]
        public string Author { get; set; }

        public ICollection<PortfolioElement> Elements { get; set; }

        public ICollection<Education> EducationElements { get; set; }

        public virtual ICollection<Template> Templates { get; set; }
    }
}
