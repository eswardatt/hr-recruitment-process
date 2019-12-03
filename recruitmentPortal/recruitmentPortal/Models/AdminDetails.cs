using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recruitmentPortal.Models
{
    public class AdminDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string AdminName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string AdminEmail { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string AdminMobile { get; set; }
        public string AdminImagepath { get; set; }
        public string AdminEmployeeId { get; set; }
        public int DeleteStatus { get; set; } = 1;
    }
}