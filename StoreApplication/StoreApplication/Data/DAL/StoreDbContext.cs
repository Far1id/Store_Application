using Microsoft.EntityFrameworkCore;
using StoreApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApplication.Data.DAL
{
    public class StoreDbContext: DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=USER-PC\SQLEXPRESS;Database=StoreApplication;Trusted_Connection=True"); 
        }
    }
}
