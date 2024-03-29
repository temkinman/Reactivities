﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using static System.Formats.Asn1.AsnWriter;

namespace Persistence.Db;

public class DataContext : IdentityDbContext<AppUser>
{
	public DataContext(DbContextOptions<DataContext> options) : base(options)
	{ }

	public DbSet<Activity> Activities { get; set; }
    public DbSet<ActivityAttendee> ActivityAttendees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var userManager = this.GetService<UserManager<AppUser>>();
        base.OnModelCreating(modelBuilder);

        // many to many relationships
        modelBuilder.Entity<ActivityAttendee>(x => x.HasKey(aa => new {aa.AppUserId, aa.ActivityId}));

        modelBuilder.Entity<ActivityAttendee>()
            .HasOne(u => u.AppUser)
            .WithMany(a => a.Activities)
            .HasForeignKey(aa => aa.AppUserId);

        modelBuilder.Entity<ActivityAttendee>()
            .HasOne(u => u.Activity)
        .WithMany(a => a.Attendees)
        .HasForeignKey(aa => aa.ActivityId);

        modelBuilder.SeedData(userManager);
    }
}
