using System;
using ICT13580095A3.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ICT13580095A3.Api.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products{get;set;}

        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        {
            
        }
    }
}
