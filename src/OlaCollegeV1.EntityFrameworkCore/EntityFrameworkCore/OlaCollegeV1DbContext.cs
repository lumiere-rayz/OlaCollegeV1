using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OlaCollegeV1.Authorization.Roles;
using OlaCollegeV1.Authorization.Users;
using OlaCollegeV1.MultiTenancy;
using OlaCollegeV1.Models;

namespace OlaCollegeV1.EntityFrameworkCore
{
    public class OlaCollegeV1DbContext : AbpZeroDbContext<Tenant, Role, User, OlaCollegeV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OlaCollegeV1DbContext(DbContextOptions<OlaCollegeV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
        public virtual DbSet<Student> Students { get; set; }
    }
}
