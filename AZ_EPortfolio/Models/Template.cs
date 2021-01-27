using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class Template
    {
		[Key]
		private string TemplateId { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Description")]
		[DataType(DataType.MultilineText)]
		private string Summary { get; set; }

		[Required]
		[StringLength(500)]
		[DataType(DataType.Url)]
		[DisplayName("Image URL")]
		private string Picture { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Description")]
		private string SkillTags { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Description")]
		[DataType(DataType.MultilineText)]
		private string Resume { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Description")]
		[DataType(DataType.MultilineText)]
		private string Education { get; set; }
	}
}
