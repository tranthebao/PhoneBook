using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Farm.EntityFrameworkCore
{
    public static class FarmDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FarmDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FarmDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
