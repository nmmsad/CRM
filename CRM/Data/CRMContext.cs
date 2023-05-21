using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data;

    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<CRM.Models.Role> Role { get; set; }
        public DbSet<CRM.Models.Location> Location { get; set; }
        public DbSet<CRM.Models.Expenses> Expenses { get; set; }
        public DbSet<CRM.Models.CliesntsHistory> CliesntsHistory { get; set; }
        public DbSet<CRM.Models.UserTg> UserTg { get; set; }
        public DbSet<CRM.Models.Staff> Staff { get; set; }
        public DbSet<CRM.Models.StaffJob> StaffJob { get; set; }

    }

