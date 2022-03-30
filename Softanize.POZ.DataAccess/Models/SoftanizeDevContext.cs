using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Softanize.POZ.DataAccess.Models
{
    public class SoftanizeDevContext : IdentityDbContext
    {
        public SoftanizeDevContext()
        {
        }

        public SoftanizeDevContext(DbContextOptions<SoftanizeDevContext> options)
            : base(options)
        {
        }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<RecipeManagement> RecipeManagements { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Uom> Uoms { get; set; }
    }
}
