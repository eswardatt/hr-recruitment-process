using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace recruitmentPortal.Models
{
    public class Profiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string ProfileName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Technology { get => _Technology; set => _Technology = value; }
        [Required(AllowEmptyStrings = false)]
        public string Experience { get => _Experience; set => _Experience = value; }
        [Required(AllowEmptyStrings = false)]
        public string ResumePath { get => _ResumePath; set => _ResumePath = value; }
        public string ProfileId { get => _ProfileId; set => _ProfileId = value; }

        [Required(AllowEmptyStrings = false)]
        public string ProfileEmail { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ProfileMobile { get; set; }

        [ForeignKey("AdminId")]
        public virtual AdminDetails AdminDetails { get; set; }
        [ForeignKey("CompanyID")]
        public virtual CompanyDetails CompanyDetails { get; set; }

        [ForeignKey("EmployeeRoleId")]
        public virtual Roles Roles { get; set; }
        public int DeleteStatus { get; set; } = 1;
        public string ProfileStatus { get => _ProfileStatus; set => _ProfileStatus = value; }

        string _ProfileId;
        string _ResumePath;
        string _Experience;
        string _Technology;
        string _ProfileStatus;
    }
}