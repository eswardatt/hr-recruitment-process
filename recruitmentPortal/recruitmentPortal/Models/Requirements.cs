using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace recruitmentPortal.Models
{
    public class Requirements
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RequirementId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string RequirementType { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string JobType { get; set; }

        [ForeignKey("CompanyID")]
        public virtual CompanyDetails CompanyDetails { get; set; }

        [ForeignKey("ClientID")]
        public virtual ClientDetails ClientDetails { get; set; }

        [ForeignKey("AdminId")]
        public virtual AdminDetails AdminDetails { get; set; }


    }
}