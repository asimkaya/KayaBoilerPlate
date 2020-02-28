using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Kaya.EntityFrameworkCore
{
    public static class KayaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KayaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KayaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
