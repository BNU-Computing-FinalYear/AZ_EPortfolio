using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AZ_EPortfolio.Areas.Identity.Pages.Account.LoginModel;
using AZ_EPortfolio.Models;

namespace AZ_EPortfolio.ViewModels
{
    public class UserViewModel
    {
        public InputModel InputModel { get; set; }
        public AzUser AzUser { get; set; }
    }
}
