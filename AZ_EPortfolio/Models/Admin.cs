﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Admin : User
    {
		[Key]
		private int AdminId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Role Name")]
        private string Role { get; set; }

	}
}
