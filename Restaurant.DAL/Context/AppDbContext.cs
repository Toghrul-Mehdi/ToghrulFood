using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Id);
                
            modelBuilder.Entity<Category>()
                .HasMany(x=>x.Products)
                .WithOne(x=>x.Category)
                .HasForeignKey(x=>x.Id);

            modelBuilder.Entity<Product>(b =>
            {
                b.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(32);
                b.Property(x => x.Description)
                .HasMaxLength(400);              
                
            });
            modelBuilder.Entity<Category>(b =>
            {
                b.Property(x => x.CategoryName)
                .IsRequired()
                .HasMaxLength(32);
            });
            
            base.OnModelCreating(modelBuilder);
        }

    }
}
