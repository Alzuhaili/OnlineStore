using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnineStore.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Orders = OnineStore.Shared.Models.OrderModels;
using General = OnineStore.Shared.Models.GeneralModels;
using Products = OnineStore.Shared.Models.ProductModels;
using OnineStore.Shared.Models.GeneralModels;
using OnineStore.Shared.Models.ProductModels;
using OnineStore.Shared.Models.OrderModels;

namespace OnineStore.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<General.Category> Categories { get; set; }
        public DbSet<General.Customer> Customers { get; set; }
        
        public DbSet<Orders.Order> Orders { get; set; }
        public DbSet<Orders.OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders.OrderProduct> OrderProduct { get; set; }
        
        public DbSet<Products.Product> Products { get; set; }
        public DbSet<Products.Option> Options { get; set; }
        public DbSet<Products.ProductOption> ProductOptions { get; set; }



        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasMany(o => o.Orders)
                .WithOne(c => c.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);            
            
            builder.Entity<Category>().HasMany(c => c.Products)
                .WithOne(c => c.Category)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Option>().HasMany(c => c.ProductOptions)
                .WithOne(c => c.Option)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Product>().HasMany(c => c.ProductOptions)
                .WithOne(c => c.Product)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasMany(c => c.OrderProducts)
                .WithOne(c => c.Order)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Product>().HasMany(c => c.OrderProducts)
                .WithOne(c => c.Product)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderDetails>().HasKey(c=>new { c.OrderId,c.ProductId});
            builder.Entity<OrderProduct>().HasKey(c => new { c.ProductId, c.OrderId });
            builder.Entity<ProductOption>().HasKey(c => new { c.ProductId, c.OptionId });

            builder.Entity<Order>().Property(o => o.Amount).HasPrecision(5, 4); // 54785.4561

            base.OnModelCreating(builder);
        }
    }
}
