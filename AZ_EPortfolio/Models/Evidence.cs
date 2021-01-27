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
        private string EvidenceId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Evidence Name")]
        private string EvidenceName { get; set; }

        private EvidenceTypes EvidenceType { get; set; }
    }
}
