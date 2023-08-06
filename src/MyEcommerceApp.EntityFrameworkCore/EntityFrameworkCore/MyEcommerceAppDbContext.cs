using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyEcommerceApp.Authorization.Roles;
using MyEcommerceApp.Authorization.Users;
using MyEcommerceApp.MultiTenancy;

namespace MyEcommerceApp.EntityFrameworkCore
{
    public class MyEcommerceAppDbContext : AbpZeroDbContext<Tenant, Role, User, MyEcommerceAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyEcommerceAppDbContext(DbContextOptions<MyEcommerceAppDbContext> options)
            : base(options)
        {
        }
    }
}
