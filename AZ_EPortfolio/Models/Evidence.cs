using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Evidence
    {
        [Key]
        public string EvidenceId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Evidence Name")]
        public string EvidenceName { get; set; }

        public EvidenceTypes EvidenceType { get; set; }
    }
}
