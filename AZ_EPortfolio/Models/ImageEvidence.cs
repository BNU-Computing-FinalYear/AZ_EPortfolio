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
            public int ImageEvidenceId { get; set; }

            [Required]
            [StringLength(20)]
            [DisplayName("Image Name")]
            public string ImageName { get; set; }

            public ImageFormats ImageFormat { get; set; }

            public double Height { get; set; }

            public double Width { get; set; }

    }
}
