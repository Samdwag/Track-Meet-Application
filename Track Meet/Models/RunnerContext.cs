﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Track_Meet.Models;

public partial class RunnerContext : DbContext
{
    public RunnerContext()
    {
    }

    public RunnerContext(DbContextOptions<RunnerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Runner> Runners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
           // optionsBuilder.UseSqlServer("Server=DESKTOP-BTAINQ0\\SQLEXPRESS;Database=RUNNER;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-BTAINQ0\\SQLEXPRESS;Database=RUNNER;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Runner>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Event)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Result)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
