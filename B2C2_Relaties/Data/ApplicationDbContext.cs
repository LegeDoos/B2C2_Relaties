using B2C2_Relaties.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace B2C2_Relaties.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Product 1" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Product 2" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Product 3" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Product 4" });
            
            modelBuilder.Entity<Category>().HasData(new Category{ Id = 1, Name = "Category 1" });
            modelBuilder.Entity<Category>().HasData(new Category{ Id = 2, Name = "Category 2" });
            modelBuilder.Entity<Category>().HasData(new Category{ Id = 3, Name = "Category 3" });
            modelBuilder.Entity<Category>().HasData(new Category{ Id = 4, Name = "Category 4" });
            modelBuilder.Entity<Category>().HasData(new Category{ Id = 5, Name = "Category 5" });

        }
    }
}