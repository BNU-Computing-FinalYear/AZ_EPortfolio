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
		public int TemplateId { get; set; }

		public int PortfolioId { get; set; }

		public TemplateTypes TemplateType { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Description")]
		[DataType(DataType.MultilineText)]
		public string Summary { get; set; }

		[Required]
		[StringLength(500)]
		[DataType(DataType.Url)]
		[DisplayName("Image URL")]
		public string Picture { get; set; }

		[Required]
		[StringLength(50)]
		[DisplayName("Skill Tags")]
		public string SkillTags { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Resume")]
		[DataType(DataType.MultilineText)]
		public string Resume { get; set; }

		[Required]
		[StringLength(5000)]
		[DisplayName("Education")]
		[DataType(DataType.MultilineText)]
		public string Education { get; set; }

		public virtual Portfolio Portfolio { get; set; }

	}
}
