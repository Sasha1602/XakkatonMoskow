using System;
using System.Collections.Generic;
using Avito.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Avito.Api.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<baseline_matrix_1> baseline_matrix_1s { get; set; }

    public virtual DbSet<baseline_matrix_2> baseline_matrix_2s { get; set; }

    public virtual DbSet<baseline_matrix_3> baseline_matrix_3s { get; set; }

    public virtual DbSet<discount_matrix_1> discount_matrix_1s { get; set; }

    public virtual DbSet<discount_matrix_2> discount_matrix_2s { get; set; }

    public virtual DbSet<discount_matrix_3> discount_matrix_3s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("Server=server204.hosting.reg.ru;Port=3306;Database=u2431422_Avito;Uid=u2431422_admin;Pwd=16022004LLL;", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.27-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<baseline_matrix_1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("baseline_matrix_1");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        modelBuilder.Entity<baseline_matrix_2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("baseline_matrix_2");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        modelBuilder.Entity<baseline_matrix_3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("baseline_matrix_3");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        modelBuilder.Entity<discount_matrix_1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("discount_matrix_1");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        modelBuilder.Entity<discount_matrix_2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("discount_matrix_2");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        modelBuilder.Entity<discount_matrix_3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("discount_matrix_3");

            entity.Property(e => e.location_id).HasColumnType("int(11)");
            entity.Property(e => e.microcategory_id).HasColumnType("int(11)");
            entity.Property(e => e.price).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
