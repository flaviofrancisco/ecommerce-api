using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyEcommerceApp.EntityFrameworkCore
{
    public static class MyEcommerceAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyEcommerceAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyEcommerceAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
