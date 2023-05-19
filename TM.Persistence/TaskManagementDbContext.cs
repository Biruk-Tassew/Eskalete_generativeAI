using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TM.Domain.Common;
using TM.Domain;

namespace TM.Persistence
{
    public class TMDbContext : IdentityDbContext<IdentityUser>
    {
        public TMDbContext(DbContextOptions<TMDbContext> options)
           : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TMDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var entry in ChangeTracker.Entries<BaseModel>())
            {
                entry.Entity.UpdatedDate = DateTime.UtcNow;
            }  


            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<CheckList> CheckList { get; set; }
        

    }
}
