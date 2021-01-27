using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Employer : User
    {
        private string EmployerId { get; set; }
        private string CompanyName { get; set; }
        private string Description { get; set; }
    }
}
