using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class User
    {
		[Key]
		private string UserId { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("First Name")]
		private string FirstName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Last Name")]
		private string LastName { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Career")]
		private string Career { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		private string Email { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.Password)]
		private string Password { get; set; }

	}
}
