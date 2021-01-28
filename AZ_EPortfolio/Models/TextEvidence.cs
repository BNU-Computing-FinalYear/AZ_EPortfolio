using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class TextEvidence : Evidence
    {
        [Key]
        public int TextEvidenceID { get; set; }

        [Required]
        [StringLength(5000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public TextFormats TextFormat { get; set; }

    }
}
