using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class FileEvidence : Evidence
    {
        private string FileEvidenceId { get; set; }
        private string FileName { get; set; }
        private FileFormats FileFormat { get; set; }

    }
}
