using GI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Database
{
    public class DatabaseContext:IdentityDbContext<AppUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<OrderCivilModel> RegisterCivil { get; set; }
        public DbSet<Birthcertificate> Birthcertificates { get; set; }
        public DbSet<MarriageCertificate> MarriageCertificate { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().ToTable("AspNetUsers").Ignore(e => e.EmailConfirmed);
            builder.Entity<AppUser>().ToTable("AspNetUsers").Ignore(e => e.PhoneNumberConfirmed);
            builder.Entity<AppUser>().ToTable("AspNetUsers").Ignore(e => e.TwoFactorEnabled);
            builder.Entity<AppUser>().ToTable("AspNetUsers").Ignore(e => e.LockoutEnabled);
            builder.Entity<AppUser>().ToTable("AspNetUsers").Ignore(e => e.AccessFailedCount);
            //builder.Entity<OrderCivilModel>().HasIndex(x => x.CardID).IsUnique();
        }
    }
}
