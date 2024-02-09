using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OlaCollegeV1.Authorization.Roles;
using OlaCollegeV1.Authorization.Users;
using OlaCollegeV1.MultiTenancy;

namespace OlaCollegeV1.EntityFrameworkCore
{
    public class OlaCollegeV1DbContext : AbpZeroDbContext<Tenant, Role, User, OlaCollegeV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OlaCollegeV1DbContext(DbContextOptions<OlaCollegeV1DbContext> options)
            : base(options)
        {
        }
    }
}
