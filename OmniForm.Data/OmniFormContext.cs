using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OmniForm.Data.Model;

namespace OmniForm.Data
{
    public class OmniFormContext : IdentityDbContext
    {
        public OmniFormContext(DbContextOptions options) : base(options) { }

        //DbSets
        public DbSet<CustomerUser> CustomerUser { get; set; }
        public DbSet<PhoneNumber> PhoneNumber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
