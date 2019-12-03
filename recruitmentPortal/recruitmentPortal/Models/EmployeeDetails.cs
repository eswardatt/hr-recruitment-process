using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace recruitmentPortal.Models
{
    public class EmployeeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string EmployeeId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string EmployeeName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string EmployeeEmail { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeMobile { get; set; }


        public string EmployeeDesignation { get; set; }
        public string EmployeeImagePath { get; set; }
        public string EmployeeDOB { get; set; }
        [ForeignKey("AdminId")]
        public virtual AdminDetails AdminDetails { get; set; }
        [ForeignKey("CompanyID")]
        public virtual CompanyDetails CompanyDetails { get; set; }

        [ForeignKey("EmployeeRoleId")]
        public virtual Roles Roles { get; set; }
        public int DeleteStatus { get; set; } = 1;



    }
}