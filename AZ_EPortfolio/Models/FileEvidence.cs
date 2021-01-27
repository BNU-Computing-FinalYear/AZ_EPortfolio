using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class FileEvidence : Evidence
    {
        [Key]
        private string FileEvidenceId { get; set; }

        [Required]
        [StringLength(30)]
        [DisplayName("File Name")]
        private string FileName { get; set; }

        private FileFormats FileFormat { get; set; }

    }
}
