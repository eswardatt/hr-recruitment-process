using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace recruitmentPortal.Models
{
    public class CompanyDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string CompanyID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string CompanyName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string CompanyEmail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string CompanyMobile { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string CompanyAlternateMobile { get; set; }

        public string CompanyLogo { get; set; }
        public string CompanyBranch { get; set; }

        public string CompanyStream { get; set; }
        public string CompanyAddress { get; set; }

        public int DeleteStatus { get; set; } = 1;


    }
}