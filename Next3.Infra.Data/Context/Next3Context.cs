﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Next3.Infra.Data.Mapping;
using System.IO;
using System.Linq;

namespace Next3.Infra.Data.Context
{
    public class Next3Context : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ExpertiseMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new RestaurantMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new OrderItemMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderStatusMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
