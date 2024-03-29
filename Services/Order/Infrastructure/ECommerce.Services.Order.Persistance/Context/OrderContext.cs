﻿using ECommerce.Services.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services.Order.Persistance.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1450;database=ECommerceOrderDB;user=sa;password=123456aA*;integrated security=true;trusted_connection=false;encrypt=false");
        }

        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}