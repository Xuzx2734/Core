using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CoreContext : DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> context) 
            :base(context)
        {
        }

        public DbSet<FY_User> FY_User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FY_User>().ToTable("FY_User");
        }

    }
}
