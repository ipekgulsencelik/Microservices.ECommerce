using ECommerce.Services.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services.Order.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;database=ECommerceOrderDB;user=sa;password=123456aA*");
        }

        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}