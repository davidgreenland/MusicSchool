﻿using Microsoft.EntityFrameworkCore;
using MusicSchool.Models;

namespace MusicSchool;

public class MusicSchoolDBContext: DbContext
{
    public MusicSchoolDBContext(DbContextOptions<MusicSchoolDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasMany(e => e.Instruments)
            .WithMany(e => e.Students)
            .UsingEntity<StudentInstrument>();

        modelBuilder.Entity<Instrument>()
            .HasOne(e => e.Category)
            .WithMany(e => e.Instruments)
            .HasForeignKey(e => e.CategoryId);
    }

    public DbSet<Student> Student { get; set; } = null!;
    public DbSet<Instrument> Instrument { get; set; } = null!;
    public DbSet<StudentInstrument> StudentInstrument { get; set; } = null!;
    public DbSet<Category> Category { get; set; } = null!;
}
