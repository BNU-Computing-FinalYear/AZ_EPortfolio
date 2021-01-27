using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
        public class ImageEvidence : Evidence
        {
            private string ImageEvidenceId { get; set; }
            private string ImageName { get; set; }
            private ImageFormats ImageFormat { get; set; }
            private double Height { get; set; }
            private double Width { get; set; }

    }
}
