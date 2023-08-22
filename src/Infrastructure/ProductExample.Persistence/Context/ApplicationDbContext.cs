﻿using Microsoft.EntityFrameworkCore;
using Lms.Application.Interfaces.Context;
using Lms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lms.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Product1", Price = 10, Quantity = 10, Stock = 10 },
                new Product { Id = Guid.NewGuid(), Name = "Product2", Price = 20, Quantity = 20, Stock = 20 },
                new Product { Id = Guid.NewGuid(), Name = "Product3", Price = 30, Quantity = 30, Stock = 30 }
                );
        }
    }
}