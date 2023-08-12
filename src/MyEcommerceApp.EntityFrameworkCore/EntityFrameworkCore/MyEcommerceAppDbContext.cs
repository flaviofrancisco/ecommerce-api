using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyEcommerceApp.Authorization.Roles;
using MyEcommerceApp.Authorization.Users;
using MyEcommerceApp.MultiTenancy;
using MyEcommerceApp.App.Products;

namespace MyEcommerceApp.EntityFrameworkCore
{
    public class MyEcommerceAppDbContext : AbpZeroDbContext<Tenant, Role, User, MyEcommerceAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        
        public MyEcommerceAppDbContext(DbContextOptions<MyEcommerceAppDbContext> options)
            : base(options)
        {
        }
    }
}
