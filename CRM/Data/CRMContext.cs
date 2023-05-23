using Microsoft.EntityFrameworkCore;
using CRM.Models;

namespace CRM.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<CRM.Models.Role> Role { get; set; }
        public DbSet<CRM.Models.Location> Location { get; set; }
        public DbSet<CRM.Models.Expenses> Expenses { get; set; }
        public DbSet<CRM.Models.CliesntsHistory> CliesntsHistory { get; set; }
        public DbSet<CRM.Models.UserTg> UserTg { get; set; }
        public DbSet<CRM.Models.StaffJob> StaffJob { get; set; }
        public DbSet<CRM.Models.Client> Client { get; set; }

    }
}