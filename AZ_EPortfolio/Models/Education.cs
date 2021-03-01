using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Education : PortfolioElement
    {
        public int EducationId { get; set; }

        public int PortfolioElementId { get; set; }

        public string Qualification { get; set; }

        public string SubjectArea { get; set; }

        public string Award { get; set; }

    }
}
