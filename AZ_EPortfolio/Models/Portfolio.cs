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

        [StringLength(5000)]
        [DisplayName("Skills")]
        [DataType(DataType.MultilineText)]
        public string Skills { get; set; }

        [StringLength(5000)]
        [DisplayName("Knowledge")]
        [DataType(DataType.MultilineText)]
        public string Knowledge { get; set; }

        [StringLength(5000)]
        [DisplayName("Experience")]
        [DataType(DataType.MultilineText)]
        public string Experience { get; set; }

        public virtual ICollection<Template> Templates { get; set; }
    }
}
