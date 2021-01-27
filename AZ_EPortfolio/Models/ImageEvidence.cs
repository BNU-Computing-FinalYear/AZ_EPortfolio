using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
        public class ImageEvidence : Evidence
        {
            [Key]
            private string ImageEvidenceId { get; set; }

            [Required]
            [StringLength(20)]
            [DisplayName("Image Name")]
            private string ImageName { get; set; }

            private ImageFormats ImageFormat { get; set; }

            private double Height { get; set; }

            private double Width { get; set; }

    }
}
