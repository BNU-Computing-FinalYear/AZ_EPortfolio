using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZ_EPortfolio.Models
{
    public class JournalEntry
    {
        [Key]
        private string JournalEntryId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        private string Title { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        private DateTime date { get; set; }

    }
}
