using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class PortfolioElement
    {
        public int PortfolioElementId { get; set; }

        public PortfolioAreas Area { get; set; }

        public string Institution { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public Nullable<DateTime> EndDate { get; set; }

       
    }
}
