﻿using Microsoft.EntityFrameworkCore;
using resala.core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Volunteers //

            builder.Entity<Volunteer>()
                .ToTable("Volunteers")
                .HasKey(p => p.Id);

            builder.Entity<Volunteer>().Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Entity<Volunteer>().Property(p => p.Name)
               .IsRequired()
               .HasMaxLength(30);

            builder.Entity<Volunteer>().Property(p => p.Phone).IsRequired();

            builder.Entity<Volunteer>().Property(p => p.Gender).IsRequired();

            builder.Entity<Volunteer>().HasOne(p => p.Branch).WithMany(b => b.Volunteers).HasForeignKey(v => v.BranchId);

            // Branch //

            builder.Entity<Branch>()
              .ToTable("Branches")
              .HasKey(p => p.Id);

            builder.Entity<Branch>().Property(p => p.Id)
              .IsRequired()
              .ValueGeneratedOnAdd();

            builder.Entity<Branch>().Property(p => p.Name).IsRequired();

            builder.Entity<Branch>().HasData
                (
                    new Branch { Id = 100,Name="Maadi" },
                    new Branch { Id = 101,Name="October" }
                );




        }
    }
}
