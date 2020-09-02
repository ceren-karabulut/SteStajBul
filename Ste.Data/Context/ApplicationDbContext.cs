using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ste.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ste.Data.Context
{
   public class ApplicationDbContext : IdentityDbContext<CompanyUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Advertisiment>()
                .HasOne(c => c.CompanyUser)
                .WithMany(s => s.Advertisiments)
                .HasForeignKey(c => c.CompanyId);

            builder.Entity<Student>()
                .HasOne(a => a.Advertisiment)
                .WithMany(s => s.Students)
                .HasForeignKey(a => a.AdvertisimentId);


            base.OnModelCreating(builder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Advertisiment> Advertisiments { get;set; }
        

    }
}
