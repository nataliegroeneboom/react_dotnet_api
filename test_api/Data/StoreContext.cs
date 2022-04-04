using System;
using Microsoft.EntityFrameworkCore;
using test_api.Entities;

namespace test_api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}

