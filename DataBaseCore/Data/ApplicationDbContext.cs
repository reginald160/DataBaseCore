using System;
using System.Collections.Generic;
using System.Text;
using DataBaseCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataBaseCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> ProductTb { get; set; }
        public DbSet<Supplier>  SupplierTb { get; set; }
        public DbSet<Color> ColorTab { get; set; }
        public DbSet<ProductShipmentJunction> ProductShipmentJunctionsTb { get; set; }

    }
}
