using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Owner : User
    {
        private string OwnerId { get; set; }
        private EmploymentStatus EmploymentStatus { get; set; }
        private int MobileNo { get; set; }
        private OwnerTypes OwnerType { get; set; }

    }
}
