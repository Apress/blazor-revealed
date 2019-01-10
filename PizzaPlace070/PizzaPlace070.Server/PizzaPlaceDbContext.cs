using Microsoft.EntityFrameworkCore;
using PizzaPlace070.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace070.Server
{
  public class PizzaPlaceDbContext : DbContext
  {

    public PizzaPlaceDbContext(
      DbContextOptions<PizzaPlaceDbContext> options)
      : base(options)
    { }

    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PizzaOrder> PizzaOrders { get; set; }


    protected override void OnModelCreating(
      ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      var pizzaEntity = modelBuilder.Entity<Pizza>();
      pizzaEntity.HasKey(pizza => pizza.Id);
      pizzaEntity.Property(pizza => pizza.Price)
                 .HasColumnType("money");

      var customerEntity = modelBuilder.Entity<Customer>();
      customerEntity.HasKey(customer => customer.Id);
      customerEntity.HasOne(customer => customer.Order)
                    .WithOne(order => order.Customer)
                    .HasForeignKey<Order>(
                       order => order.CustomerId);

      var orderEntity = modelBuilder.Entity<Order>();
      orderEntity.HasKey(order => order.Id);
      orderEntity.HasMany(order => order.PizzaOrders)
                 .WithOne(pizzaOrder => pizzaOrder.Order);

      pizzaEntity.HasMany(pizza => pizza.PizzaOrders)
                 .WithOne(pizzaOrder => pizzaOrder.Pizza);

    }
  }
}
