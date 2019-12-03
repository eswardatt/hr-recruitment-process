using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recruitmentPortal.Models
{
    public class ClientDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ClientId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientEmail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientMobile { get; set; }
        public string ClientLogoPath { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientLocation { get; set; }
        public string ClientBranch { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ClientStream { get; set; }
        public string ClientAddress { get; set; }
        [ForeignKey("AdminId")]
        public virtual AdminDetails AdminDetails { get; set; }

        [ForeignKey("CompanyID")]
        public virtual CompanyDetails CompanyDetails { get; set; }
        public int DeleteStatus { get; set; } = 1;



    }
}