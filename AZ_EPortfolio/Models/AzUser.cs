using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class AzUser
    {
		[Key]
		public int AzUserId { get; set; }

		[StringLength(50)]
		public string UserId { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("First Name")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(20)]
		[DisplayName("Last Name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Career")]
		public string Career { get; set; }

		[Required]
		[StringLength(20)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		public EmploymentStatus EmploymentStatus { get; set; }

		[Required]
		[StringLength(16, ErrorMessage = "Please enter a valid UK contact number")]
		[DisplayName("Mobile No")]
		public int MobileNo { get; set; }

		public UserTypes UserType { get; set; }

	}
}
