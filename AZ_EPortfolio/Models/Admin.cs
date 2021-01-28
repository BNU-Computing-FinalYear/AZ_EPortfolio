using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Admin : AzUser
    {
		[Key]
		public int AdminId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Role Name")]
        public string Role { get; set; }

	}
}
