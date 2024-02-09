using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OlaCollegeV1.EntityFrameworkCore
{
    public static class OlaCollegeV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OlaCollegeV1DbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OlaCollegeV1DbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
