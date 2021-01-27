using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class TextEvidence : Evidence
    {
        private int TextEvidenceID { get; set; }
        private string Text { get; set; }
        private TextFormats TextFormat { get; set; }

    }
}
