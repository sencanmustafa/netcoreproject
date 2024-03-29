﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //db context (db class , this class mapping in the db`s column)
    public class NorthwindContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SENCAN;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product>  ?Products { get; set; }
        public DbSet<Category> ?Categories { get; set; }
        public DbSet<Customer> ?Customers { get; set; }
        public DbSet<Order> ?Orders { get; set; }

    }
}
