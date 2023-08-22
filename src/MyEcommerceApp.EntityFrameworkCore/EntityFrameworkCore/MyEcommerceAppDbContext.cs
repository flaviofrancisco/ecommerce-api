using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyEcommerceApp.Authorization.Roles;
using MyEcommerceApp.Authorization.Users;
using MyEcommerceApp.MultiTenancy;
using MyEcommerceApp.App.Products;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Categories;
using MyEcommerceApp.App.Volumes;
using MyEcommerceApp.App.Sizes;
using System.Linq;
using Abp.MultiTenancy;

namespace MyEcommerceApp.EntityFrameworkCore
{
    public class MyEcommerceAppDbContext : AbpZeroDbContext<Tenant, Role, User, MyEcommerceAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Volume> Volumes { get; set; }

        public MyEcommerceAppDbContext(DbContextOptions<MyEcommerceAppDbContext> options)
            : base(options)
        {
        }
                        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId }); // Define composite primary key

            modelBuilder.Entity<ProductCategory>()
                .ToTable("ProductCategories"); // Define the table name

            modelBuilder.Entity<Category>()
                .HasOne(c => c.Parent)
                .WithMany()
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Restrict); // Turn off cascading delete

            modelBuilder.Entity<User>()
                .HasOne(u => u.CreatorUser).WithMany().HasForeignKey(x => x.CreatorUserId);

            modelBuilder.Entity<User>().HasOne(u => u.DeleterUser).WithMany().HasForeignKey(u => u.DeleterUserId);

            modelBuilder.Entity<User>().HasOne(u => u.LastModifierUser).WithMany().HasForeignKey(u => u.LastModifierUserId);

            modelBuilder.Entity<Tenant>().HasOne(t => t.CreatorUser).WithMany().HasForeignKey(t => t.CreatorUserId);

        }
    }
}
