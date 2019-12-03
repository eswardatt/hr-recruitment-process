using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace recruitmentPortal.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("DefaultConnection")
        {

        }
        public DbSet<CompanyDetails> GetCompanyDetails { get; set; }
        public DbSet<AdminDetails> GetAdminDetails { get; set; }
        public DbSet<ClientDetails> GetClientDetails { get; set; }
        public DbSet<EmployeeDetails> GetEmployeeDetails { get; set; }
        public DbSet<Profiles> GetProfiles { get; set; }
        public DbSet<Requirements> GetRequirements { get; set; }
        public DbSet<Roles> GetRoles { get; set; }

    }
}